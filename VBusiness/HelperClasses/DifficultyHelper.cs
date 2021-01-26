using EnumsNET;
using System;
using VBusiness.Difficulties;
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
#if DEBUG
				throw new Exception($"Please create a class named VBusiness.Difficulties.{level.AsString(EnumFormat.Name)}");
#else
				return new EmptyDifficulty();
#endif
			}

			var diff = (VDifficulty)Activator.CreateInstance(diffType);
			return diff;
		}
	}
}
