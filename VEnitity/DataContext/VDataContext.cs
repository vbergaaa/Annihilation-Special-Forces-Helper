using System.IO;
using VEntityFramework.XML;

namespace VEntityFramework.Data
{
	public class VDataContext
	{
		public void SaveAsXML(VBusinessObject bizo)
		{
			new VXMLWriter().Write(bizo);
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
			var path = DirectoryManager.GetFullPathWithExtension<T>(fileName);
			if (File.Exists(path))
            {
				File.Delete(path);
			}
#if DEBUG
			else
			{
				throw new DeveloperException($"filename {fileName} couldn't be found and wasn't deleted. Investigate and Fix.");
			}
#endif
		}
	}
}
