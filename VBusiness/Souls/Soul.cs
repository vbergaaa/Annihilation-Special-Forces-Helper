﻿using System;
using System.Collections.Generic;
using System.Text;
using VEntityFramework.Model;

namespace VBusiness.Souls
{
	public abstract class Soul : VSoul
	{
		#region Constructor

		public Soul()
		{
			SetDefaultValues();
		}

		public static Soul New(SoulType type)
		{
			return type switch
			{
				(SoulType.None) => null,
				(SoulType.Lowest) => new LowestSoul(),
				(SoulType.Lower) => new LowerSoul(),
				(SoulType.Low) => new LowSoul(),
				(SoulType.Mid) => new MidSoul(),
				(SoulType.High) => new HighSoul(),
				(SoulType.Higher) => new HigherSoul(),
				(SoulType.Highest) => new HighestSoul(),
				(SoulType.Night) => new NightSoul(),
				(SoulType.Tormented) => new TormentedSoul(),
				(SoulType.Demonic) => new DemonicSoul(),
				(SoulType.Titan) => new TitanSoul(),
				_ => throw new Exception($"Soul Type: {type} has not been properly configured"),
			};
		}

		#endregion

		#region Properties

		#region Attack

		public override int Attack
		{
			get => base.Attack;
			set
			{
				if (base.Attack != value)
				{
					var oldvalue = base.Attack;
					if (value >= MaxAttack)
					{
						base.Attack = MaxAttack;
					}
					else if (value <= MinAttack)
					{
						base.Attack = MinAttack;
					}
					else
					{
						base.Attack = value;
					}

					if (oldvalue != base.Attack)
					{
						OnPropertyChanged(new System.ComponentModel.PropertyChangedEventArgs(nameof(Attack)));
					}
				}
			}
		}

		#endregion

		#region AttackSpeed

		public override int AttackSpeed
		{
			get => base.AttackSpeed;
			set
			{
				if (base.AttackSpeed != value)
				{
					var oldvalue = base.AttackSpeed;
					if (value >= MaxAttackSpeed)
					{
						base.AttackSpeed = MaxAttackSpeed;
					}
					else if (value <= MinAttackSpeed)
					{
						base.AttackSpeed = MinAttackSpeed;
					}
					else
					{
						base.AttackSpeed = value;
					}

					if (oldvalue != base.AttackSpeed)
					{
						OnPropertyChanged(new System.ComponentModel.PropertyChangedEventArgs(nameof(AttackSpeed)));
					}
				}
			}
		}

		#endregion

		#region CriticalChance

		public override int CriticalChance
		{
			get => base.CriticalChance;
			set
			{
				if (base.CriticalChance != value)
				{
					var oldvalue = base.CriticalChance;
					if (value >= MaxCriticalChance)
					{
						base.CriticalChance = MaxCriticalChance;
					}
					else if (value <= MinCriticalChance)
					{
						base.CriticalChance = MinCriticalChance;
					}
					else
					{
						base.CriticalChance = value;
					}

					if (oldvalue != base.CriticalChance)
					{
						OnPropertyChanged(new System.ComponentModel.PropertyChangedEventArgs(nameof(CriticalChance)));
					}
				}
			}
		}

		#endregion

		#region CriticalDamage

		public override int CriticalDamage
		{
			get => base.CriticalDamage;
			set
			{
				if (base.CriticalDamage != value)
				{
					var oldvalue = base.CriticalDamage;
					if (value >= MaxCriticalDamage)
					{
						base.CriticalDamage = MaxCriticalDamage;
					}
					else if (value <= MinCriticalDamage)
					{
						base.CriticalDamage = MinCriticalDamage;
					}
					else
					{
						base.CriticalDamage = value;
					}

					if (oldvalue != base.CriticalDamage)
					{
						OnPropertyChanged(new System.ComponentModel.PropertyChangedEventArgs(nameof(CriticalDamage)));
					}
				}
			}
		}

		#endregion

		#region Armor

