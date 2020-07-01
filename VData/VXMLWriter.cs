using System;
using System.Collections.Generic;
using System.IO;
using System.Xml;
using VModel;

namespace VData
{
	public class VXMLWriter
	{
		public bool Write(VBusinessObject bizo)
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
			return XmlWriter.Create(stream, xmlSettings);
		}

		private void WriteXML(XmlWriter writer, VBusinessObject bizo)
		{
		}

		string GetFileNameWithExtension(string path)
		{
			var incrementor = 1;
			var completePath = $"{path}Loadout{incrementor}.xml";
			while (Directory.Exists(completePath))
			{
				incrementor++;
			}
			return $"Loadout{incrementor}.xml";
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
