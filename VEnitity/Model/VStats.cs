using System;
using VEntityFramework.Data;

namespace VEntityFramework.Model
{
	public abstract class VStats : BusinessObject
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

		StatsDictionary AttackSpeedDictionary => fAttackSpeedDictionary ??= new StatsDictionary("AttackSpeed");
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
				if (value > fCriticalDamage + 200) 
				{ }
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
			get
			{
				var totalHealth = 100.0;
				foreach (var kvp in HealthDictionary)
				{
					totalHealth *= (100 + kvp.Value) / 100;
				}
				return totalHealth;
			}
		}

		StatsDictionary HealthDictionary => fHealthDictionary ??= new StatsDictionary("Health");
		StatsDictionary fHealthDictionary;

		public void UpdateHealth(string key, double amount)
		{
			HealthDictionary.Update(key, amount);
			OnPropertyChanged(nameof(HealthForBinding));
			OnPropertyChanged(nameof(Toughness));
			OnPropertyChanged(nameof(Recovery));
		}

		#endregion

		#region HealthArmor

		public double HealthArmor
		{
			get
			{
				var totalArmor = 100.0;
				foreach (var kvp in HealthArmorDictionary)
				{
					totalArmor *= (100 + kvp.Value) / 100;
				}
				return totalArmor;
			}
		}

		StatsDictionary HealthArmorDictionary => fHealthArmorDictionary ??= new StatsDictionary("HealthArmor");
		StatsDictionary fHealthArmorDictionary;

		public void UpdateHealthArmor(string key, double amount)
		{
			HealthArmorDictionary.Update(key, amount);
			OnPropertyChanged(nameof(HealthArmor));
			OnPropertyChanged(nameof(Toughness));
		}

		#endregion

		#region Shields

		public double Shields
		{
			get
			{
				var totalShields = 100.0;
				foreach (var kvp in ShieldsDictionary)
				{
					totalShields *= (100 + kvp.Value) / 100;
				}
				return totalShields;
			}
		}

		StatsDictionary ShieldsDictionary => fShieldsDictionary ??= new StatsDictionary("Shields");
		StatsDictionary fShieldsDictionary;

		public void UpdateShields(string key, double amount)
		{
			ShieldsDictionary.Update(key, amount);
			OnPropertyChanged(nameof(ShieldsForBinding));
			OnPropertyChanged(nameof(Toughness));
			OnPropertyChanged(nameof(Recovery));
		}

		#endregion

		#region ShieldsArmor

		public double ShieldsArmor
		{
			get
			{
				var totalArmor = 100.0;
				foreach (var kvp in ShieldsArmorDictionary)
				{
					totalArmor *= (100 + kvp.Value) / 100;
				}
				return totalArmor;
			}
		}

		StatsDictionary ShieldsArmorDictionary => fShieldsArmorDictionary ??= new StatsDictionary("ShieldsArmor");
		StatsDictionary fShieldsArmorDictionary;

		public void UpdateShieldsArmor(string key, double amount)
		{
			ShieldsArmorDictionary.Update(key, amount);
			OnPropertyChanged(nameof(ShieldsArmor));
			OnPropertyChanged(nameof(Toughness));
		}

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

		StatsDictionary DamageIncreaseDictionary => fDamageIncreaseDictionary ??= new StatsDictionary("DamageIncrease");
		StatsDictionary fDamageIncreaseDictionary;

		public void UpdateDamageIncrease(string key, double amount)
		{
			DamageIncreaseDictionary.Update(key, amount);
			OnPropertyChanged(nameof(Damage));
			OnPropertyChanged(nameof(DamageIncreaseForBinding));
		}

		#endregion

		#region DamageReduction

		public double DamageReduction
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

		StatsDictionary DamageReductionDictionary => fDamageReductionDictionary ??= new StatsDictionary("DamageReduction");
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

		#region Acceleration

		public double Acceleration
		{
			get
			{
				var Acceleration = 100.0;
				foreach (var kvp in AccelerationDictionary)
				{
					Acceleration = Acceleration * (100 + kvp.Value) / 100;
				}
				return Acceleration;
			}
		}

		StatsDictionary AccelerationDictionary => fAccelerationDictionary ??= new StatsDictionary("Acceleration");
		StatsDictionary fAccelerationDictionary;

		public void UpdateAcceleration(string key, double value, int? quantity = null)
		{
			if (!quantity.HasValue)
			{
				AccelerationDictionary.Update(key, value);
			}
			else if (quantity.Value != 0)
			{
				AccelerationDictionary.UpdateExpontiental(key, value, quantity.Value);
			}
			OnPropertyChanged(nameof(AccelerationForBinding));
			OnPropertyChanged(nameof(Damage));
		}

		#endregion

		public double MoveSpeed { get; set; } // it looks like the 2.4477% move speed per essence is stacked multiplicatively, so it is exponential, where the 10% move speed from essence is additive (linear) they are multiplied to get the result

		#region CooldownSpeed

		public double CooldownSpeed
		{
			get
			{
				var cooldownSpeed = 100.0;
				foreach (var kvp in CooldownSpeedDictionary)
				{
					cooldownSpeed = cooldownSpeed * (100 + kvp.Value) / 100;
				}
				cooldownSpeed = cooldownSpeed * Acceleration / 100;
				return cooldownSpeed;
			}
		}

		StatsDictionary CooldownSpeedDictionary => fCooldownSpeedDictionary ??= new StatsDictionary("CooldownSpeed");
		StatsDictionary fCooldownSpeedDictionary;

		public void UpdateCooldownSpeed(string key, double value, int? quantity = null)
		{
			if (!quantity.HasValue)
			{
				CooldownSpeedDictionary.Update(key, value);
			}
			else if (quantity.Value != 0)
			{
				CooldownSpeedDictionary.UpdateExpontiental(key, value, quantity.Value);
			}
			OnPropertyChanged(nameof(Damage));
			OnPropertyChanged(nameof(Toughness));
		}

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

		public double UnitAttack => CurrentUnit.Attack * Attack / 100;
		public double UnitAttackSpeed => CurrentUnit.AttackSpeed / (AttackSpeed * Acceleration) * 10000;
		public double UnitHealth => CurrentUnit.Health * Health / 100;
		public double UnitHealthArmor => CurrentUnit.HealthArmor * HealthArmor / 100 + AdditiveArmor;
		public double UnitShields => CurrentUnit.Shields * Shields / 100;
		public double UnitShieldsArmor => CurrentUnit.ShieldsArmor * ShieldsArmor / 100 + AdditiveArmor;

		#endregion

		#region PlayerStats

		double PlayerAttack => Attack;
		double PlayerAttackSpeed => AttackSpeed * Acceleration / 100;
		double PlayerHealth => Health;
		double PlayerHealthArmor => HealthArmor;
		double PlayerShields => Shields;
		double PlayerShieldsArmor => ShieldsArmor;

		#endregion

		#region StatsForBinding

		public double AttackForBinding => Math.Round(UseUnitStats ? UnitAttack : PlayerAttack, 2);
		public double AttackSpeedForBinding => Math.Round(UseUnitStats ? UnitAttackSpeed : PlayerAttackSpeed, 2);
		public double CriticalChanceForBinding => Math.Round(CriticalChance, 2);
		public double CriticalDamageForBinding => Math.Round(CriticalDamage, 2);
		public double HealthForBinding => Math.Round(UseUnitStats ? UnitHealth : PlayerHealth, 2);
		public double HealthArmorForBinding => Math.Round(UseUnitStats ? UnitHealthArmor : PlayerHealthArmor, 2);
		public double ShieldsForBinding => Math.Round(UseUnitStats ? UnitShields : PlayerShields, 2);
		public double ShieldsArmorForBinding => Math.Round(UseUnitStats ? UnitShieldsArmor : PlayerShieldsArmor, 2);
		public double DamageReductionForBinding => Math.Round(DamageReduction, 2);
		public double DamageIncreaseForBinding => Math.Round(DamageIncrease, 2);
		public double AccelerationForBinding => Math.Round(Acceleration, 2);

		#endregion

		public VLoadout Loadout { get; }

		public int MaximumPotientialStacks
		{
			get => fMaximumPotientialStacks;
			set {
				fMaximumPotientialStacks = value;
				RefreshPropertyBinding(nameof(MaximumPotientialStacks));
			}
		}
		int fMaximumPotientialStacks;

		public int LimitlessEssenceStacks
		{
			get => fLimitlessEssenceStacks;
			set {
				fLimitlessEssenceStacks = value;
				RefreshPropertyBinding(nameof(LimitlessEssenceStacks));
			}
		}
		int fLimitlessEssenceStacks;

		#region RefreshBindingSuspension

		protected override void OnPropertyChanged(string bindingName)
		{
			if (!ShouldPreventRefreshBinding())
			{
				base.OnPropertyChanged(bindingName);
			}
		}

		public IDisposable SuspendRefreshingStatBindings()
		{
			suspendRefreshBindingCounter++;

			return new DisposableAction(() =>
			{
				suspendRefreshBindingCounter--;
				RefreshAllBindings();
			});
		}

		int suspendRefreshBindingCounter;
		bool ShouldPreventRefreshBinding()
		{
			return suspendRefreshBindingCounter > 0;
		}

		#endregion
	}
}
