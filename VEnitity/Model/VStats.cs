using System;
using VEntityFramework.Data;

namespace VEntityFramework.Model
{
	public abstract class VStats : VBusinessObject
	{
		public VStats(VLoadout loadout)
		{
			Loadout = loadout;
		}

		#region Unit 

		public VUnit CurrentUnit => Loadout.CurrentUnit;

		public bool UseUnitStats => Loadout.UseUnitStats;

		public void RefreshAllBindings()
		{
			OnPropertyChanged(nameof(AttackForBinding));
			OnPropertyChanged(nameof(AttackSpeedForBinding));
			OnPropertyChanged(nameof(CriticalChanceForBinding));
			OnPropertyChanged(nameof(CriticalDamageForBinding));
			OnPropertyChanged(nameof(HealthForBinding));
			OnPropertyChanged(nameof(HealthArmorForBinding));
			OnPropertyChanged(nameof(ShieldsForBinding));
			OnPropertyChanged(nameof(ShieldsArmorForBinding));
			OnPropertyChanged(nameof(DamageIncreaseForBinding));
			OnPropertyChanged(nameof(DamageReductionForBinding));
			OnPropertyChanged(nameof(AccelerationForBinding));
			OnPropertyChanged(nameof(Damage));
			OnPropertyChanged(nameof(Toughness));
			OnPropertyChanged(nameof(Recovery));
		}
		#endregion
		public override string BizoName => "Stats";

		#region Calculated Stats;

		public abstract double Damage { get; }

		public abstract double Toughness { get; }

		public abstract double Recovery { get; }

		#endregion

		#region Raw Stats

		#region Attack

		public double Attack
		{
			get => fAttack;
			set
			{
				fAttack = value;
				OnPropertyChanged(nameof(AttackForBinding));
				OnPropertyChanged(nameof(Damage));
			}
		}
		double fAttack;

		#endregion

		#region AttackSpeed

		public double AttackSpeed
		{
			get
			{
				var attackSpeed = 100.0;
				foreach (var kvp in AttackSpeedDictionary)
				{
					attackSpeed = attackSpeed * (100 + kvp.Value) / 100;
				}
				return attackSpeed;
			}
		}

		StatsDictionary AttackSpeedDictionary => fAttackSpeedDictionary ??= new StatsDictionary();
		StatsDictionary fAttackSpeedDictionary;

		public void UpdateAttackSpeed(string key, double value, int? quantity = null)
		{
			if (!quantity.HasValue)
			{
				AttackSpeedDictionary.Update(key, value);
			}
			else if (quantity.Value != 0)
			{
				AttackSpeedDictionary.UpdateExpontiental(key, value, quantity.Value);
			}
			OnPropertyChanged(nameof(AttackSpeedForBinding));
			OnPropertyChanged(nameof(Damage));
		}

		#endregion

		#region CriticalChance

		public double CriticalChance
		{
			get => fCriticalChance;
			set
			{
				fCriticalChance = value;
				OnPropertyChanged(nameof(CriticalChance));
				OnPropertyChanged(nameof(Damage));
			}
		}
		double fCriticalChance;

		#endregion

		#region CriticalDamage

		public double CriticalDamage
		{
			get => fCriticalDamage;
			set
			{
				fCriticalDamage = value;
				OnPropertyChanged(nameof(CriticalDamageForBinding));
				OnPropertyChanged(nameof(Damage));
			}
		}
		double fCriticalDamage;

		#endregion

		#region Health

		public double Health
		{
			get => fHealth;
			set
			{
				fHealth = value;
				OnPropertyChanged(nameof(HealthForBinding));
				OnPropertyChanged(nameof(Toughness));
				OnPropertyChanged(nameof(Recovery));
			}
		}
		double fHealth;

		#endregion

		#region HealthArmor

		public double HealthArmor
		{
			get => fHealthArmor;
			set
			{
				fHealthArmor = value;
				OnPropertyChanged(nameof(HealthArmorForBinding));
				OnPropertyChanged(nameof(Toughness));
				OnPropertyChanged(nameof(Recovery));
			}
		}
		double fHealthArmor;

		#endregion

		#region Shields

		public double Shields
		{
			get => fShields;
			set
			{
				fShields = value;
				OnPropertyChanged(nameof(ShieldsForBinding));
				OnPropertyChanged(nameof(Toughness));
				OnPropertyChanged(nameof(Recovery));
			}
		}
		double fShields;

