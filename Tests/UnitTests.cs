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

				Assert.That(() => unit = VUnit.New(unitType, loadout), Throws.Nothing, $"Cannot create a {unitType} unit");

				var unitDataType = unit.UnitData.GetType();
				var properties = unitDataType.GetProperties(BindingFlags.NonPublic | BindingFlags.Instance);

				Assert.That(() => unit.UnitData.GetType().GetProperty("VEntityFramework.Model.IUnitData.BaseHealth", BindingFlags.NonPublic | BindingFlags.Instance).GetValue(unit.UnitData), Throws.Nothing, $"{unitType}.BaseHealth. If this fails when it shouldn't it might be because of implicit/explicit interface implementation");
				Assert.That(() => unit.UnitData.GetType().GetProperty("VEntityFramework.Model.IUnitData.BaseHealthArmor", BindingFlags.NonPublic | BindingFlags.Instance).GetValue(unit.UnitData), Throws.Nothing, $"{unitType}.BaseHealthArmor");
				Assert.That(() => unit.UnitData.GetType().GetProperty("VEntityFramework.Model.IUnitData.BaseHealthRegen", BindingFlags.NonPublic | BindingFlags.Instance).GetValue(unit.UnitData), Throws.Nothing, $"{unitType}.BaseHealthRegen");
				Assert.That(() => unit.UnitData.GetType().GetProperty("VEntityFramework.Model.IUnitData.BaseShields", BindingFlags.NonPublic | BindingFlags.Instance).GetValue(unit.UnitData), Throws.Nothing, $"{unitType}.BaseShields");
				Assert.That(() => unit.UnitData.GetType().GetProperty("VEntityFramework.Model.IUnitData.BaseShieldsArmor", BindingFlags.NonPublic | BindingFlags.Instance).GetValue(unit.UnitData), Throws.Nothing, $"{unitType}.BaseShieldsArmor");
				Assert.That(() => unit.UnitData.GetType().GetProperty("VEntityFramework.Model.IUnitData.BaseShieldsRegen", BindingFlags.NonPublic | BindingFlags.Instance).GetValue(unit.UnitData), Throws.Nothing, $"{unitType}.BaseShieldsRegen");
				Assert.That(() => unit.UnitData.GetType().GetProperty("VEntityFramework.Model.IUnitData.HealthIncrement", BindingFlags.NonPublic | BindingFlags.Instance).GetValue(unit.UnitData), Throws.Nothing, $"{unitType}.HealthIncrement");
				Assert.That(() => unit.UnitData.GetType().GetProperty("VEntityFramework.Model.IUnitData.HealthRegenIncrement", BindingFlags.NonPublic | BindingFlags.Instance).GetValue(unit.UnitData), Throws.Nothing, $"{unitType}.HealthRegenIncrement");
				Assert.That(() => unit.UnitData.GetType().GetProperty("VEntityFramework.Model.IUnitData.HealthArmorIncrement", BindingFlags.NonPublic | BindingFlags.Instance).GetValue(unit.UnitData), Throws.Nothing, $"{unitType}.HealthArmorIncrement");
				Assert.That(() => unit.UnitData.GetType().GetProperty("VEntityFramework.Model.IUnitData.ShieldIncrement", BindingFlags.NonPublic | BindingFlags.Instance).GetValue(unit.UnitData), Throws.Nothing, $"{unitType}.ShieldIncrement");
				Assert.That(() => unit.UnitData.GetType().GetProperty("VEntityFramework.Model.IUnitData.ShieldRegenIncrement", BindingFlags.NonPublic | BindingFlags.Instance).GetValue(unit.UnitData), Throws.Nothing, $"{unitType}.ShieldRegenIncrement");
				Assert.That(() => unit.UnitData.GetType().GetProperty("VEntityFramework.Model.IUnitData.ShieldArmorIncrement", BindingFlags.NonPublic | BindingFlags.Instance).GetValue(unit.UnitData), Throws.Nothing, $"{unitType}.ShieldArmorIncrement");
				Assert.That(() => unit.UnitData.GetType().GetProperty("Type", BindingFlags.Public | BindingFlags.Instance).GetValue(unit.UnitData), Throws.Nothing, $"{unitType}.Type - This one can't be implicit.. must have been drunk when I wrote this");
			}
		}

		[Test]
		public void TestUnitSpec()
		{
			var validSpecTypes = VUnit.ValidSpecTypes();
			var loadout = (VLoadout)new Loadout();

			foreach (var unitType in Enums.GetValues<UnitType>())
			{
				VUnit unit = VUnit.New(unitType, loadout);

				if (speclessUnitTypes().Contains(unitType))
				{
					Assert.That(unit.UnitData.SpecTypes, Has.Length.EqualTo(0), $"Unit {unitType} should have no spec types");
				}
				else
				{
					Assert.That(unit.UnitData.SpecTypes, Has.Length.GreaterThan(0), $"Unit {unitType} should have at least 1 spec type");
				}

				foreach (var specType in unit.UnitData.SpecTypes)
				{
					Assert.That(validSpecTypes, Has.Member(specType), $"unit {unitType} has a spec type of {specType} which is invalid");
				}
			}

			List<UnitType> speclessUnitTypes() => 
				new List<UnitType>() 
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
				Assert.That(control.UnitsTypesList, Contains.Item(unitType));
			}
			control.Dispose();
		}
	}
}
