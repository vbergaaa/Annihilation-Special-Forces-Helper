using System.Collections;
using System.IO;
using System.Xml;
using VEntityFramework.Data;
using VEntityFramework.Model;

namespace VEntityFramework.XML
{
	class VXMLWriter
	{
		internal void Write(BusinessObject bizo)
		{
			var fullFilePath = RenameFileIfNeccessary(bizo);

			using (var stream = File.Create(fullFilePath))
			using (var writer = GetXmlWriter(stream))
			{
				WriteBizoXML(writer, bizo);
			}
			bizo.ExistsInXML = true;
			bizo.XmlLocation = fullFilePath;
		}

		string RenameFileIfNeccessary(BusinessObject bizo)
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

		void WriteBizoXML(XmlWriter writer, BusinessObject bizo)
		{
			if (bizo != null)
			{
				writer.WriteStartElement(bizo.BizoName);
				foreach (var property in bizo.GetType().GetProperties())
				{
					if (property.IncludeInVXml())
					{
						if (property.IsXmlObject())
						{
							if (property.IsBusinessObject())
							{
								WriteBizoXML(writer, (BusinessObject)property.GetValue(bizo));
							}
							else
							{
								WriteXmlObject(writer, (IXmlObject)property.GetValue(bizo));
							}
						}
						else if (typeof(IList).IsAssignableFrom(property.PropertyType))
						{
							WriteListToXml(writer, bizo, property);
						}
						else
						{
							writer.WriteStartElement(property.GetXmlAlias());
							writer.WriteString(property.GetValue(bizo)?.ToString() ?? "");
							writer.WriteEndElement();
						}
					}
				}
				writer.WriteEndElement();
				bizo.HasChanges = false;
			}
		}

		void WriteXmlObject(XmlWriter writer, IXmlObject xmlObject)
		{
			foreach (var proprety in xmlObject.GetType().GetProperties())
			{
				if (proprety.IncludeInVXml())
				{
					writer.WriteStartElement(proprety.GetXmlAlias());
					writer.WriteString(proprety.GetValue(xmlObject)?.ToString() ?? "");
					writer.WriteEndElement();
				}
			}
		}

		void WriteListToXml(XmlWriter writer, BusinessObject bizo, System.Reflection.PropertyInfo property)
		{
			var value = property.GetValue(bizo);
			if (value is IList list)
			{
				writer.WriteStartElement(property.Name);

				foreach (var item in list)
				{
					if (item is BusinessObject childBizo)
					{
						WriteBizoXML(writer, childBizo);
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

		string GetFileNameWithExtension(BusinessObject bizo)
		{
			return DirectoryManager.GetFullDirectory(bizo.GetType()) + bizo.GetSaveNameForXML() + ".xml";
		}
	}
}
