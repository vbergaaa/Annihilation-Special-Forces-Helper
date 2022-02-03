using System.Collections.Generic;
using VBusiness.Weapons;
using VEntityFramework.Model;

namespace VBusiness.Units
{
	// UnitType: Disruptor
	// WeaponData: DisruptorBlast
	// EffectData: DisruptorWeaponDamage2

	public class Disruptor : CommonUnitData
	{
		public override UnitType Type => UnitType.Disruptor;

		public override double BaseHealth => 500;

		public override double BaseHealthArmor => 7;

		public override double BaseHealthRegen => 3;

		public override double BaseShields => 650;

		public override double BaseShieldsArmor => 7;

		public override double BaseShieldsRegen => 10;

		public override double HealthIncrement => 9;

		public override double HealthRegenIncrement => 0.6992;

		public override double ShieldIncrement => 22;

		public override double ShieldRegenIncrement => 1.5;

		public override double HealthArmorIncrement => 0.7;

		public override double ShieldArmorIncrement => 0.7;

		public override UnitType[] SpecTypes => new[] { UnitType.Striker, UnitType.Dreadnought };

		public override UnitType BasicType => UnitType.Dreadnought;

		public override IEnumerable<UnitRecepePiece> Recepe
		{
			get
			{
				yield return new UnitRecepePiece(UnitType.UnstableDreadnought, 3, UnitRankType.SS, 1);
				yield return new UnitRecepePiece(UnitType.Reaver, 3, UnitRankType.S, 1);
				yield return new UnitRecepePiece(UnitType.Striker, 1, UnitRankType.S, 5);
			}
		}

		public override Evolution Evolution => Evolution.DNA1;

		public override IEnumerable<IWeaponData> GetWeapons(VLoadout loadout)
		{
			yield return new DisruptorBasicWeapon();
			yield return new DisruptorBasicAttackAOE();
			yield return new DisruptorDisplacementNova();
			yield return new DisruptorPurificationNova();
		}
	}
}
