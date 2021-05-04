using System;
using VBusiness.HelperClasses;
using VEntityFramework;
using VEntityFramework.Model;

namespace VBusiness
{
	public class Stats : VStats
	{
		public Stats(VLoadout loadout) : base(loadout)
		{
		}

		protected override void SetDefaultValuesCore()
		{
			Attack = 100;
			CriticalChance = 0;
			CriticalDamage = 100;
			HealthArmor = 100;
			ShieldsArmor = 100;
			Acceleration = 100;
		}

		public override double Damage => StatCalculationHelper.GetDamage(Loadout);

		public override double Toughness  => StatCalculationHelper.GetToughness(Loadout);

		public override double Recovery => 0;
	}
}
