using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using VEntityFramework;
using VEntityFramework.Model;

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

		public string[] GetAllLoadoutNames()
		{
			return new VXMLReader().GetAllLoadoutNames();
		}

		public string[] GetAllSoulNames()
		{
			return new VXMLReader().GetAllSoulNames();
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
