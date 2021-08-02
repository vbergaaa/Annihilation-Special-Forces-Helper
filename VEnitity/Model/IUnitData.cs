using System;
using System.Collections.Generic;
using System.Text;
using VEntityFramework.Data;

namespace VEntityFramework.Model
{
	public interface IUnitData : IXmlObject
	{
		[VXML(true, "Key")]
		UnitType Type { get; }
		double BaseHealth { get; }
		double BaseHealthArmor { get; }
		double BaseHealthRegen { get; }
		double BaseShields { get; }
		double BaseShieldsArmor { get; }
		double BaseShieldsRegen { get; }
		double HealthIncrement { get; }
		double HealthRegenIncrement { get; }
		double HealthArmorIncrement { get; }
		double ShieldIncrement { get; }
		double ShieldRegenIncrement { get; }
		double ShieldArmorIncrement { get; }
		UnitType[] SpecTypes { get; }
		UnitType BasicType { get; }
		IEnumerable<UnitRecepePiece> Recepe { get; }
		Evolution Evolution { get; }
		IEnumerable<IWeaponData> Weapons { get; }
	}

	public struct UnitRecepePiece
	{
		public UnitRecepePiece(UnitType unit, int inf, UnitRankType rank, int qty) : this(unit, inf, rank, qty, true)
		{
		}

		public UnitRecepePiece(UnitType unit, int inf, UnitRankType rank, int qty, bool canUseForEvo)
		{
			Unit = unit;
			Infuse = inf;
			Rank = rank;
			Quantity = qty;
			CanUseForEvo = canUseForEvo;
		}

		public UnitType Unit { get; }
		public int Infuse { get; }
		public UnitRankType Rank { get; }
		public int Quantity { get; }
		public bool CanUseForEvo { get; }
	}

	public enum Evolution
	{
		Basic,
		DNA1,
		DNA2,
		Hero,
		SuperHero,
		Annihilator
	}
}
