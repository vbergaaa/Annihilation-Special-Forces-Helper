using EnumsNET;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using VBusiness.Enemies;
using VBusiness.HelperClasses;
using VEntityFramework.Model;

namespace Tests
{
	class DifficultyTests
	{
		[Test]
		public void TestNew()
		{
			var allDiffs = Enums.GetValues<DifficultyLevel>();
			foreach (var diff in allDiffs)
			{
				var generatedDiff = DifficultyHelper.New(diff);
				var diffName = generatedDiff.GetType().Name;

				if (diff == DifficultyLevel.None)
				{
					Assert.That(diffName, Is.EqualTo("EmptyDifficulty"));
				}
				else
				{
					Assert.That(diffName, Is.EqualTo(diff.ToString()));
				}
			}
		}
	}
}
