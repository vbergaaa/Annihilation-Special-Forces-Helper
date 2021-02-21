using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;
using VBusiness.Loadouts;
using VBusiness.Perks;
using VBusiness.Ranks;

namespace Tests
{
	[TestFixture]
	public class StatsTests
	{
		[TestCase(10, 0, 0, 0, 10)]
		[TestCase(0, 20, 0, 0, 20)]
		[TestCase(0, 0, 15, 0, 15)]
		[TestCase(0, 0, 0, 40, 40)]
		[TestCase(10, 20, 15, 0, 38.8)]
		[TestCase(10, 20, 15, 40, 63.28)]
		public void TestDamageReduction(short specPerks, int statsDR, short rankDr, double otherDr, double expectedDR)
		{
			var loadout = new Loadout();
			loadout.ShouldRestrict = false;
			loadout.UnitConfiguration.HasUnitSpec = true;
			var perks = (PerkCollection)loadout.Perks;

			perks.UnitSpecialization.DesiredLevel = specPerks;
			perks.DamageReduction.DesiredLevel = (short)(statsDR > 10 ? 10 : statsDR);
			perks.DamageReduction2.DesiredLevel = (short)(statsDR < 10 ? 0 : statsDR - 10);
			loadout.UnitConfiguration.UnitRank = (VEntityFramework.Model.UnitRank)rankDr;
			loadout.Stats.UpdateDamageReduction("OTHER", otherDr);

			Assert.That(loadout.Stats.DamageReductionForBinding, Is.EqualTo(expectedDR));
		}
	}
}
