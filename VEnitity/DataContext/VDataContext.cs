using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using VEntityFramework;

namespace VEntityFramework.Data
{
	public class VDataContext
	{
		public bool SaveAsXML(VBusinessObject bizo)
		{
			return SaveAsXML(bizo, null);
		}

		public bool SaveAsXML(VBusinessObject bizo, string existingName)
		{
			return new VXMLWriter().Write(bizo, existingName);
		}

		public T ReadFromXML<T>(string fileName) where T:VBusinessObject
		{
			return new VXMLReader().Read<T>(fileName);
		}

		public string[] GetAllLoadoutNames()
		{
			return new VXMLReader().GetAllLoadoutNames();
		}

		internal void DeleteXML(VBusinessObject vBusinessObject, string getExistingXMLFileName)
		{
			if (getExistingXMLFileName != null)
			{
				var path = new VXMLReader().GetFullPath(getExistingXMLFileName) + ".xml";
				if (File.Exists(path))
				{
					File.Delete(path);
				}
			}
		}
	}
}
