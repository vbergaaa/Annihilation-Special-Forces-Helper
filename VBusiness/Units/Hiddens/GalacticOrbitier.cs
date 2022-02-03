using System;
using System.Collections.Generic;
using VBusiness.Weapons;
using VEntityFramework;
using VEntityFramework.Model;

namespace VBusiness.Units
{
	public class GalacticOrbiter : CommonUnitData
	{
		public override UnitType Type => UnitType.GalacticOrbiter;

		public override double BaseHealth => 1000;

		public override double BaseHealthArmor => 16;

		public override double BaseHealthRegen => 15;

		public override double BaseShields => 1500;

		public override double BaseShieldsArmor => 16;

		public override double BaseShieldsRegen => 30;

		public override double HealthIncrement => 23;

		public override double HealthRegenIncrement => 1.8;

		public override double HealthArmorIncrement => 1.4;

		public override double ShieldIncrement => 32;

		public override double ShieldRegenIncrement => 2.5;

		public override double ShieldArmorIncrement => 1.4;

		public override UnitType[] SpecTypes => new[] { UnitType.DarkShadow, UnitType.WarpLord, UnitType.ShieldBattery };

		public override UnitType BasicType => UnitType.DarkShadow;

		public override IEnumerable<UnitRecepePiece> Recepe
		{
			get
			{
				yield return new UnitRecepePiece(UnitType.OrbOrbiter, 7, UnitRankType.SSZ, 1);
				yield return new UnitRecepePiece(UnitType.BloodAvenger, 10, UnitRankType.XX, 2);
				yield return new UnitRecepePiece(UnitType.OrbDancer, 5, UnitRankType.XX, 2);
			}
		}

		public override Evolution Evolution => Evolution.Hero;

		public override IEnumerable<IWeaponData> GetWeapons(VLoadout loadout)
		{
			yield return new GalaxianOrbiterBasicWeapon();
			yield return new GalaxianOrbiterOrbSpiral();
			yield return new GalaxianOrbiterOrbGalaxy();
			yield return new GalaxianOrbiterGalacticResonance();
		}

		public override IDisposable ApplyPassiveEffect(VLoadout loadout)
		{
			ErrorReporter.ReportDebug("GalaxianOrbiter passive effect is being applied, but GalaxianOrbiter is not the current unit", () => loadout.CurrentUnit.UnitData.Type != Type);

			var stacks = loadout.CurrentUnit.CurrentKills / 1000;

			for (var i = 1; i <= stacks; i++)
			{
				loadout.Stats.UpdateAttackSpeed($"GalaxianOrbiterOrbEssence{i}", 20);
				loadout.Stats.Attack += 40;
				loadout.Stats.AdditiveArmor += 40;
				loadout.Stats.UpdateCooldownSpeed($"GalaxianOrbiterOrbEssence{i}", 20);
			}

			return new DisposableAction(
				() =>
				{
					ErrorReporter.ReportDebug("GalaxianOrbiter passive effect is being removed, but GalaxianOrbiter is not the current unit", () => loadout.CurrentUnit.UnitData.Type != Type);

					for (var i = 1; i <= stacks; i++)
					{
						loadout.Stats.UpdateAttackSpeed($"GalaxianOrbiterOrbEssence{i}", -20);
						loadout.Stats.Attack -= 40;
						loadout.Stats.AdditiveArmor -= 40;
						loadout.Stats.UpdateCooldownSpeed($"GalaxianOrbiterOrbEssence{i}", -20);
					}
				});
		}

		public override ITemporaryBuffAbility OffensiveBuffAbility => new GalaxianOrbiterGalaxyEmpowerment();
	}
}
