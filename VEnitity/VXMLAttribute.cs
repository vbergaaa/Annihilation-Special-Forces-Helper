using System;
using System.Collections.Generic;
using System.Text;

namespace VModel
{
	public class VXMLAttribute : Attribute
	{
		public VXMLAttribute(bool include)
		{
			ShouldInclude = include;
		}
		public bool ShouldInclude { get; set; }
	}
}
