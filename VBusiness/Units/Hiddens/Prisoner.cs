using System;
using System.Collections.Generic;
using VBusiness.Weapons;
using VEntityFramework;
using VEntityFramework.Model;

namespace VBusiness.Units
{
	// UnitData: Prisoner
	// WeaponData: PrisonerBlades
	// EffectData: WarpBladesDamage2

	public class Prisoner : CommonUnitData
	{
		public override UnitType Type => UnitType.Prisoner;

		public override double BaseHealth => 275;

		public override double BaseHealthArmor => 4;

		public override double BaseHealthRegen => 8;

		public override double BaseShields => 450;

		public override double BaseShieldsArmor => 4;

		public override double BaseShieldsRegen => 6;

		public override double HealthIncrement => 6;

		public override double HealthRegenIncrement => 0.8515;

		public override double ShieldIncrement => 12;

		public override double ShieldRegenIncrement => 0.8984;

		public override double HealthArmorIncrement => 0.65;

		public override double ShieldArmorIncrement => 0.65;

		public override UnitType[] SpecTypes => new[] { UnitType.WarpLord, UnitType.ShieldBattery };

		public override UnitType BasicType => UnitType.WarpLord;

		public override IEnumerable<UnitRecepePiece> Recepe
		{
			get
			{
				yield return new UnitRecepePiece(UnitType.DarkWarpLord, 3, UnitRankType.None, 2);
				yield return new UnitRecepePiece(UnitType.ShieldBattery, 3, UnitRankType.None, 1);
				yield return new UnitRecepePiece(UnitType.WarpLord, 1, UnitRankType.None, 5);
			}
		}

		public override Evolution Evolution => Evolution.DNA1;

		public override IEnumerable<IWeaponData> GetWeapons(VLoadout loadout)
		{
			yield return new PrisonerBasicWeapon();
			yield return new PrisonerBasicAtkAOE();
			yield return new PrisonerBerserkerAOE();
		}

		public override IDisposable ApplyPassiveEffect(VLoadout loadout)
		{
			loadout.Stats.Attack += 30;
			loadout.Stats.UpdateAttackSpeed("Berserker", 30);

			return new DisposableAction(() =>
			{
				loadout.Stats.Attack -= 30;
				loadout.Stats.UpdateAttackSpeed("Berserker", -30);
			});
		}
	}
}
