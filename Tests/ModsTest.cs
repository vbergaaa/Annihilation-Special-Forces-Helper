using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;
using VBusiness.Mods;
using VBusiness.Profile;
using VEntityFramework.Model;

namespace Tests
{
	public class ModsTest
	{
		[TestCase(2008, DifficultyLevel.Nightmare)]
		[TestCase(2010, DifficultyLevel.Hard)]
		[TestCase(2013, DifficultyLevel.VeryEasy)]
		public void MaxModScore(int expectedScore, DifficultyLevel diff)
		{
			var loadout = TestHelper.GetTestLoadout();
			loadout.UnitConfiguration.DifficultyLevel = diff;
			foreach(var mod in loadout.Mods.AllMods)
			{
				mod.CurrentLevel = mod.MaxValue;
			}
			((ModsCollection)loadout.Mods).PreventRoundingModscoreForTest = true;
			Assert.That(loadout.Mods.TotalModScore, Is.EqualTo(expectedScore));
		}
	}
}
