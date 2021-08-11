using System;
using System.Collections.Generic;
using VBusiness.Weapons;
using VEntityFramework;
using VEntityFramework.Model;

namespace VBusiness.Units
{
	// UnitData: MasterDance

	public class BladeMaster : CommonUnitData
	{
		public override UnitType Type => UnitType.BladeMaster;

		public override double BaseHealth => 700;

		public override double BaseHealthArmor => 12;

		public override double BaseHealthRegen => 12;

		public override double BaseShields => 1000;

		public override double BaseShieldsArmor => 12;

		public override double BaseShieldsRegen => 22;

		public override double HealthIncrement => 16;

		public override double HealthRegenIncrement => 1.3984;

		public override double ShieldIncrement => 24;

		public override double ShieldRegenIncrement => 2;

		public override double HealthArmorIncrement => 1.1;

		public override double ShieldArmorIncrement => 1.1;

		public override UnitType[] SpecTypes => new[] { UnitType.WarpLord, UnitType.ShieldBattery, UnitType.LightAdept };

		public override UnitType BasicType => UnitType.LightAdept;

		public override IEnumerable<UnitRecepePiece> Recepe
		{
			get
			{
				yield return new UnitRecepePiece(UnitType.SplitterAdept, 3, UnitRankType.SS, 1);
				yield return new UnitRecepePiece(UnitType.BladeDancer, 7, UnitRankType.X, 1);
				yield return new UnitRecepePiece(UnitType.LightAdept, 10, UnitRankType.SSS, 1);
			}
		}

		public override Evolution Evolution => Evolution.Hero;

		public override IEnumerable<IWeaponData> Weapons
		{
			get
			{
				yield return new BladeMasterBasicWeapon();
				yield return new BladeMasterFusedAssault();
			}
		}

		public override IDisposable ApplyPassiveEffect(VLoadout loadout)
		{
			loadout.Stats.CriticalChance += 15;
			loadout.Stats.CriticalDamage += 30;

			return new DisposableAction(() =>
			{
				loadout.Stats.CriticalChance -= 15;
				loadout.Stats.CriticalDamage -= 30;
			});
		}
	}
}
