using System;

namespace VEntityFramework.Attributes
{
	public class VXMLParentAttribute : Attribute
	{
		public VXMLParentAttribute(string parent)
		{

		}

		public string ParentPropertyName { get; set; }
	}
}
