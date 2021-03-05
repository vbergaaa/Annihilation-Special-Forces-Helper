using EnumsNET;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;
using VBusiness.Loadouts;
using VEntityFramework.Model;

namespace Tests
{
	public class UnitTests
	{
		[Test]
		public void TestAllUnitProperties()
		{
			var loadout = (VLoadout)new Loadout();
			foreach (var unitType in Enums.GetValues<UnitType>())
			{
				VUnit unit = null;

				Assert.That(() => unit = VUnit.New(unitType, loadout), Throws.Nothing, $"Cannot create a {unitType} unit");
				
				Assert.That(() => unit.Type, Throws.Nothing, $"{unitType}.Type");
				Assert.That(() => unit.BaseAttack, Throws.Nothing, $"{unitType}.BaseAttack");
				Assert.That(() => unit.BaseAttackSpeed, Throws.Nothing, $"{unitType}.BaseAttackSpeed");
				Assert.That(() => unit.BaseHealth, Throws.Nothing, $"{unitType}.BaseHealth");
				Assert.That(() => unit.BaseHealthArmor, Throws.Nothing, $"{unitType}.BaseHealthArmor");
				Assert.That(() => unit.BaseShields, Throws.Nothing, $"{unitType}.BaseShields");
				Assert.That(() => unit.BaseShieldArmor, Throws.Nothing, $"{unitType}.BaseShieldArmor");
				Assert.That(() => unit.BaseHealthRegen, Throws.Nothing, $"{unitType}.BaseHealthRegen");
				Assert.That(() => unit.BaseShieldRegen, Throws.Nothing, $"{unitType}.BaseShieldRegen");
				Assert.That(() => unit.BaseAttackCount, Throws.Nothing, $"{unitType}.BaseAttackCount");
				Assert.That(() => unit.GetType().GetProperty("HealthIncrement", BindingFlags.NonPublic | BindingFlags.Instance).GetValue(unit), Throws.Nothing, $"{unitType}.HealthIncrement");
				Assert.That(() => unit.GetType().GetProperty("HealthRegenIncrement", BindingFlags.NonPublic | BindingFlags.Instance).GetValue(unit), Throws.Nothing, $"{unitType}.HealthRegenIncrement");
				Assert.That(() => unit.GetType().GetProperty("HealthArmorIncrement", BindingFlags.NonPublic | BindingFlags.Instance).GetValue(unit), Throws.Nothing, $"{unitType}.HealthArmorIncrement");
				Assert.That(() => unit.GetType().GetProperty("ShieldIncrement", BindingFlags.NonPublic | BindingFlags.Instance).GetValue(unit), Throws.Nothing, $"{unitType}.ShieldIncrement");
				Assert.That(() => unit.GetType().GetProperty("ShieldRegenIncrement", BindingFlags.NonPublic | BindingFlags.Instance).GetValue(unit), Throws.Nothing, $"{unitType}.ShieldRegenIncrement");
				Assert.That(() => unit.GetType().GetProperty("ShieldArmorIncrement", BindingFlags.NonPublic | BindingFlags.Instance).GetValue(unit), Throws.Nothing, $"{unitType}.ShieldArmorIncrement");
				Assert.That(() => unit.GetType().GetProperty("AttackIncrement", BindingFlags.NonPublic | BindingFlags.Instance).GetValue(unit), Throws.Nothing, $"{unitType}.AttackIncrement");
			}
		}
	}
}
