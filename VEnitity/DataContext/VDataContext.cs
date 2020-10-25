using System.IO;
using VEntityFramework.XML;

namespace VEntityFramework.Data
{
	public class VDataContext
	{
		public bool SaveAsXML(VBusinessObject bizo)
		{
			return new VXMLWriter().Write(bizo);
		}

		public T ReadFromXML<T>(string fileName) where T:VBusinessObject
		{
			return new VXMLReader().Read<T>(fileName);
		}

		public string[] GetAllFileNames<T>() where T : VBusinessObject
		{
			return new VXMLReader().GetAllFilenames<T>();
		}

		internal void DeleteXML(VBusinessObject bizo)
		{
			if (bizo.XmlLocation != null)
			{
				var path = bizo.XmlLocation;
				if (File.Exists(path))
				{
					File.Delete(path);
				}
			}
		}
	}
}
