using System;

namespace VEntityFramework.Data
{
	public class VXMLAttribute : Attribute
	{
		public VXMLAttribute(bool include = true, string alias = null)
		{
			ShouldInclude = include;
			Alias = alias;
		}
		public bool ShouldInclude { get; set; }
		public string Alias { get; set; }
	}
}
