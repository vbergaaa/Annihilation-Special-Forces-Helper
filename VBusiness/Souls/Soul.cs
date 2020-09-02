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

		public Soul(VSoulCollection collection) : base(collection)
		{
		}

		public static Soul New(SoulType type, VSoulCollection collection)
		{
			return type switch
			{
				SoulType.None => new EmptySoul(),
				SoulType.Lowest => new LowestSoul(collection),
				SoulType.Lower => new LowerSoul(collection),
				SoulType.Low => new LowSoul(collection),
				SoulType.Mid => new MidSoul(collection),
				SoulType.High => new HighSoul(collection),
				SoulType.Higher => new HigherSoul(collection),
				SoulType.Highest => new HighestSoul(collection),
				SoulType.Night => new NightSoul(collection),
				SoulType.Tormented => new TormentedSoul(collection),
				SoulType.Demonic => new DemonicSoul(collection),
				SoulType.Titan => new TitanSoul(collection),
				SoulType.Bronze => new BronzeSoul(collection),
				SoulType.Mirrors => new MirrorsSoul(collection),
				SoulType.Hunter => new HunterSoul(collection),
				SoulType.Silver => new SilverSoul(collection),
				SoulType.Reflection => new ReflectionSoul(collection),
				SoulType.Veterancy => new VeterancySoul(collection),
				SoulType.Urusy => new UrusySoul(collection),
				SoulType.Scavenger => new ScavengerSoul(collection),
				SoulType.Hunger => new HungerSoul(collection),
				SoulType.Luck => new LuckSoul(collection),
				SoulType.Greed => new GreedSoul(collection),
				SoulType.Sharing => new SharingSoul(collection),
				SoulType.Convenience => new ConvenienceSoul(collection),
				SoulType.Promotion => new PromotionSoul(collection),
				SoulType.Status => new StatusSoul(collection),
				SoulType.Predestination => new PredestinationSoul(collection),
				SoulType.RapidMutation => new RapidMutationSoul(collection),
				SoulType.Sales => new SalesSoul(collection),
				SoulType.GlowingDetermination => new GlowingDeterminationSoul(collection),
				SoulType.WellAmplification => new WellAmplificationSoul(collection),
				SoulType.AccelleratedAdvancement => new AccelleratedAdvancementSoul(collection),
				SoulType.GhostForce => new GhostForceSoul(collection),
				SoulType.Training => new TrainingSoul(collection),
				SoulType.PowerWarping => new PowerWarpingSoul(collection),
				SoulType.Demolition => new DemolitionSoul(collection),
				SoulType.Tanking => new TankingSoul(collection),
				SoulType.Unchained => new UnchainedSoul(collection),
				SoulType.Draining => new DrainingSoul(collection),
				SoulType.Alacrity => new AlacritySoul(collection),
				SoulType.Stats => new StatsSoul(collection),
				SoulType.StridingTitan => new StridingTitanSoul(collection),
				SoulType.UnboundReflection => new UnboundReflectionSoul(collection),
				SoulType.Accelleration => new AccellerationSoul(collection),
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
				if (base.SaveSlot != value && !IsSettingHasChangesSuspended)
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

		protected override void ActivateSoulCore()
		{
			if (SoulCollection?.Loadout?.Stats != null)
			{
				SoulCollection.Loadout.Stats.Attack += Attack;
				SoulCollection.Loadout.Stats.AttackSpeed += AttackSpeed;
				SoulCollection.Loadout.Stats.HealthArmor += Armor;
				SoulCollection.Loadout.Stats.ShieldsArmor += Armor;
				SoulCollection.Loadout.Stats.Health += Vitals;
				SoulCollection.Loadout.Stats.Shields += Vitals;
				SoulCollection.Loadout.Stats.CriticalChance += CriticalChance;
				SoulCollection.Loadout.Stats.CriticalDamage += CriticalDamage;
			}
		}

		protected override void DeactivateSoulCore()
		{
			SoulCollection.Loadout.Stats.Attack -= Attack;
			SoulCollection.Loadout.Stats.AttackSpeed -= AttackSpeed;
			SoulCollection.Loadout.Stats.HealthArmor -= Armor;
			SoulCollection.Loadout.Stats.ShieldsArmor -= Armor;
			SoulCollection.Loadout.Stats.Health -= Vitals;
			SoulCollection.Loadout.Stats.Shields -= Vitals;
			SoulCollection.Loadout.Stats.CriticalChance -= CriticalChance;
			SoulCollection.Loadout.Stats.CriticalDamage -= CriticalDamage;
		}

		#endregion

		#region Set Default Values

		protected override void SetDefaultValuesCore()
		{
			using (SuspendSettingHasChanges())
			{
				Attack = MinAttack;
				AttackSpeed = MinAttackSpeed;
				Vitals = MinVitals;
				Armor = MinArmor;
				CriticalChance = MinCriticalChance;
				CriticalDamage = MinCriticalDamage;
				Kills = MinKills;
				Minerals = MinMinerals;
			}
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

		protected override string GetSaveNameForXML() => $"{SaveSlot}-{UniqueName}";

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
