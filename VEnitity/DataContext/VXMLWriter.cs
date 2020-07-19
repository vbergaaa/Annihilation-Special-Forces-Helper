using System;
using System.IO;
using System.Xml;
using VEntityFramework.Model;

namespace VEntityFramework.Data
{
	class VXMLWriter
	{
		internal bool Write(VBusinessObject bizo, string existingName)
		{
			var directory = RenameFileIfNeccessary(bizo, existingName);

			using (var stream = File.Create(directory))
			using (var writer = GetXmlWriter(stream))
			{
				WriteXML(writer, bizo);
			}

			return true;
		}

		string RenameFileIfNeccessary(VBusinessObject bizo, string existingName)
		{
			var newNameWithPath = GetFileNameWithExtension(bizo);

			if (existingName != null && existingName != GetXmlNameFromBizo(bizo))
			{
				var oldNameWithPath = GetOldFilePathWithName(existingName);
				File.Move(oldNameWithPath, newNameWithPath);
			}

			return newNameWithPath;
		}

		string GetOldFilePathWithName(string existingName)
		{
			return GetFilePath() + existingName + ".xml";
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
			}
		}

		string GetFileNameWithExtension(VBusinessObject bizo)
		{
			return GetFilePath() + GetXmlNameFromBizo(bizo) + ".xml";
		}

		string GetXmlNameFromBizo(VBusinessObject bizo)
		{
			if (bizo is VLoadout loadout)
			{
				loadout.Name = loadout.Name == "" || loadout.Name == null 
					? $"Loadout{loadout.Slot}" 
					: loadout.Name;
				return $"{loadout.Slot}-{loadout.Name}";
			}
			else
			{
				throw new DeveloperException("what name do you want this bizo to save as?");
			}
		}

		string GetFilePath()
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
