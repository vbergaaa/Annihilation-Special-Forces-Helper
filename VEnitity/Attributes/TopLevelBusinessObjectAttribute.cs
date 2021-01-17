using System;

namespace VEntityFramework.Attributes
{
	public class TopLevelBusinessObjectAttribute : Attribute
	{
		public TopLevelBusinessObjectAttribute(string path)
		{
			PathHint = path;
		}
		public string PathHint { get; set; }
	}
}
