using System.Collections.Generic;
using VBusiness.Weapons;
using VEntityFramework.Model;

namespace VBusiness.Units
{
	public class EvolutionProbe : CommonUnitData
	{
		// UnitData: EvolutionProbe
		// WeaponData: EvolutionParticleBeam
		// EffectData: DarkParticleBeam2

		public override UnitType Type => UnitType.EvolutionProbe;

		public override double BaseHealth => 100;

		public override double BaseHealthArmor => 6;

		public override double BaseHealthRegen => 0;

		public override double BaseShields => 200;

		public override double BaseShieldsArmor => 6;

		public override double BaseShieldsRegen => 5;

		public override double HealthIncrement => 10;

		public override double HealthRegenIncrement => 0.6015;

		public override double ShieldIncrement => 16;

		public override double ShieldRegenIncrement => 1;

		public override double HealthArmorIncrement => 0.6;

		public override double ShieldArmorIncrement => 0.6;

		public override UnitType[] SpecTypes => System.Array.Empty<UnitType>();

		public override UnitType BasicType => UnitType.Probe;

		public override IEnumerable<UnitRecepePiece> Recepe => UnitCostHelper.GetDNA2Recipe(UnitType.DarkProbe);

		public override Evolution Evolution => Evolution.DNA2;

		public override IEnumerable<IWeaponData> Weapons
		{
			get
			{
				yield return new EvolutionProbeBasicWeapon();
			}
		}
	}
}
