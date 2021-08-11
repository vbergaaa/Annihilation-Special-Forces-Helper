using System.Collections.Generic;
using VBusiness.Weapons;
using VEntityFramework.Model;

namespace VBusiness.Units
{
	public class PurificationWalker : CommonUnitData
	{
		// UnitData: ColossusPurifier
		// WeaponData: ColossusPurifierThermalLances
		// EffectData: ColossusPurifierThermalLancesDamage

		public override UnitType Type => UnitType.PurificationWalker;

		public override double BaseHealth => 600;

		public override double BaseHealthArmor => 8;

		public override double BaseHealthRegen => 5;

		public override double BaseShields => 850;

		public override double BaseShieldsArmor => 8;

		public override double BaseShieldsRegen => 5;

		public override double HealthIncrement => 12;

		public override double HealthRegenIncrement => 1;

		public override double ShieldIncrement => 18;

		public override double ShieldRegenIncrement => 1.5;

		public override double HealthArmorIncrement => 1.1;

		public override double ShieldArmorIncrement => 1.1;

		public override UnitType[] SpecTypes => new[] { UnitType.Striker, UnitType.Dreadnought };

		public override UnitType BasicType => UnitType.Dragoon;

		public override IEnumerable<UnitRecepePiece> Recepe
		{
			get
			{
				yield return new UnitRecepePiece(UnitType.Disruptor, 3, UnitRankType.SS, 1);
				yield return new UnitRecepePiece(UnitType.Colossus, 7, UnitRankType.X, 1);
				yield return new UnitRecepePiece(UnitType.WrathWalker, 3, UnitRankType.SS, 1);
			}
		}

		public override Evolution Evolution => Evolution.Hero;

		public override IEnumerable<IWeaponData> Weapons
		{
			get
			{
				yield return new PurificationWalkerBasicWeapon();
				yield return new PurificationWalkerPurificationBeam();
				yield return new DisruptorDisplacementNova(); // yes, this is right
				yield return new PurificationWalkerBasicAttackAOE();
				yield return new PurificationWalkerAutomatedTaldarimBeams();
			}
		}
	}
}
