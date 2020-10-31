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

		public void Delete<T>(string fileName) where T : VBusinessObject
		{
			var path = new VXMLReader().GetFullPathWithExtension<T>(fileName);
			if (File.Exists(path))
            {
				File.Delete(path);
            }
            else
			{
#if DEBUG
				throw new DeveloperException($"filename {fileName} couldn't be found and wasn't deleted. Please address");
#endif
			}

		}
	}
}
