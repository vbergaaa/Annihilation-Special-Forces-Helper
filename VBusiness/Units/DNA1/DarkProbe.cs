using System.Collections.Generic;
using VBusiness.Weapons;
using VEntityFramework.Model;

namespace VBusiness.Units
{
	//UnitData = DarkProbe
	//WeaponData = DarkParticleBeam
	public class DarkProbe : CommonUnitData
	{
		public override UnitType Type => UnitType.DarkProbe;

		public override double BaseHealth => 50;

		public override double BaseHealthArmor => 4;

		public override double BaseHealthRegen => 0;

		public override double BaseShields => 100;

		public override double BaseShieldsArmor => 4;

		public override double BaseShieldsRegen => 5;

		public override double HealthIncrement => 5;

		public override double HealthRegenIncrement => 0.3007;

		public override double ShieldIncrement => 8;

		public override double ShieldRegenIncrement => 0.5;

		public override double HealthArmorIncrement => 0.3;

		public override double ShieldArmorIncrement => 0.3;

		public override UnitType[] SpecTypes => new UnitType[0];

		public override UnitType BasicType => UnitType.Probe;

		public override IEnumerable<UnitRecepePiece> Recepe => UnitCostHelper.GetDNA1Recipe(BasicType);

		public override Evolution Evolution => Evolution.DNA1;

		public override IEnumerable<IWeaponData> Weapons
		{
			get
			{
				yield return new DarkProbeBasicWeapon();
			}
		}
	}
}
