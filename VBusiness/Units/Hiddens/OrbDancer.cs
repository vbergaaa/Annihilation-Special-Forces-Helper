using System;
using System.Collections.Generic;
using VBusiness.Weapons;
using VEntityFramework;
using VEntityFramework.Model;

namespace VBusiness.Units
{
	public class OrbDancer : CommonUnitData
	{
		public override UnitType Type => UnitType.OrbDancer;

		public override double BaseHealth => 500;

		public override double BaseHealthArmor => 8;

		public override double BaseHealthRegen => 9;

		public override double BaseShields => 750;

		public override double BaseShieldsArmor => 8;

		public override double BaseShieldsRegen => 15;

		public override double HealthIncrement => 11;

		public override double HealthRegenIncrement => 1.2;

		public override double HealthArmorIncrement => 0.9;

		public override double ShieldIncrement => 18;

		public override double ShieldRegenIncrement => 1.4;

		public override double ShieldArmorIncrement => 0.9;

		public override UnitType[] SpecTypes => new[] { UnitType.DarkShadow, UnitType.WarpLord, UnitType.ShieldBattery };

		public override UnitType BasicType => UnitType.DarkShadow;

		public override IEnumerable<UnitRecepePiece> Recepe
		{
			get
			{
				yield return new UnitRecepePiece(UnitType.StonePrisoner, 5, UnitRankType.SSS, 1);
				yield return new UnitRecepePiece(UnitType.DarkShadow, 5, UnitRankType.SS, 4);
			}
		}

		public override Evolution Evolution => Evolution.DNA2;

		public override IEnumerable<IWeaponData> Weapons
		{
			get
			{
				yield return new OrbDancerBasicWeapon();
				yield return new OrbDancerOrbArc();
				yield return new OrbDancerOrbExtension();
			}
		}

		public override IDisposable ApplyPassiveEffect(VLoadout loadout)
		{
			ErrorReporter.ReportDebug("OrbDancer passive effect is being applied, but orb dancer is not the current unit", () => loadout.CurrentUnit.UnitData.Type != Type);

			var stacks = loadout.CurrentUnit.CurrentKills / 2000;

			for (var i = 1; i <= stacks; i++)
			{
				loadout.Stats.UpdateAttackSpeed($"OrbDancerOrbEssence{i}", 10);
				loadout.Stats.Attack += 30;
				loadout.Stats.AdditiveArmor += 30;
				loadout.Stats.UpdateCooldownSpeed($"OrbDancerOrbEssence{i}", 10);
			}

			return new DisposableAction(
				() =>
				{
					ErrorReporter.ReportDebug("OrbDancer passive effect is being removed, but orb dancer is not the current unit", () => loadout.CurrentUnit.UnitData.Type != Type);

					for (var i = 1; i <= stacks; i++)
					{
						loadout.Stats.UpdateAttackSpeed($"OrbDancerOrbEssence{i}", -10);
						loadout.Stats.Attack -= 30;
						loadout.Stats.AdditiveArmor -= 30;
						loadout.Stats.UpdateCooldownSpeed($"OrbDancerOrbEssence{i}", -10);
					}
				});
		}
	}
}
