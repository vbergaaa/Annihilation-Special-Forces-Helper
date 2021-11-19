using EnumsNET;
using NUnit.Framework;
using System.Collections.Generic;
using System.Reflection;
using VBusiness.Loadouts;
using VEntityFramework.Model;
using VUserInterface;

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
				Assert.That<VUnit>(() => unit = VUnit.New(unitType, loadout), Throws.Nothing, $"Cannot create a {unitType} unit");

				Assert.That<object>(() => unit.UnitData.GetType().GetProperty("BaseHealth", BindingFlags.Public | BindingFlags.Instance).GetValue(unit.UnitData), Throws.Nothing, $"{unitType}.BaseHealth");
				Assert.That<object>(() => unit.UnitData.GetType().GetProperty("BaseHealthArmor", BindingFlags.Public | BindingFlags.Instance).GetValue(unit.UnitData), Throws.Nothing, $"{unitType}.BaseHealthArmor");
				//Assert.That<object>(() => unit.UnitData.GetType().GetProperty("BaseHealthRegen", BindingFlags.Public | BindingFlags.Instance).GetValue(unit.UnitData), Throws.Nothing, $"{unitType}.BaseHealthRegen");
				Assert.That<object>(() => unit.UnitData.GetType().GetProperty("BaseShields", BindingFlags.Public | BindingFlags.Instance).GetValue(unit.UnitData), Throws.Nothing, $"{unitType}.BaseShields");
				Assert.That<object>(() => unit.UnitData.GetType().GetProperty("BaseShieldsArmor", BindingFlags.Public | BindingFlags.Instance).GetValue(unit.UnitData), Throws.Nothing, $"{unitType}.BaseShieldsArmor");
				//Assert.That<object>(() => unit.UnitData.GetType().GetProperty("BaseShieldsRegen", BindingFlags.Public | BindingFlags.Instance).GetValue(unit.UnitData), Throws.Nothing, $"{unitType}.BaseShieldsRegen");
				Assert.That<object>(() => unit.UnitData.GetType().GetProperty("HealthIncrement", BindingFlags.Public | BindingFlags.Instance).GetValue(unit.UnitData), Throws.Nothing, $"{unitType}.HealthIncrement");
				//Assert.That<object>(() => unit.UnitData.GetType().GetProperty("HealthRegenIncrement", BindingFlags.Public | BindingFlags.Instance).GetValue(unit.UnitData), Throws.Nothing, $"{unitType}.HealthRegenIncrement");
				Assert.That<object>(() => unit.UnitData.GetType().GetProperty("HealthArmorIncrement", BindingFlags.Public | BindingFlags.Instance).GetValue(unit.UnitData), Throws.Nothing, $"{unitType}.HealthArmorIncrement");
				Assert.That<object>(() => unit.UnitData.GetType().GetProperty("ShieldIncrement", BindingFlags.Public | BindingFlags.Instance).GetValue(unit.UnitData), Throws.Nothing, $"{unitType}.ShieldIncrement");
				//Assert.That<object>(() => unit.UnitData.GetType().GetProperty("ShieldRegenIncrement", BindingFlags.Public | BindingFlags.Instance).GetValue(unit.UnitData), Throws.Nothing, $"{unitType}.ShieldRegenIncrement");
				Assert.That<object>(() => unit.UnitData.GetType().GetProperty("ShieldArmorIncrement", BindingFlags.Public | BindingFlags.Instance).GetValue(unit.UnitData), Throws.Nothing, $"{unitType}.ShieldArmorIncrement");
				Assert.That<object>(() => unit.UnitData.GetType().GetProperty("Type", BindingFlags.Public | BindingFlags.Instance).GetValue(unit.UnitData), Throws.Nothing, $"{unitType}.Type");
			}
		}

		[Test]
		public void TestUnitSpec()
		{
			var validSpecTypes = VUnit.ValidSpecTypes();
			var loadout = (VLoadout)new Loadout();

			foreach (var unitType in Enums.GetValues<UnitType>())
			{
				var unit = VUnit.New(unitType, loadout);

				if (speclessUnitTypes().Contains(unitType))
				{
					Assert.That<object>(() => unit.UnitData.SpecTypes, Has.Length.EqualTo(0), $"Unit {unitType} should have no spec types");
				}
				else
				{
					Assert.That<object>(() => unit.UnitData.SpecTypes, Has.Length.GreaterThan(0), $"Unit {unitType} should have at least 1 spec type");
				}

				foreach (var specType in unit.UnitData.SpecTypes)
				{
					Assert.That<object>(() => validSpecTypes, Has.Member(specType), $"unit {unitType} has a spec type of {specType} which is invalid");
				}
			}

			static List<UnitType> speclessUnitTypes() =>
				new()
				{
					UnitType.None,
					UnitType.Probe,
					UnitType.DarkProbe,
					UnitType.EvolutionProbe,
					UnitType.Artifact
				};
		}

		[Test]
		public void TestUnitTypeIsInUI()
		{
			var control = new UnitControl();
			var unitTypes = Enums.GetValues<UnitType>();
			foreach (var unitType in unitTypes)
			{
				Assert.That<object>(() => control.UnitsTypesList, Contains.Item(unitType));
			}
			control.Dispose();
		}
	}
}