		public override int Armor
		{
			get => base.Armor;
			set
			{
				if (base.Armor != value)
				{
					var oldvalue = base.Armor;
					if (value >= MaxArmor)
					{
						base.Armor = MaxArmor;
					}
					else if (value <= MinArmor)
					{
						base.Armor = MinArmor;
					}
					else
					{
						base.Armor = value;
					}

					if (oldvalue != base.Armor)
					{
						OnPropertyChanged(new System.ComponentModel.PropertyChangedEventArgs(nameof(Armor)));
					}
				}
			}
		}

		#endregion

		#region Vitals

		public override int Vitals
		{
			get => base.Vitals;
			set
			{
				if (base.Vitals != value)
				{
					var oldvalue = base.Vitals;
					if (value >= MaxVitals)
					{
						base.Vitals = MaxVitals;
					}
					else if (value <= MinVitals)
					{
						base.Vitals = MinVitals;
					}
					else
					{
						base.Vitals = value;
					}

					if (oldvalue != base.Vitals)
					{
						OnPropertyChanged(new System.ComponentModel.PropertyChangedEventArgs(nameof(Vitals)));
					}
				}
			}
		}

		#endregion

		#region Kills

		public override int Kills
		{
			get => base.Kills;
			set
			{
				if (base.Kills != value)
				{
					var oldvalue = base.Kills;
					if (value >= MaxKills)
					{
						base.Kills = MaxKills;
					}
					else if (value <= MinKills)
					{
						base.Kills = MinKills;
					}
					else
					{
						base.Kills = value;
					}

					if (oldvalue != base.Kills)
					{
						OnPropertyChanged(new System.ComponentModel.PropertyChangedEventArgs(nameof(Kills)));
					}
				}
			}
		}

		#endregion

		#region Minerals

		public override int Minerals
		{
			get => base.Minerals;
			set
			{
				if (base.Minerals != value)
				{
					var oldvalue = base.Minerals;
					if (value >= MaxMinerals)
					{
						base.Minerals = MaxMinerals;
					}
					else if (value <= MinMinerals)
					{
						base.Minerals = MinMinerals;
					}
					else
					{
						base.Minerals = value;
					}

					if (oldvalue != base.Minerals)
					{
						OnPropertyChanged(new System.ComponentModel.PropertyChangedEventArgs(nameof(Minerals)));
					}
				}
			}
		}

		#endregion

		#endregion

		#region Set Default Values

		void SetDefaultValues()
		{
			SuspendSettingHasChanges = true;
			Attack = MinAttack;
			AttackSpeed = MinAttackSpeed;
			Vitals = MinVitals;
			Armor = MinArmor;
			CriticalChance = MinCriticalChance;
			CriticalDamage = MinCriticalDamage;
			Kills = MinKills;
			Minerals = MinMinerals;
			SuspendSettingHasChanges = false;
		}
		#endregion

		#region overrides

		public override bool IsMax(string property)
		{
			return property switch
			{
				(nameof(Attack)) => Attack == MaxAttack,
				(nameof(AttackSpeed)) => AttackSpeed == MaxAttackSpeed,
				(nameof(Vitals)) => Vitals == MaxVitals,
				(nameof(Armor)) => Armor == MaxArmor,
				(nameof(CriticalChance)) => CriticalChance == MaxCriticalChance,
				(nameof(CriticalDamage)) => CriticalDamage == MaxCriticalDamage,
				(nameof(Kills)) => Kills == MaxKills,
				(nameof(Minerals)) => Minerals == MaxMinerals,
				_ => throw new Exception($"Invalid Property Name: {property}. Soul.IsMax()"),
			};
		}

		public override bool IsMin(string property)
		{
			return property switch
			{
				(nameof(Attack)) => Attack == MinAttack,
				(nameof(AttackSpeed)) => AttackSpeed == MinAttackSpeed,
				(nameof(Vitals)) => Vitals == MinVitals,
				(nameof(Armor)) => Armor == MinArmor,
				(nameof(CriticalChance)) => CriticalChance == MinCriticalChance,
				(nameof(CriticalDamage)) => CriticalDamage == MinCriticalDamage,
				(nameof(Kills)) => Kills == MinKills,
				(nameof(Minerals)) => Minerals == MinMinerals,
				_ => throw new Exception($"Invalid Property Name: {property}. Soul.IsMin()"),
			};
		}

		#endregion
	}
}
