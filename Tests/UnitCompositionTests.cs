using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using VBusiness.Difficulties;
using VBusiness.HelperClasses;
using VEntityFramework.Model;

namespace Tests
{
	public class UnitCompositionTests
	{
		[Test]
		public void TestGetUnitCompositions()
		{
			// Ramone, 1
			// Queens, 12 - 8(hatch), 4(ram)
			// Abberation, 105 - 57(19*3 spawns), 48(queens)
			// InfestedTerran, 1090 - 120(40*3 spawns), 470(spines), 80(evo chamber), 420(abberation)
			// Zergling, 198 - 108(36*3 spawns), 80(spawningpool), 10(spore)

			// Buildings
			// SporeCrawler, 1
			// SpineCrawler, 47

			var totalUnits = 1454.0;
			var difficulty = new VeryEasy();
			var expectedComp = new List<(EnemyType, double)>
			{
				(EnemyType.InfestedTerran, 1090 / totalUnits),
				(EnemyType.Zergling, 198 / totalUnits),
				(EnemyType.Abberation, 105 / totalUnits),
				(EnemyType.SergeantRamone, 1 / totalUnits),
				(EnemyType.Queen, 12 / totalUnits),

				(EnemyType.SporeCrawler, 1 / totalUnits),
				(EnemyType.SpineCrawler, 47 / totalUnits),
			};
			var actual = UnitCompositionGenerator.GetComposition(difficulty, CompositionOptions.AttackingUnitsOnly).ToList();

			AssertCompositionsMatch(expectedComp, actual);
		}

		static void AssertCompositionsMatch(IList<(EnemyType, double)> expectedComp, IList<(EnemyType, double)> actual)
		{
			Assert.That(actual, Has.Count.EqualTo(expectedComp.Count));
			for (var i = 0; i < expectedComp.Count; i++)
			{
				var unitPair = expectedComp[i];
				var actualMatch = actual.FirstOrDefault(u => u.Item1 == unitPair.Item1);
				Assert.That(actualMatch.Item2, Is.EqualTo(unitPair.Item2).Within(0.001));
			}
		}
	}
}
