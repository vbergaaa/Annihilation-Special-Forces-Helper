using System;
using System.Collections.Generic;
using System.Text;

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
