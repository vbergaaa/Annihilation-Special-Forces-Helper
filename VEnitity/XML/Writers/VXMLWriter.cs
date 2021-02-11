using System.Collections;
using System.IO;
using System.Xml;
using VEntityFramework.Data;

namespace VEntityFramework.XML
{
	class VXMLWriter
	{
		internal void Write(VBusinessObject bizo)
		{
			var fullFilePath = RenameFileIfNeccessary(bizo);

			using (var stream = File.Create(fullFilePath))
			using (var writer = GetXmlWriter(stream))
			{
				WriteXML(writer, bizo);
			}
			bizo.XmlLocation = fullFilePath;
		}

		string RenameFileIfNeccessary(VBusinessObject bizo)
		{
			var newNameWithPath = GetFileNameWithExtension(bizo);

			if (bizo.XmlLocation != null && bizo.XmlLocation != newNameWithPath)
			{
				File.Move(bizo.XmlLocation, newNameWithPath); ;
			}

			return newNameWithPath;
		}

		XmlWriter GetXmlWriter(Stream stream)
		{
			var xmlSettings = new XmlWriterSettings();
			xmlSettings.Indent = true;
			xmlSettings.CloseOutput = true;
			return XmlWriter.Create(stream, xmlSettings);
		}

		void WriteXML(XmlWriter writer, VBusinessObject bizo)
		{
			if (bizo != null)
			{
				writer.WriteStartElement(bizo.BizoName);
				foreach (var property in bizo.GetType().GetProperties())
				{
					if (property.IncludeInVXml())
					{
						if (property.IsBusinessObject())
						{
							WriteXML(writer, (VBusinessObject)property.GetValue(bizo));
						}
						else if (typeof(IList).IsAssignableFrom(property.PropertyType))
						{
							WriteListToXml(writer, bizo, property);
						}
						else
						{
							writer.WriteStartElement(property.Name);
							writer.WriteString(property.GetValue(bizo)?.ToString() ?? "");
							writer.WriteEndElement();
						}
					}
				}
				writer.WriteEndElement();
				bizo.HasChanges = false;
			}
		}

		void WriteListToXml(XmlWriter writer, VBusinessObject bizo, System.Reflection.PropertyInfo property)
		{
			var value = property.GetValue(bizo);
			if (value is IList list)
			{
				writer.WriteStartElement(property.Name);

				foreach (var item in list)
				{
					if (item is VBusinessObject childBizo)
					{
						WriteXML(writer, childBizo);
					}
					else
					{
						writer.WriteStartElement("Item");
						writer.WriteString(item.ToString());
						writer.WriteEndElement();
					}
				}
				writer.WriteEndElement();
			}
		}

		string GetFileNameWithExtension(VBusinessObject bizo)
		{
			return DirectoryManager.GetFullDirectory(bizo.GetType()) + bizo.GetSaveNameForXML() + ".xml";
		}
	}
}
