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
				OnPropertyChanged(new System.ComponentModel.PropertyChangedEventArgs(nameof(Attack)));
				OnPropertyChanged(new System.ComponentModel.PropertyChangedEventArgs(nameof(Damage)));
			}
		}
		double fAttack;

		#endregion

		#region AttackSpeed

		public double AttackSpeed
		{
			get => fAttackSpeed;
			set
			{
				fAttackSpeed = value;
				OnPropertyChanged(new System.ComponentModel.PropertyChangedEventArgs(nameof(AttackSpeed)));
				OnPropertyChanged(new System.ComponentModel.PropertyChangedEventArgs(nameof(Damage)));
			}
		}
		double fAttackSpeed;

		#endregion

		#region CriticalChance

		public double CriticalChance
		{
			get => fCriticalChance;
			set
			{
				fCriticalChance = value;
				OnPropertyChanged(new System.ComponentModel.PropertyChangedEventArgs(nameof(CriticalChance)));
				OnPropertyChanged(new System.ComponentModel.PropertyChangedEventArgs(nameof(Damage)));
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
				OnPropertyChanged(new System.ComponentModel.PropertyChangedEventArgs(nameof(CriticalDamage)));
				OnPropertyChanged(new System.ComponentModel.PropertyChangedEventArgs(nameof(Damage)));
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
				OnPropertyChanged(new System.ComponentModel.PropertyChangedEventArgs(nameof(Health)));
				OnPropertyChanged(new System.ComponentModel.PropertyChangedEventArgs(nameof(Toughness)));
				OnPropertyChanged(new System.ComponentModel.PropertyChangedEventArgs(nameof(Recovery)));
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
				OnPropertyChanged(new System.ComponentModel.PropertyChangedEventArgs(nameof(HealthArmor)));
				OnPropertyChanged(new System.ComponentModel.PropertyChangedEventArgs(nameof(Toughness)));
				OnPropertyChanged(new System.ComponentModel.PropertyChangedEventArgs(nameof(Recovery)));
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
				OnPropertyChanged(new System.ComponentModel.PropertyChangedEventArgs(nameof(Shields)));
				OnPropertyChanged(new System.ComponentModel.PropertyChangedEventArgs(nameof(Toughness)));
				OnPropertyChanged(new System.ComponentModel.PropertyChangedEventArgs(nameof(Recovery)));
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
				OnPropertyChanged(new System.ComponentModel.PropertyChangedEventArgs(nameof(ShieldsArmor)));
				OnPropertyChanged(new System.ComponentModel.PropertyChangedEventArgs(nameof(Toughness)));
				OnPropertyChanged(new System.ComponentModel.PropertyChangedEventArgs(nameof(Recovery)));
			}
		}
		double fShieldsArmor;

		#endregion

		#region DamageIncrease

		public double DamageIncrease
		{
			get => fDamageIncrease;
			set
			{
				fDamageIncrease = value;
				OnPropertyChanged(new System.ComponentModel.PropertyChangedEventArgs(nameof(Damage)));
				OnPropertyChanged(new System.ComponentModel.PropertyChangedEventArgs(nameof(DamageIncrease)));
			}
		}
		double fDamageIncrease;

		#endregion

		#region DamageReduction

		protected double TotalDamageReduction
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

			OnPropertyChanged(new System.ComponentModel.PropertyChangedEventArgs(nameof(DamageReductionForBinding)));
			OnPropertyChanged(new System.ComponentModel.PropertyChangedEventArgs(nameof(Toughness)));
			OnPropertyChanged(new System.ComponentModel.PropertyChangedEventArgs(nameof(Recovery)));
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
				OnPropertyChanged(new System.ComponentModel.PropertyChangedEventArgs(nameof(Toughness)));
				OnPropertyChanged(new System.ComponentModel.PropertyChangedEventArgs(nameof(Recovery)));
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
				OnPropertyChanged(new System.ComponentModel.PropertyChangedEventArgs(nameof(Damage)));
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
				OnPropertyChanged(new System.ComponentModel.PropertyChangedEventArgs(nameof(Damage)));
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
				OnPropertyChanged(new System.ComponentModel.PropertyChangedEventArgs(nameof(AccelerationForBinding)));
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
				OnPropertyChanged(new System.ComponentModel.PropertyChangedEventArgs(nameof(Damage)));
				OnPropertyChanged(new System.ComponentModel.PropertyChangedEventArgs(nameof(Toughness)));
				OnPropertyChanged(new System.ComponentModel.PropertyChangedEventArgs(nameof(Recovery)));
			}
		}

		int fTrifectaStacks;

		void AddTrifectaStacks(int diff)
		{
			Attack += 1.5 * diff;
			AttackSpeed += 1.5 * diff;
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
				OnPropertyChanged(new System.ComponentModel.PropertyChangedEventArgs(nameof(Damage)));
				OnPropertyChanged(new System.ComponentModel.PropertyChangedEventArgs(nameof(Toughness)));
				OnPropertyChanged(new System.ComponentModel.PropertyChangedEventArgs(nameof(Recovery)));
			}
		}

		private void DeactivateTrifectaPower()
		{
			Attack -= 1.5 * TrifectaStacks;
			AttackSpeed -= 1.5 * TrifectaStacks;
			Health -= 1.5 * TrifectaStacks;
			HealthArmor -= 1 * TrifectaStacks;
			Shields -= 1.5 * TrifectaStacks;
			ShieldsArmor -= 1 * TrifectaStacks;
		}

		private void ActivateTrifectaPower()
		{
			Attack += 1.5 * TrifectaStacks;
			AttackSpeed += 1.5 * TrifectaStacks;
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
				AdditiveArmor += Loadout.UnitConfiguration.EssenceStacks * 0.03 * (fDefensiveEssenceStacks - oldStacks);
			}
		}
		int fDefensiveEssenceStacks;

		#endregion

		#endregion

		#region StatsForBinding

		public double AttackForBinding => Math.Round(Attack, 2);
		public double AttackSpeedForBinding => Math.Round(AttackSpeed, 2);
		public double CriticalChanceForBinding => Math.Round(CriticalChance, 2);
		public double CriticalDamageForBinding => Math.Round(CriticalDamage, 2);
		public double HealthForBinding => Math.Round(Health, 2);
		public double HealthArmorForBinding => Math.Round(HealthArmor, 2);
		public double ShieldsForBinding => Math.Round(Shields, 2);
		public double ShieldsArmorForBinding => Math.Round(ShieldsArmor, 2);
		public double DamageReductionForBinding => Math.Round(TotalDamageReduction, 2);
		public double DamageIncreaseForBinding => Math.Round(DamageIncrease, 2);
		public double AccelerationForBinding => Math.Round(Acceleration, 2);

		public VLoadout Loadout { get; }

		#endregion
	}
}
