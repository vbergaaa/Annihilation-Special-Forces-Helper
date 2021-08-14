using System.Collections.Generic;
using VBusiness.Weapons;
using VEntityFramework.Model;

namespace VBusiness.Units
{
	// UnitData: ZealotAiur
	// WeaponData: SolariteReaper

	public class BerserkerWarpLord : CommonUnitData
	{
		public override UnitType Type => UnitType.BerserkerWarpLord;

		public override double BaseHealth => 225;

		public override double BaseHealthArmor => 5;

		public override double BaseHealthRegen => 4;

		public override double BaseShields => 320;

		public override double BaseShieldsArmor => 5;

		public override double BaseShieldsRegen => 4;

		public override double HealthIncrement => 7;

		public override double HealthRegenIncrement => 0.3984;

		public override double ShieldIncrement => 13;

		public override double ShieldRegenIncrement => 1;

		public override double HealthArmorIncrement => 0.6;

		public override double ShieldArmorIncrement => 0.6;

		public override UnitType[] SpecTypes => new[] { UnitType.WarpLord };

		public override UnitType BasicType => UnitType.WarpLord;

		public override IEnumerable<UnitRecepePiece> Recepe => UnitCostHelper.GetDNA2Recipe(UnitType.DarkWarpLord);

		public override Evolution Evolution => Evolution.DNA2;

		public override IEnumerable<IWeaponData> Weapons
		{
			get
			{
				yield return new BerserkerWarpLordBasicWeapon();
				yield return new BerserkerWarpLordBasicAttackAOE();
				yield return new BerserkerWarpLordBerserkerWarpAnnihilation();
				yield return new BerserkerWarpLordWhirlwind();
			}
		}
	}
}
