using System;
using System.Collections.Generic;
using System.Text;
using VBusiness.Weapons;
using VEntityFramework.Model;

namespace VBusiness.Units
{
	public class Artifact : IUnitData
	{
		public UnitType Type => UnitType.Artifact;

		double IUnitData.BaseHealth => 0;

		double IUnitData.BaseHealthArmor => 0;

		double IUnitData.BaseHealthRegen => 0;

		double IUnitData.BaseShields => 0;

		double IUnitData.BaseShieldsArmor => 0;

		double IUnitData.BaseShieldsRegen => 0;

		double IUnitData.HealthIncrement => 0;

		double IUnitData.HealthRegenIncrement => 0;

		double IUnitData.HealthArmorIncrement => 0;

		double IUnitData.ShieldIncrement => 0;

		double IUnitData.ShieldRegenIncrement => 0;

		double IUnitData.ShieldArmorIncrement => 0;

		UnitType[] IUnitData.SpecTypes => Array.Empty<UnitType>();

		UnitType IUnitData.BasicType => UnitType.None;

		IEnumerable<UnitRecepePiece> IUnitData.Recepe
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

		Evolution IUnitData.Evolution => Evolution.Basic;

		public IEnumerable<IWeaponData> Weapons
		{
			get
			{
				yield return new EmptyWeapon();
			}
		}
	}
}
