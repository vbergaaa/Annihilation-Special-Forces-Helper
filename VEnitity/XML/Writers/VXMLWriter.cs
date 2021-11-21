using System;
using System.Collections;
using System.IO;
using System.Xml;
using VEntityFramework.Data;
using VEntityFramework.Model;

namespace VEntityFramework.XML
{
	class VXMLWriter
	{
		int stackOverflowDetector;

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
			stackOverflowDetector += 1;
			if (bizo != null)
			{
				if (stackOverflowDetector >= 20)
				{
					GenerateStackOverflowReport(bizo.GetType().FullName);
				}
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
			stackOverflowDetector -= 1;
		}

		void GenerateStackOverflowReport(string bizoName)
		{
			switch (stackOverflowDetector)
			{
				case 20:
					bizo1ForStackOverflowReport = bizoName;
					break;
				case 21:
					bizo2ForStackOverflowReport = bizoName;
					break;
				case 22:
					bizo3ForStackOverflowReport = bizoName;
					break;
				case 23:
					bizo4ForStackOverflowReport = bizoName;
					break;
				case 24:
					bizo5ForStackOverflowReport = bizoName;
					break;
				default:
					throw new StackOverflowException(GetStackOverflowMessage());
			}
		}

		string GetStackOverflowMessage()
		{
			return $@"A Stack overflow occured when attempting to write a file to xml. The recursion pattern is:
{bizo1ForStackOverflowReport} > {bizo2ForStackOverflowReport} > {bizo3ForStackOverflowReport} > {bizo4ForStackOverflowReport} > {bizo5ForStackOverflowReport};";
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

		string bizo1ForStackOverflowReport;
		string bizo2ForStackOverflowReport;
		string bizo3ForStackOverflowReport;
		string bizo4ForStackOverflowReport;
		string bizo5ForStackOverflowReport;
	}
}
