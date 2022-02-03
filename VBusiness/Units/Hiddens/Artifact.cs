using System;
using System.Collections.Generic;
using VBusiness.Weapons;
using VEntityFramework.Model;

namespace VBusiness.Units
{
	public class Artifact : CommonUnitData
	{
		public override UnitType Type => UnitType.Artifact;

		public override double BaseHealth => 0;

		public override double BaseHealthArmor => 0;

		public override double BaseHealthRegen => 0;

		public override double BaseShields => 0;

		public override double BaseShieldsArmor => 0;

		public override double BaseShieldsRegen => 0;

		public override double HealthIncrement => 0;

		public override double HealthRegenIncrement => 0;

		public override double HealthArmorIncrement => 0;

		public override double ShieldIncrement => 0;

		public override double ShieldRegenIncrement => 0;

		public override double ShieldArmorIncrement => 0;

		public override UnitType[] SpecTypes => Array.Empty<UnitType>();

		public override UnitType BasicType => UnitType.None;

		public override IEnumerable<UnitRecepePiece> Recepe
		{
			get
			{
				yield return new UnitRecepePiece(UnitType.BerserkerWarpLord, 0, UnitRankType.XYZ, 1);
				yield return new UnitRecepePiece(UnitType.EvolutionProbe, 0, UnitRankType.SSZ, 1);
				yield return new UnitRecepePiece(UnitType.DarkProbe, 0, UnitRankType.XX, 1);
				yield return new UnitRecepePiece(UnitType.Probe, 0, UnitRankType.SSS, 1);
				yield return new UnitRecepePiece(UnitType.None, 0, UnitRankType.SS, 1);
			}
		}

		public override Evolution Evolution => Evolution.Basic;

		public override IEnumerable<IWeaponData> GetWeapons(VLoadout loadout)
		{
			yield return new EmptyWeapon();
		}
	}
}
