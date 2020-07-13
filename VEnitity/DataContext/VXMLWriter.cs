using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Xml;
using VEntityFramework;

namespace VEntityFramework.Data
{
	class VXMLWriter
	{
		internal bool Write(VBusinessObject bizo)
		{
			var succeeded = false;
			try
			{
				var path = GetFilePath();
				var name = GetFileNameWithExtension(path);
				var directory = path + name;

				using (var stream = File.Create(directory))
				using (var writer = GetXmlWriter(stream))
				{
					WriteXML(writer, bizo);
				}
				succeeded = true;
			}
			catch
			{
				throw new IOException("Something went wrong writing the xml.");
			}

			return succeeded;
		}

		private XmlWriter GetXmlWriter(Stream stream)
		{
			var xmlSettings = new XmlWriterSettings();
			xmlSettings.Indent = true;
			xmlSettings.CloseOutput = true;
			return XmlWriter.Create(stream, xmlSettings);
		}

		private void WriteXML(XmlWriter writer, VBusinessObject bizo)
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
							writer.WriteString(property.GetValue(bizo).ToString());
							writer.WriteEndElement();
						}
					}
				}
				writer.WriteEndElement();
			}
		}

		string GetFileNameWithExtension(string path)
		{
			return "Loadout1.xml";
		}

		private string GetFilePath()
		{
			var rootDirectory = Directory.GetCurrentDirectory();
			var desiredPath = rootDirectory + "/Loadouts/";

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
