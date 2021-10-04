using System;

namespace VEntityFramework.HelperClasses
{
	public static class VersionHelper
	{
		public static DateTime GetVersionBuildDate()
		{
			var version = System.Reflection.Assembly.GetExecutingAssembly().GetName().Version;
			var buildDate = new DateTime(2000, 1, 1)
				.AddDays(version.Build)
				.AddSeconds(version.Revision * 2);

			return buildDate;
		}
	}
}
