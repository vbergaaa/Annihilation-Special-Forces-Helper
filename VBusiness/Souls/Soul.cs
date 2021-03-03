using EnumsNET;
using System;
using System.Linq;
using VEntityFramework;
using VEntityFramework.Model;

namespace VBusiness.Souls
{
	public abstract class Soul : VSoul
	{
		#region Constructor

		public Soul(VLoadoutSouls collection) : base(collection)
		{
		}

		public static Soul New(SoulType type, VLoadoutSouls collection)
		{
			if (type == SoulType.None)
			{
				return new EmptySoul();
			}
			var soulName = type.AsString(EnumFormat.Name) + "Soul";
			var soulType = System.Type.GetType($"VBusiness.Souls.{soulName}");

			if (soulType == null)
			{
				ErrorReporter.ReportDebug($"Please create a class named VBusiness.Souls.{soulName}");
				return new EmptySoul();
			}

			var soul = (Soul)Activator.CreateInstance(soulType, collection);
			return soul;
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
						OnPropertyChanged(nameof(Attack));
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
						OnPropertyChanged(nameof(AttackSpeed));
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
						OnPropertyChanged(nameof(CriticalChance));
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
						OnPropertyChanged(nameof(CriticalDamage));
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
						OnPropertyChanged(nameof(Armor));
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
						OnPropertyChanged(nameof(Vitals));
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
						OnPropertyChanged(nameof(Kills));
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
						OnPropertyChanged(nameof(Minerals));
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
				OnPropertyChanged(nameof(SaveSlot));
			}
		}

#endregion

#endregion

#region Stats

		protected override void ActivateSoulCore()
		{
			if (Parent?.Loadout?.Stats != null)
			{
				Loadout.Stats.Attack += Attack;
				Loadout.Stats.UpdateAttackSpeed("Core", AttackSpeed);
				Loadout.Stats.HealthArmor += Armor;
				Loadout.Stats.ShieldsArmor += Armor;
				Loadout.Stats.Health += Vitals;
				Loadout.Stats.Shields += Vitals;
				Loadout.Stats.CriticalChance += CriticalChance;
				Loadout.Stats.CriticalDamage += CriticalDamage;
			}
		}

		protected override void DeactivateSoulCore()
		{
			Loadout.Stats.Attack -= Attack;
			Loadout.Stats.UpdateAttackSpeed("Core", -AttackSpeed);
			Loadout.Stats.HealthArmor -= Armor;
			Loadout.Stats.ShieldsArmor -= Armor;
			Loadout.Stats.Health -= Vitals;
			Loadout.Stats.Shields -= Vitals;
			Loadout.Stats.CriticalChance -= CriticalChance;
			Loadout.Stats.CriticalDamage -= CriticalDamage;
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
			var usedSoulSlots = Context.GetAllFileNames<Soul>().Select(name => int.Parse(name.Split('-')[0]));
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
			var soulsNamesToDelete = Context.GetAllFileNames<Soul>().Where(name => int.Parse(name.Split('-')[0]) == SaveSlot);
			foreach (var name in soulsNamesToDelete)
			{
				Context.Delete<Soul>(name);
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