		#endregion

		#region ShieldsArmor

		public double ShieldsArmor
		{
			get => fShieldsArmor;
			set
			{
				fShieldsArmor = value;
				OnPropertyChanged(nameof(ShieldsArmorForBinding));
				OnPropertyChanged(nameof(Toughness));
				OnPropertyChanged(nameof(Recovery));
			}
		}
		double fShieldsArmor;

		#endregion

		#region DamageIncrease

		public double DamageIncrease
		{
			get
			{
				var totalDI = 100.0;
				foreach (var kvp in DamageIncreaseDictionary)
				{
					totalDI *= (100 + kvp.Value) / 100;
				}
				return totalDI - 100;
			}
		}

		StatsDictionary DamageIncreaseDictionary => fDamageIncreaseDictionary ??= new StatsDictionary();
		StatsDictionary fDamageIncreaseDictionary;

		public void UpdateDamageIncrease(string key, double amount)
		{
			DamageIncreaseDictionary.Update(key, amount);
			OnPropertyChanged(nameof(Damage));
			OnPropertyChanged(nameof(DamageIncreaseForBinding));
		}

		#endregion

		#region DamageReduction

		protected double DamageReduction
		{
			get
			{
				var totalDr = 0.0;
				foreach (var kvp in DamageReductionDictionary)
				{
					totalDr = 100 - ((100 - totalDr) * (100 - kvp.Value) / 100);
				}
				return totalDr;
			}
		}

		protected StatsDictionary DamageReductionDictionary => fDamageReductionDictionary ??= new StatsDictionary();
		StatsDictionary fDamageReductionDictionary;

		public void UpdateDamageReduction(string key, double amount)
		{
			DamageReductionDictionary.Update(key, amount);

			OnPropertyChanged(nameof(DamageReductionForBinding));
			OnPropertyChanged(nameof(Toughness));
			OnPropertyChanged(nameof(Recovery));
		}

		#endregion

		#region AdditiveArmor

		public double AdditiveArmor
		{
			// Additive Armor Currently isn't being used, because I haven't been about to find a way to accurately
			// add it with knowing the exact armor of the unit. When that gets implemented I can revisit this 
			get => fAdditiveArmor;
			set
			{
				fAdditiveArmor = value;
				OnPropertyChanged(nameof(Toughness));
				OnPropertyChanged(nameof(Recovery));
			}
		}
		double fAdditiveArmor;

		#endregion

		#region RedCrits

		public bool HasRedCrits
		{
			get => fHasRedCrits;
			set
			{
				fHasRedCrits = value;
				OnPropertyChanged(nameof(Damage));
			}
		}
		bool fHasRedCrits;

		#endregion

		#region BlackCrits

		public bool HasBlackCrits
		{
			get => fHasBlackCrits;
			set
			{
				fHasBlackCrits = value;
				OnPropertyChanged(nameof(Damage));
			}
		}
		bool fHasBlackCrits;

		#endregion

		// from what I can tell, you get 1% accel per essence, and it is multiplicative to the 10% accel you get per infuse, so I think it makes sense to store these values separately
		public double Acceleration
		{
			get => fAcceleration;
			set
			{
				fAcceleration = value;
				OnPropertyChanged(nameof(AccelerationForBinding));
			}
		}
		double fAcceleration;

		public double MoveSpeed { get; set; } // it looks like the 2.4477% move speed per essence is stacked multiplicatively, so it is exponential, where the 10% move speed from essence is additive (linear) they are multiplied to get the result

		public double CooldownReduction { get; set; } // the tests for accel above were actually done on CDR, so is more accurately on this. not sure if they are the same thing at this stage

		#region Trifecta Power

		public int TrifectaStacks
		{
			get => fTrifectaStacks;
			set
			{
				var oldValue = fTrifectaStacks;
				fTrifectaStacks = value;
				var diff = fTrifectaStacks - oldValue;
				if (Rank >= UnitRank.SSS)
				{
					AddTrifectaStacks(diff);
				}
			}
		}

		int fTrifectaStacks;

		void AddTrifectaStacks(int diff)
		{
			Attack += 1.5 * diff;
			UpdateAttackSpeed("Trifecta", 1.5 * diff);
			Health += 1.5 * diff;
			HealthArmor += 1 * diff;
			Shields += 1.5 * diff;
			ShieldsArmor += 1 * diff;
		}

