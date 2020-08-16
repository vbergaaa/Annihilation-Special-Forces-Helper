using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Text;
using VEntityFramework.Data;

namespace VEntityFramework.Model
{
	public abstract class VSoul : VBusinessObject
	{
		#region	Constructors

		public VSoul(VSoulCollection soulCollection)
		{
			SoulCollection = soulCollection;
		}

		#endregion

		#region Properties

		#region SoulCollection

		[VXML(false)]
		public VSoulCollection SoulCollection { get; set; }

		#endregion

		#region SaveSlot

		[VXML(true)]
		public virtual int SaveSlot
		{
			get => fSaveSlot;
			set
			{
				if (fSaveSlot != value)
				{
					if (!SuspendSettingHasChanges)
					{
						HasChanges = true;
					}
					fSaveSlot = value;
				}
			}
		}
		int fSaveSlot;

		#endregion

		#region Type

		[VXML(true)]
		public abstract SoulType Type { get; }

		#endregion

		#region Rarity

		protected abstract SoulType Rarity { get; }

		#endregion

		#region Attack

		[VXML(true)]
		public virtual int Attack
		{
			get => fAttack;
			set
			{
				if (fAttack != value)
				{
					fAttack = value;
					HasChanges = true;
				}
			}
		}
		int fAttack;
		protected abstract int MaxAttack { get; }
		protected abstract int MinAttack { get; }

		#endregion

		#region AttackSpeed

		[VXML(true)]
		public virtual int AttackSpeed
		{
			get => fAttackSpeed;
			set
			{
				if (fAttackSpeed != value)
				{
					fAttackSpeed = value;
					HasChanges = true;
				}
			}
		}
		int fAttackSpeed;
		protected abstract int MaxAttackSpeed { get; }
		protected abstract int MinAttackSpeed { get; }

		#endregion

		#region CriticalChance

		[VXML(true)]
		public virtual int CriticalChance
		{
			get => fCriticalChance;
			set
			{
				if (fCriticalChance != value)
				{
					fCriticalChance = value;
					HasChanges = true;
				}
			}
		}
		int fCriticalChance;
		protected abstract int MaxCriticalChance { get; }
		protected abstract int MinCriticalChance { get; }

		#endregion

		#region CriticalDamage

		[VXML(true)]
		public virtual int CriticalDamage
		{
			get => fCriticalDamage;
			set
			{
				if (fCriticalDamage != value)
				{
					fCriticalDamage = value;
					HasChanges = true;
				}
			}
		}
		int fCriticalDamage;
		protected abstract int MaxCriticalDamage { get; }
		protected abstract int MinCriticalDamage { get; }

		#endregion

		#region Vitals

		[VXML(true)]
		public virtual int Vitals
		{
			get => fVitals;
			set
			{
				if (fVitals != value)
				{
					fVitals = value;
					HasChanges = true;
				}
			}
		}
		int fVitals;
		protected abstract int MaxVitals { get; }
		protected abstract int MinVitals { get; }

		#endregion

		#region Armor

		[VXML(true)]
		public virtual int Armor
		{
			get => fArmor;
			set
			{
				if (fArmor != value)
				{
					fArmor = value;
					HasChanges = true;
				}
			}
		}
		int fArmor;
		protected abstract int MaxArmor { get; }
		protected abstract int MinArmor { get; }

		#endregion

		#region Minerals

		[VXML(true)]
		public virtual int Minerals
		{
			get => fMinerals;
			set
			{
				if (fMinerals != value)
				{
					fMinerals = value;
					HasChanges = true;
				}
			}
		}
		int fMinerals;
		protected abstract int MaxMinerals { get; }
		protected abstract int MinMinerals { get; }

		#endregion

		#region Kills

		[VXML(true)]
		public virtual int Kills
		{
			get => fKills;
			set
			{
				if (fKills != value)
				{
					fKills = value;
					HasChanges = true;
				}
			}
		}
		int fKills;
		protected abstract int MaxKills { get; }
		protected abstract int MinKills { get; }

		#endregion

		#region IsMin / IsMin

		public abstract bool IsMax(string property);
		public abstract bool IsMin(string property);

		#endregion

		#region IsUnique

		protected virtual bool IsUnique { get; }

		#endregion

		#region UniqueName

		public string UniqueName => IsUnique ? $"{Rarity} Soul of {Type.GetDescription()}" : $"Regular {Rarity} Soul";

		#endregion

		#endregion

		#region Activate / Deactivate

		public void ActivateSoul()
		{
			if (SoulCollection?.Loadout?.Stats != null)
			{
				ActivateSoulCore();
			}
		}

		protected virtual void ActivateSoulCore() { }

		public void DeactivateSoul()
		{
			if (SoulCollection?.Loadout?.Stats != null)
			{
				DeactivateSoulCore();
			}
		}

		protected virtual void DeactivateSoulCore() { } 

		#endregion

		#region Implementation

		public override string BizoName => "Soul";

		#endregion
	}
}
