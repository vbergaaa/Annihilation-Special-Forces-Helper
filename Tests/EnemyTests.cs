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
			var enemyTypes = Enums.GetValues<EnemyType>();

			foreach (var type in enemyTypes)
			{
				if (type != EnemyType.None)
				{
					Assert.That(() => EnemyUnit.New(type), Throws.Nothing);
				}
			}
		}

		[Test]
		public void TestCanAttack()
		{
			var enemyTypes = Enums.GetValues<EnemyType>();

			foreach (var type in enemyTypes)
			{
				if (type != EnemyType.None)
				{
					var enemy = EnemyUnit.New(type);
					if (type.CanAttack())
					{
						Assert.That(enemy.Attack, Is.GreaterThan(0), type.ToString());
					}
					else
					{
						Assert.That(enemy.Attack, Is.EqualTo(0), type.ToString());
					}
					Assert.That(() => enemy.KillBounty, Throws.Nothing);
					Assert.That(() => enemy.MineralBounty, Throws.Nothing);
				}
			}
		}

		[Test]
		public void TestPropertiesDoNotThrow()
		{
			var enemyTypes = Enums.GetValues<EnemyType>();

			foreach (var type in enemyTypes)
			{
				if (type != EnemyType.None)
				{
					var enemy = EnemyUnit.New(type);
					Assert.That(() => enemy.KillBounty, Throws.Nothing);
					Assert.That(() => enemy.MineralBounty, Throws.Nothing);
				}
			}
		}
	}
}
