using VEntityFramework.Attributes;
using VEntityFramework.Data;

namespace VEntityFramework.Model
{
	[TopLevelBusinessObject("Souls")]
	public abstract class VSoul : VBusinessObject
	{
		#region	Constructors

		public VSoul(VSoulCollection soulCollection) : base(soulCollection)
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
					HasChanges = true;
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
		public abstract int MaxAttack { get; }
		public abstract int MinAttack { get; }

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
		public abstract int MaxAttackSpeed { get; }
		public abstract int MinAttackSpeed { get; }

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
		public abstract int MaxCriticalChance { get; }
		public abstract int MinCriticalChance { get; }

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
		public abstract int MaxCriticalDamage { get; }
		public abstract int MinCriticalDamage { get; }

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
		public abstract int MaxVitals { get; }
		public abstract int MinVitals { get; }

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
		public abstract int MaxArmor { get; }
		public abstract int MinArmor { get; }

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
		public abstract int MaxMinerals { get; }
		public abstract int MinMinerals { get; }

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
		public abstract int MaxKills { get; }
		public abstract int MinKills { get; }

		#endregion

		#region IsMin / IsMin

		public abstract bool IsMax(string property);
		public abstract bool IsMin(string property);

		#endregion

		#region IsUnique

		protected virtual bool IsUnique { get; }

		#endregion

		#region Cost

		public abstract int Cost { get; }

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
