﻿using System;
using System.Collections.Generic;
using System.Text;
using VBusiness.Weapons;
using VEntityFramework.Model;

namespace VBusiness.Units
{
	// UnitData: HybridDominatorVoid
	//

	public class ArchDominator : CommonUnitData
	{
		public override UnitType Type => UnitType.ArchDominator;

		public override double BaseHealth => 1000;

		public override double BaseHealthArmor => 10;

		public override double BaseHealthRegen => 2.5;

		public override double BaseShields => 1000;

		public override double BaseShieldsArmor => 10;

		public override double BaseShieldsRegen => 5;

		public override double HealthIncrement => 11;

		public override double HealthRegenIncrement => 1.5;

		public override double ShieldIncrement => 11;

		public override double ShieldRegenIncrement => 3;

		public override double HealthArmorIncrement => 0.75;

		public override double ShieldArmorIncrement => 0.75;

		public override UnitType[] SpecTypes => new[] { UnitType.Dominator };

		public override UnitType BasicType => UnitType.Dominator;

		public override IEnumerable<UnitRecepePiece> Recepe => UnitCostHelper.GetDNA1Recipe(BasicType);

		public override Evolution Evolution => Evolution.DNA1;

		public override IEnumerable<IWeaponData> Weapons
		{
			get
			{
				yield return new ArchDominatorBasicWeapon();
			}
		}
	}
}
