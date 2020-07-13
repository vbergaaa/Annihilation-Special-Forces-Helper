using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using VEntityFramework;

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
	}
}
