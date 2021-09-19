using System;
using System.Collections.Generic;
using VBusiness.Weapons;
using VEntityFramework;
using VEntityFramework.Model;

namespace VBusiness.Units
{
	public class OrbOrbiter : CommonUnitData
	{
		public override UnitType Type => UnitType.OrbOrbiter;

		public override double BaseHealth => 700;

		public override double BaseHealthArmor => 12;

		public override double BaseHealthRegen => 12;

		public override double BaseShields => 1000;

		public override double BaseShieldsArmor => 12;

		public override double BaseShieldsRegen => 22;

		public override double HealthIncrement => 16;

		public override double HealthRegenIncrement => 1.4;

		public override double HealthArmorIncrement => 1.1;

		public override double ShieldIncrement => 24;

		public override double ShieldRegenIncrement => 2;

		public override double ShieldArmorIncrement => 1.1;

		public override UnitType[] SpecTypes => new[] { UnitType.DarkShadow, UnitType.WarpLord, UnitType.ShieldBattery };

		public override UnitType BasicType => UnitType.DarkShadow;

		public override IEnumerable<UnitRecepePiece> Recepe
		{
			get
			{
				yield return new UnitRecepePiece(UnitType.OrbDancer, 7, UnitRankType.X, 1);
				yield return new UnitRecepePiece(UnitType.BloodAvenger, 5, UnitRankType.SS, 1);
				yield return new UnitRecepePiece(UnitType.DarkAvenger, 10, UnitRankType.SSS, 1);
			}
		}

		public override Evolution Evolution => Evolution.Hero;

		public override IEnumerable<IWeaponData> Weapons
		{
			get
			{
				yield return new OrbOrbiterBasicWeapon();
				yield return new OrbOrbiterOrbWave();
				yield return new OrbOrbiterOrbOrbit();
			}
		}

		public override IDisposable ApplyPassiveEffect(VLoadout loadout)
		{
			ErrorReporter.ReportDebug("OrbOrbiter passive effect is being applied, but OrbOrbiter is not the current unit", () => loadout.CurrentUnit.UnitData.Type != Type);

			var stacks = loadout.CurrentUnit.CurrentKills / 2000;

			for (var i = 1; i <= stacks; i++)
			{
				loadout.Stats.UpdateAttackSpeed($"OrbOrbiterOrbEssence{i}", 20);
				loadout.Stats.Attack += 40;
				loadout.Stats.AdditiveArmor += 40;
				loadout.Stats.UpdateCooldownSpeed($"OrbOrbiterOrbEssence{i}", 20);
			}

			return new DisposableAction(
				() =>
				{
					ErrorReporter.ReportDebug("OrbOrbiter passive effect is being removed, but OrbOrbiter is not the current unit", () => loadout.CurrentUnit.UnitData.Type != Type);

					for (var i = 1; i <= stacks; i++)
					{
						loadout.Stats.UpdateAttackSpeed($"OrbOrbiterOrbEssence{i}", -20);
						loadout.Stats.Attack -= 40;
						loadout.Stats.AdditiveArmor -= 40;
						loadout.Stats.UpdateCooldownSpeed($"OrbOrbiterOrbEssence{i}", -20);
					}
				});
		}

		public override ITemporaryBuffAbility OffensiveBuffAbility => new OrbOrbiterOrbitEmpowerment();
	}
}
