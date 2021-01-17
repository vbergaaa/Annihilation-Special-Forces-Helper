using System;
using System.Reflection;
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
