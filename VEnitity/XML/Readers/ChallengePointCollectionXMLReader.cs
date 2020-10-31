using System;
using System.Collections.Generic;
using System.Reflection;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Xml;

namespace VEntityFramework.XML
{
	internal class ChallengePointCollectionXMLReader : BaseXMLReader
	{
		protected override PropertyInfo GetPropertyFromXML(Type type, XmlNode child)
		{
			return child.Name == "ChallengePoint" 
				? GetDefaultBizoProperty(type, child) 
				: base.GetPropertyFromXML(type, child);
		}
	}
}
