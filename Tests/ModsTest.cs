using NUnit.Framework;
using System.Collections.Generic;
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
			foreach (var mod in loadout.Mods.AllMods)
			{
				mod.CurrentLevel = mod.MaxValue;
			}
			((ModsCollection)loadout.Mods).PreventRoundingModscoreForTest = true;
			Assert.That(loadout.Mods.TotalModScore, Is.EqualTo(expectedScore));
		}

		[TestCase(100, 0, 0, 100)]
		[TestCase(100, 0, 1, 94)]
		[TestCase(100, 0, 10, 40)]
		[TestCase(1000000, 20000, 0, 2000000)]
		[TestCase(1000000, 20000, 10, 800000)]
		[TestCase(2099326, 23938, 10, 1843040)]
		[TestCase(2099326, 23938, 5, 3225320)]
		[TestCase(2099326, 23938, 1, 4331144)]
		[TestCase(2099326, 23938, 0, 4607631)]
		public void Taxes(int rp, int modScore, short taxes, int expected)
		{
			var profile = Profile.GetProfile();
			var oldPP = profile.PerkPoints;

			using (profile.TemporarilyModifyProfile(rp, modScore))
			{
				var loadout = TestHelper.GetEmptyLoadout();
				loadout.Mods.Taxes.CurrentLevel = taxes;
				Assert.That(loadout.RemainingPerkPoints, Is.EqualTo(expected));
			}

			Assert.That(profile.PerkPoints, Is.EqualTo(oldPP));
		}

		[Test]
		[TestCaseSource("Mods")]
		public void TestTotalModScore(ModScoreTest testValues)
		{
			var loadout = TestHelper.GetEmptyLoadout();
			loadout.UnitConfiguration.DifficultyLevel = testValues.Diff;
			PopulateFromTestCase(loadout.Mods, testValues);
			Assert.That(loadout.Mods.TotalModScore, Is.EqualTo(testValues.Expected));
		}

		void PopulateFromTestCase(VModsCollection mods, ModScoreTest testValues)
		{
			mods.Damage.CurrentLevel = (short)testValues.Damage;
			mods.Health.CurrentLevel = (short)testValues.Health;
			mods.Armor.CurrentLevel = (short)testValues.Armor;
			mods.SelfMitigation.CurrentLevel = (short)testValues.Sm;
			mods.Speed.CurrentLevel = (short)testValues.Speed;
			mods.DamageReduction.CurrentLevel = (short)testValues.Dr;
			mods.Difficulty.CurrentLevel = (short)testValues.Difficulty;
			mods.Potency.CurrentLevel = (short)testValues.Potency;
			mods.Taxes.CurrentLevel = (short)testValues.Taxes;
			mods.Rank.CurrentLevel = (short)testValues.Rank;
			mods.Tier.CurrentLevel = (short)testValues.Tier;
			mods.Scarcity.CurrentLevel = (short)testValues.Scarcity;
			mods.Bountyless.CurrentLevel = (short)testValues.Bountyless;
			mods.Unwell.CurrentLevel = (short)testValues.Unwell;
			mods.RankReversion.CurrentLevel = (short)testValues.Rr;
			mods.BossPower.CurrentLevel = (short)testValues.Bp;
			mods.CriticalMiscalculation.CurrentLevel = (short)testValues.Cm;
			mods.GlassCannon.CurrentLevel = (short)testValues.Gc;
			mods.Supply.CurrentLevel = (short)testValues.Supply;
			mods.VolatileDead.CurrentLevel = (short)testValues.Vd;
		}

		public static IEnumerable<ModScoreTest> Mods
		{
			get
			{
				yield return new ModScoreTest(diffLevel: DifficultyLevel.VeryEasy, damage: 10, health: 10, armor: 10, sm: 10, speed: 10, dr: 10, diff: 10, potency: 10, taxes: 10, rank: 10, tier: 10, scarcity: 10, bountyless: 10, unwell: 10, rr: 10, bp: 10, cm: 10, gc: 10, supply: 10, vd: 10, expected: 2000);
				yield return new ModScoreTest(diffLevel: DifficultyLevel.Hard, damage: 10, health: 10, armor: 10, sm: 10, speed: 10, dr: 10, diff: 10, potency: 10, taxes: 10, rank: 10, tier: 10, scarcity: 10, bountyless: 10, unwell: 10, rr: 10, bp: 10, cm: 10, gc: 10, supply: 10, vd: 10, expected: 2000);
				yield return new ModScoreTest(diffLevel: DifficultyLevel.Nightmare, damage: 10, health: 10, armor: 10, sm: 10, speed: 10, dr: 10, diff: 10, potency: 10, taxes: 10, rank: 10, tier: 10, scarcity: 10, bountyless: 10, unwell: 10, rr: 10, bp: 10, cm: 10, gc: 10, supply: 10, vd: 10, expected: 2000);
				yield return new ModScoreTest(diffLevel: DifficultyLevel.Impossible, damage: 10, health: 0, armor: 10, sm: 10, speed: 10, dr: 0, diff: 10, potency: 10, taxes: 10, rank: 10, tier: 10, scarcity: 10, bountyless: 10, unwell: 0, rr: 10, bp: 10, cm: 10, gc: 10, supply: 10, vd: 0, expected: 1355);
				yield return new ModScoreTest(diffLevel: DifficultyLevel.Impossible, damage: 10, health: 0, armor: 10, sm: 10, speed: 10, dr: 0, diff: 10, potency: 10, taxes: 10, rank: 10, tier: 0, scarcity: 10, bountyless: 10, unwell: 0, rr: 10, bp: 10, cm: 10, gc: 10, supply: 10, vd: 0, expected: 1355);
			}
		}

		#region Implementation

		public class ModScoreTest
		{
			public ModScoreTest(DifficultyLevel diffLevel, int damage, int health, int armor, int sm, int speed, int dr, int diff, int potency, int taxes, int rank, int tier, int scarcity, int bountyless, int unwell, int rr, int bp, int cm, int gc, int supply, int vd, int expected)
			{
				Diff = diffLevel;
				Damage = damage;
				Health = health;
				Armor = armor;
				Sm = sm;
				Speed = speed;
				Dr = dr;
				Difficulty = diff;
				Potency = potency;
				Taxes = taxes;
				Rank = rank;
				Tier = tier;
				Scarcity = scarcity;
				Bountyless = bountyless;
				Unwell = unwell;
				Rr = rr;
				Bp = bp;
				Cm = cm;
				Gc = gc;
				Supply = supply;
				Vd = vd;
				Expected = expected;
			}

			public DifficultyLevel Diff { get; }
			public int Damage { get; }
			public int Health { get; }
			public int Armor { get; }
			public int Sm { get; }
			public int Speed { get; }
			public int Dr { get; }
			public int Difficulty { get; }
			public int Potency { get; }
			public int Taxes { get; }
			public int Rank { get; }
			public int Tier { get; }
			public int Scarcity { get; }
			public int Bountyless { get; }
			public int Unwell { get; }
			public int Rr { get; }
			public int Bp { get; }
			public int Cm { get; }
			public int Gc { get; }
			public int Supply { get; }
			public int Vd { get; }
			public int Expected { get; }
		}

		#endregion
	}
}