		#endregion

		#region UnitRank

		public UnitRank Rank
		{
			get => fRank;
			set
			{
				var oldRank = fRank;
				fRank = value;
				if (oldRank < UnitRank.SSS && fRank >= UnitRank.SSS)
				{
					ActivateTrifectaPower();
				}
				else if (oldRank >= UnitRank.SSS && fRank < UnitRank.SSS)
				{
					DeactivateTrifectaPower();
				}
			}
		}

		private void DeactivateTrifectaPower()
		{
			Attack -= 1.5 * TrifectaStacks;
			UpdateAttackSpeed("Trifecta", -1.5 * TrifectaStacks);
			Health -= 1.5 * TrifectaStacks;
			HealthArmor -= 1 * TrifectaStacks;
			Shields -= 1.5 * TrifectaStacks;
			ShieldsArmor -= 1 * TrifectaStacks;
		}

		private void ActivateTrifectaPower()
		{
			Attack += 1.5 * TrifectaStacks;
			UpdateAttackSpeed("Trifecta", 1.5 * TrifectaStacks);
			Health += 1.5 * TrifectaStacks;
			HealthArmor += 1 * TrifectaStacks;
			Shields += 1.5 * TrifectaStacks;
			ShieldsArmor += 1 * TrifectaStacks;
		}

		UnitRank fRank;

		#endregion

		#region DefensiveEssenceStacks

		public int DefensiveEssenceStacks
		{
			get => fDefensiveEssenceStacks;
			set
			{
				var oldStacks = fDefensiveEssenceStacks;
				fDefensiveEssenceStacks = value;
				AdditiveArmor += Loadout.CurrentUnit.EssenceStacks * 0.03 * (fDefensiveEssenceStacks - oldStacks);
			}
		}
		int fDefensiveEssenceStacks;

		#endregion

		#endregion

		#region UnitStats

		public double UnitAttack => CurrentUnit.BaseAttack * Attack / 100;
		public double UnitAttackSpeed => CurrentUnit.BaseAttackSpeed / AttackSpeed * 100;
		public double UnitCriticalDamage => CurrentUnit.BaseAttack * CriticalDamage / 100;
		public double UnitHealth => CurrentUnit.BaseHealth * Health / 100;
		public double UnitHealthArmor => CurrentUnit.BaseHealthArmor * HealthArmor / 100;
		public double UnitShields => CurrentUnit.BaseShields * Shields / 100;
		public double UnitShieldsArmor => CurrentUnit.BaseShieldArmor * ShieldsArmor / 100;

		#endregion

		#region PlayerStats

		double PlayerAttack => Attack;
		double PlayerAttackSpeed => AttackSpeed;
		double PlayerCriticalDamage => CriticalDamage;
		double PlayerHealth => Health;
		double PlayerHealthArmor => HealthArmor;
		double PlayerShields => Shields;
		double PlayerShieldsArmor => ShieldsArmor;

		#endregion

		#region StatsForBinding

		public double AttackForBinding => Math.Round(UseUnitStats ? UnitAttack : PlayerAttack, 2);
		public double AttackSpeedForBinding => Math.Round(UseUnitStats ? UnitAttackSpeed : PlayerAttackSpeed, 2);
		public double CriticalChanceForBinding => Math.Round(CriticalChance, 2);
		public double CriticalDamageForBinding => Math.Round(UseUnitStats ? UnitCriticalDamage : PlayerCriticalDamage, 2);
		public double HealthForBinding => Math.Round(UseUnitStats ? UnitHealth : PlayerHealth, 2);
		public double HealthArmorForBinding => Math.Round(UseUnitStats ? UnitHealthArmor : PlayerHealthArmor, 2);
		public double ShieldsForBinding => Math.Round(UseUnitStats ? UnitShields : PlayerShields, 2);
		public double ShieldsArmorForBinding => Math.Round(UseUnitStats ? UnitShieldsArmor : PlayerShieldsArmor, 2);
		public double DamageReductionForBinding => Math.Round(DamageReduction, 2);
		public double DamageIncreaseForBinding => Math.Round(DamageIncrease, 2);
		public double AccelerationForBinding => Math.Round(Acceleration, 2);

		#endregion

		public VLoadout Loadout { get; }
	}
}
