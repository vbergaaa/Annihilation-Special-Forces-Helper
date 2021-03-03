using EnumsNET;
using System;
using VBusiness.Difficulties;
using VEntityFramework;
using VEntityFramework.Model;

namespace VBusiness.HelperClasses
{
	public static class DifficultyHelper
	{
		public static VDifficulty New(DifficultyLevel level)
		{
			if (level == DifficultyLevel.None)
			{
				return new EmptyDifficulty();
			}
			var diffType = Type.GetType($"VBusiness.Difficulties.{level.AsString(EnumFormat.Name)}");

			if (diffType == null)
			{
				ErrorReporter.ReportDebug($"Please create a class named VBusiness.Difficulties.{level.AsString(EnumFormat.Name)}");
				return new EmptyDifficulty();
			}

			var diff = (VDifficulty)Activator.CreateInstance(diffType);
			return diff;
		}
	}
}
