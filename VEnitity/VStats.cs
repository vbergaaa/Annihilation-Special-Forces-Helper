using System;
using VEntityFramework.Data;

namespace VEntityFramework.Model
{
	public abstract class VStats : VBusinessObject
	{
		public VStats()
		{
			SetDefaultValues();
		}

		private void SetDefaultValues()
		{
			Attack = 100;
			AttackSpeed = 100;
			CriticalChance = 0;
			CriticalDamage = 100;
			Health = 100;
			HealthArmor = 100;
			Shields = 100;
			ShieldsArmor = 100;
			DamageReduction = 0;
		}

		public override string BizoName => "Stats";

		public decimal Attack { get; set; }
		public decimal AttackSpeed { get; set; }
		public decimal CriticalChance { get; set; }
		public decimal CriticalDamage { get; set; }
		public decimal Health { get; set; }
		public decimal HealthArmor { get; set; }
		public decimal Shields { get; set; }
		public decimal ShieldsArmor { get; set; }
		public decimal DamageReduction { get; set; }
	}
}
