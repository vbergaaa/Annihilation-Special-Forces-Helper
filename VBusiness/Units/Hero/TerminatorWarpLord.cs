using System.Collections.Generic;
using VBusiness.Weapons;
using VEntityFramework.Model;

namespace VBusiness.Units
{
	// UnitData: ZealotPurifier
	// WeaponData: TerminatorBlades

	public class TerminatorWarpLord : CommonUnitData
	{
		public override UnitType Type => UnitType.TerminatorWarpLord;

		public override double BaseHealth => 400;

		public override double BaseHealthArmor => 6;

		public override double BaseHealthRegen => 6;

		public override double BaseShields => 625;

		public override double BaseShieldsArmor => 6;

		public override double BaseShieldsRegen => 10;

		public override double HealthIncrement => 10;

		public override double HealthRegenIncrement => 1;

		public override double ShieldIncrement => 17;

		public override double ShieldRegenIncrement => 1.3007;

		public override double HealthArmorIncrement => 0.8;

		public override double ShieldArmorIncrement => 0.8;

		public override UnitType[] SpecTypes => new[] { UnitType.WarpLord };

		public override UnitType BasicType => UnitType.WarpLord;

		public override IEnumerable<UnitRecepePiece> Recepe { get { yield return new UnitRecepePiece(UnitType.BerserkerWarpLord, 10, UnitRankType.None, 1); } }

		public override Evolution Evolution => Evolution.Hero;

		public override IEnumerable<IWeaponData> Weapons
		{
			get
			{
				yield return new TerminatorWarpLordBasicWeapon();
				yield return new TerminatorWarpLordBasicAtkAOE();
			}
		}
	}
}
