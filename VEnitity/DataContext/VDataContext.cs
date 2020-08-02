﻿using System;
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

		public string[] GetAllSoulNames()
		{
			return new VXMLReader().GetAllSoulNames();
		}

		internal void DeleteXML(VBusinessObject vBusinessObject, string getExistingXMLFileName)
		{
			if (getExistingXMLFileName != null)
			{
				var path = new VXMLReader().GetFullPath(vBusinessObject.GetType(), getExistingXMLFileName) + ".xml";
				if (File.Exists(path))
				{
					File.Delete(path);
				}
			}
		}
	}
}
