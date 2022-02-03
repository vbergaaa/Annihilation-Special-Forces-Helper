using System;
using System.Collections.Generic;
using VBusiness.Weapons;
using VEntityFramework;
using VEntityFramework.Model;

namespace VBusiness.Units
{
	// UnitData: StoneZealot
	// EffectData: EyeBeamsGround (NOT StoneZealot)

	public class StonePrisoner : CommonUnitData
	{
		public override UnitType Type => UnitType.StonePrisoner;

		public override double BaseHealth => 600;

		public override double BaseHealthArmor => 6;

		public override double BaseHealthRegen => 10;

		public override double BaseShields => 0;

		public override double BaseShieldsArmor => 0;

		public override double BaseShieldsRegen => 0;

		public override double HealthIncrement => 12;

		public override double HealthRegenIncrement => 1.1015;

		public override double ShieldIncrement => 0;

		public override double ShieldRegenIncrement => 0;

		public override double HealthArmorIncrement => 0.7;

		public override double ShieldArmorIncrement => 0;

		public override UnitType[] SpecTypes => new[] { UnitType.WarpLord, UnitType.ShieldBattery };

		public override UnitType BasicType => UnitType.WarpLord;

		public override IEnumerable<UnitRecepePiece> Recepe
		{
			get
			{
				yield return new UnitRecepePiece(UnitType.BerserkerWarpLord, 5, UnitRankType.S, 1);
				yield return new UnitRecepePiece(UnitType.Prisoner, 5, UnitRankType.S, 1);
			}
		}

		public override Evolution Evolution => Evolution.DNA2;

		public override IEnumerable<IWeaponData> GetWeapons(VLoadout loadout)
		{
			yield return new StonePrisonerBasicWeapon();
			yield return new StonePrisonerBerserkerAOE();
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
