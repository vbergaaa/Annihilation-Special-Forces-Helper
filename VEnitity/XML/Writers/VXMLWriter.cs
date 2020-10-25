using System.IO;
using System.Xml;
using VEntityFramework.Data;

namespace VEntityFramework.XML
{
	class VXMLWriter
	{
		internal bool Write(VBusinessObject bizo)
		{
			var directory = RenameFileIfNeccessary(bizo);

			using (var stream = File.Create(directory))
			using (var writer = GetXmlWriter(stream))
			{
				WriteXML(writer, bizo);
			}
			bizo.XmlLocation = directory;

			return true;
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

		string GetFileNameWithExtension(VBusinessObject bizo)
		{
			return GetFilePath(bizo.BizoName) + bizo.GetSaveNameForXML() + ".xml";
		}

		string GetFilePath(string bizoName)
		{
			var rootDirectory = Directory.GetCurrentDirectory();
			var desiredPath = rootDirectory + $"/{bizoName}s/";

			if (!Directory.Exists(desiredPath))
			{
				try
				{
					Directory.CreateDirectory(desiredPath);
				}
				catch
				{
					throw new IOException("An error occured while creating the directory");
				}
			}

			return desiredPath;
		}
	}
}
