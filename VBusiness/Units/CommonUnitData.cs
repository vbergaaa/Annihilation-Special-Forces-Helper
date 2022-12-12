using System;
using System.Collections.Generic;
using VBusiness.Weapons;
using VEntityFramework.Model;

namespace VBusiness.Units
{
	public abstract class CommonUnitData : IUnitData
	{
		public abstract UnitType Type { get; }
		public abstract double BaseHealth { get; }
		public abstract double BaseHealthArmor { get; }
		public abstract double BaseHealthRegen { get; }
		public abstract double BaseShields { get; }
		public abstract double BaseShieldsArmor { get; }
		public abstract double BaseShieldsRegen { get; }
		public abstract double HealthIncrement { get; }
		public abstract double HealthRegenIncrement { get; }
		public abstract double HealthArmorIncrement { get; }
		public abstract double ShieldIncrement { get; }
		public abstract double ShieldRegenIncrement { get; }
		public abstract double ShieldArmorIncrement { get; }
		public abstract UnitType[] SpecTypes { get; }
		public abstract UnitType BasicType { get; }
		public abstract IEnumerable<UnitRecepePiece> Recepe { get; }
		public abstract Evolution Evolution { get; }
		public abstract IEnumerable<IWeaponData> GetWeapons(VLoadout loadout);

		public virtual IDisposable ApplyPassiveEffect(VLoadout loadout)
		{
			return null;
		}

		public virtual ITemporaryBuffAbility OffensiveBuffAbility => null;
	}
}
