using EnumsNET;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;
using VBusiness.Enemies;
using VEntityFramework.Model;

namespace Tests
{
	public class EnemyTests
	{
		[Test]
		public void TestCreateNewEnemy()
		{
			//var enemyTypes = Enums.GetValues<EnemyType>();
			var enemyTypes = new List<EnemyType>()
			{
				EnemyType.Zergling,
				EnemyType.Roach,
				EnemyType.Hydralisk,
				EnemyType.Pygalisk,
				EnemyType.PrimalHydralisk
			};

			foreach (var type in enemyTypes)
			{
				Assert.That(() => EnemyUnit.New(type), Throws.Nothing);
			}
		}
	}
}
