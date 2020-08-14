using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using VEntityFramework.Model;

namespace VBusiness.Souls
{
	public abstract class Soul : VSoul
	{
		#region Constructor

		public Soul()
		{
		}

		public static Soul New(SoulType type)
		{
			return type switch
			{
				(SoulType.None) => new EmptySoul(),
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
				(SoulType.Bronze) => new BronzeSoul(),
				(SoulType.Mirrors) => new MirrorsSoul(),
				(SoulType.Hunter) => new HunterSoul(),
				(SoulType.Silver) => new SilverSoul(),
				(SoulType.Reflection) => new ReflectionSoul(),
				(SoulType.Veterancy) => new VeterancySoul(),
				(SoulType.Urusy) => new UrusySoul(),
				(SoulType.Scavenger) => new ScavengerSoul(),
				(SoulType.Hunger) => new HungerSoul(),
				(SoulType.Luck) => new LuckSoul(),
				(SoulType.Greed) => new GreedSoul(),
				(SoulType.Sharing) => new SharingSoul(),
				(SoulType.Convenience) => new ConvenienceSoul(),
				(SoulType.Promotion) => new PromotionSoul(),
				(SoulType.Status) => new StatusSoul(),
				(SoulType.Predestination) => new PredestinationSoul(),
				(SoulType.RapidMutation) => new RapidMutationSoul(),
				(SoulType.Sales) => new SalesSoul(),
				(SoulType.GlowingDetermination) => new GlowingDeterminationSoul(),
				(SoulType.WellAmplification) => new WellAmplificationSoul(),
				(SoulType.AccelleratedAdvancement) => new AccelleratedAdvancementSoul(),
				(SoulType.GhostForce) => new GhostForceSoul(),
				(SoulType.Training) => new TrainingSoul(),
				(SoulType.PowerWarping) => new PowerWarpingSoul(),
				(SoulType.Demolition) => new DemolitionSoul(),
				(SoulType.Tanking) => new TankingSoul(),
				(SoulType.Unchained) => new UnchainedSoul(),
				(SoulType.Draining) => new DrainingSoul(),
				(SoulType.Alacrity) => new AlacritySoul(),
				(SoulType.Stats) => new StatsSoul(),
				(SoulType.StridingTitan) => new StridingTitanSoul(),
				(SoulType.UnboundReflection) => new UnboundReflectionSoul(),
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

		#region IsUnique

		protected override bool IsUnique
		{
			get
			{
				return Type != Rarity;
			}
		}

		#endregion

		#region SaveSlot

		public override int SaveSlot
		{
			get => base.SaveSlot;
			set
			{
				if (base.SaveSlot != value && !SuspendSettingHasChanges)
				{
					saveSlotHasChanges = true;
				}
				base.SaveSlot = value;
				OnPropertyChanged(new System.ComponentModel.PropertyChangedEventArgs(nameof(SaveSlot)));
			}
		}

		#endregion

		#endregion

		#region Stats

		public override Action<VStats> ActivateStats
		{
			get
			{
				return (stats) =>
				{
					stats.Attack += Attack;
					stats.AttackSpeed += AttackSpeed;
					stats.HealthArmor += Armor;
					stats.ShieldsArmor += Armor;
					stats.Health += Vitals;
					stats.Shields += Vitals;
					stats.CriticalChance += CriticalChance;
					stats.CriticalDamage += CriticalDamage;
				};
			}
		}

		public override Action<VStats> DeactivateStats
		{
			get
			{
				return (stats) =>
				{
					stats.Attack -= Attack;
					stats.AttackSpeed -= AttackSpeed;
					stats.HealthArmor -= Armor;
					stats.ShieldsArmor -= Armor;
					stats.Health -= Vitals;
					stats.Shields -= Vitals;
					stats.CriticalChance -= CriticalChance;
					stats.CriticalDamage -= CriticalDamage;
				};
			}
		}

		#endregion

		#region Set Default Values

		protected override void SetDefaultValues()
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

		#region Validation

		protected override void RunPreSaveValidationCore()
		{
			base.RunPreSaveValidationCore();

			CheckIfDuplicateSaveSlotAndPromptOverride();
			CheckValidSoulSlot();
		}

		void CheckValidSoulSlot()
		{
			if (SaveSlot <= 0)
			{
				Notifications.AddError("Use a valid save slot");
			}
		}

		void CheckIfDuplicateSaveSlotAndPromptOverride()
		{
			if (CheckIfDuplicateSaveSlot())
			{
				Notifications.AddPrompt("There is already a soul saved in this soul slot. Would you like to override it?");
			}
		}

		bool CheckIfDuplicateSaveSlot()
		{
			var usedSoulSlots = Context.GetAllSoulNames().Select(name => int.Parse(name.Split('-')[0]));
			var hasSoulInSpot = usedSoulSlots.Contains(SaveSlot);
			return hasSoulInSpot && (!ExistsInXML || saveSlotHasChanges);
		}

		#endregion

		#region Implementation

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

		public override string GetSaveNameForXML() => $"{SaveSlot}-{UniqueName}";

		protected override void OnSaving()
		{
			DeleteSoulsInSaveSlot();
		}

		void DeleteSoulsInSaveSlot()
		{
			var soulsNamesToDelete = Context.GetAllSoulNames().Where(name => int.Parse(name.Split('-')[0]) == SaveSlot);
			foreach (var name in soulsNamesToDelete)
			{
				Context.ReadFromXML<Soul>(name).Delete();
			}
		}

		protected override void OnSaved()
		{
			base.OnSaved();
			saveSlotHasChanges = false;
		}

		bool saveSlotHasChanges;

		#endregion
	}
}
