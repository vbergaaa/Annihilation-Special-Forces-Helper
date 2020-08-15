using System;
using VEntityFramework.Data;

namespace VEntityFramework.Model
{
	public abstract class VStats : VBusinessObject
	{
		public override string BizoName => "Stats";

		#region Calculated Stats;

		public double Damage
		{
			get
			{
				var regAtkChance = fCriticalChance > 100 ? 0 : 1 - fCriticalChance / 100;
				var redCritChance = HasRedCrits ? fCriticalChance / 200 : 0;
				var critChance = 1 - regAtkChance - redCritChance;

				var coreDamage = (regAtkChance * fAttack) + (critChance * (fAttack + fCriticalDamage)) + (redCritChance * (fAttack + 2 * fCriticalDamage));
				var damage = coreDamage * (1 + DamageIncrease / 100);
				return Math.Round(damage * fAttackSpeed / 100, 2);
			}
		}

		public double Toughness
		{
			get
			{
				/// This calculation assumes a unit with 100 base health, 50 base shields, and 5 base armor
				/// We then calculate how much damage is required to kill it in 100 attacks
				/// This is then normalised to a score out of 100

				var healthArmor = fHealthArmor / 20;
				var health = fHealth;
				var shieldsArmor = fShieldsArmor / 20;
				var shields = fShields / 100 * 50;

				/// To get result I solved the following for X,
				/// 
				/// H / (x - Ah) + S / (x - As) = 100
				/// 
				/// where
				/// H = amount of Health
				/// S = amount of Shields
				/// Ah = Health Armor
				/// As = Shield Armor
				/// 100 = amount of hits required to kill our unit

				var a = Math.Pow(100 * (shieldsArmor - healthArmor), 2)
					+ Math.Pow(shields + health, 2)
					+ (shields - health) * shieldsArmor * 200
					+ (health - shields) * healthArmor * 200;
				var b = Math.Sqrt(a) + 100 * shieldsArmor + 100 * healthArmor + shields + health;
				var totalDamageRequiredToKillUnit = b / 2;
				var totalToughness = totalDamageRequiredToKillUnit / (1 - fDamageReduction / 100);
				var normalisedToughness = totalToughness / 650 * 100;
				return Math.Round(normalisedToughness, 2);
			}
		}
		public double Recovery { get => fHealth; }

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

		#region DamageReduction

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

		public double DamageReduction
		{
			get => fDamageReduction;
			set
			{
				fDamageReduction = value;
				OnPropertyChanged(new System.ComponentModel.PropertyChangedEventArgs(nameof(DamageReduction)));
				OnPropertyChanged(new System.ComponentModel.PropertyChangedEventArgs(nameof(Toughness)));
				OnPropertyChanged(new System.ComponentModel.PropertyChangedEventArgs(nameof(Recovery)));
			}
		}
		double fDamageReduction;

		#endregion

		#region RedCrits

		public bool HasRedCrits {
			get => fHasRedCrits;
			set
			{
				fHasRedCrits = value;
				OnPropertyChanged(new System.ComponentModel.PropertyChangedEventArgs(nameof(Damage)));
			}
		}
		bool fHasRedCrits;

		#endregion

		public double MoveSpeed { get; set; }

		public double CooldownReduction { get; set; }

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
		public double DamageReductionForBinding => Math.Round(DamageReduction, 2);
		public double DamageIncreaseForBinding => Math.Round(DamageIncrease, 2);

		#endregion
	}
}
