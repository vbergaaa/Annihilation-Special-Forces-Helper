using System;

namespace VEntityFramework.Data
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
