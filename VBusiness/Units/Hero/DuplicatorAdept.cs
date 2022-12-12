using System;
using System.Collections.Generic;
using VBusiness.Weapons;
using VEntityFramework.Model;

namespace VBusiness.Units
{
	public class DuplicatorAdept : CommonUnitData
	{
		public override UnitType Type => UnitType.DuplicatorAdept;

		public override double BaseHealth => 300; //guessed

		public override double BaseHealthArmor => 8;

		public override double BaseHealthRegen => throw new NotImplementedException();

		public override double BaseShields => 500; //guessed

		public override double BaseShieldsArmor => 8;

		public override double BaseShieldsRegen => throw new NotImplementedException();

		public override double HealthIncrement => 12; // guess

		public override double HealthRegenIncrement => throw new NotImplementedException();

		public override double HealthArmorIncrement => 0.85;

		public override double ShieldIncrement => 14; // guess

		public override double ShieldRegenIncrement => throw new NotImplementedException();

		public override double ShieldArmorIncrement => 0.85;

		public override UnitType[] SpecTypes => new UnitType[] { UnitType.LightAdept };

		public override UnitType BasicType => UnitType.LightAdept;

		public override IEnumerable<UnitRecepePiece> Recepe { get { yield return new UnitRecepePiece(UnitType.SplitterAdept, 10, UnitRankType.None, 1); } }

		public override Evolution Evolution => Evolution.Hero;

		public override IEnumerable<IWeaponData> GetWeapons(VLoadout loadout)
		{
			yield return new DuplicatorAdeptBasicWeapon();
		}

		public override ITemporaryBuffAbility OffensiveBuffAbility => new DuplicatorAdeptPrecisionTargetting();
	}
}
