using EnumsNET;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using VEntityFramework.Data;
using VEntityFramework.DataContext;

namespace VEntityFramework.Model
{
	public abstract class VUnit : VBusinessObject
	{
		public VUnit(VLoadout loadout) : base(loadout)
		{
			if (!loadout.Units.Contains(this))
			{
				loadout.Units.Add(this);
				HasChanges = !loadout.IsLoading;
			}
		}

		#region New

		public static VUnit New(UnitType type, VLoadout loadout)
		{
			if (type != UnitType.None)
			{
				return (VUnit)BizoCreator.Create(typeof(VUnit), type.ToString(), loadout);
			}
			return (VUnit)BizoCreator.Create(typeof(VUnit), "EmptyUnit", loadout);
		}

		#endregion

		#region Properties

		#region Loadout

		[VXML(false)]
		public VLoadout Loadout => (VLoadout)Parent;

		#endregion

		#region Type

		public abstract UnitType Type { get; }

		#endregion

		#region IsCurrentUnit

		public bool IsCurrentUnit => this == Loadout.CurrentUnit;

		#endregion

		#region Infusion

		[VXML(true)]
		public virtual int CurrentInfusion
		{
			get => fCurrentInfuse;
			set
			{
				if (value != fCurrentInfuse)
				{
					fCurrentInfuse = value;
					HasChanges = true;
					OnDescriptionChanged();
					OnPropertyChanged(nameof(CurrentInfusion));
				}
			}
		}
		int fCurrentInfuse;

		#endregion

		#region MaximumKills

		public virtual int MaximumKills { get; }

		#endregion

		#region Rank

		[VXML(false)]
		public VUnitRank Rank
		{
			get => fRank;
			protected set
			{
				DeactivateRank(fRank);
				fRank = value;
				ActivateRank(fRank);
				HasChanges = true;
				OnDescriptionChanged();
			}
		}
		VUnitRank fRank;

		#region ActivateRank

		void ActivateRank(VUnitRank rank)
		{
			if (rank != null && Loadout != null)
			{
				rank.ActivateRank();
			}
		}

		#endregion

		#region DeactivateRank

		void DeactivateRank(VUnitRank rank)
		{
			if (rank != null && Loadout != null)
			{
				rank.DeactivateRank();
			}
		}

		#endregion

		#endregion

		#region UnitRank

		[VXML(true)]
		public virtual UnitRank UnitRank
		{
			get => fUnitRank;
			set
			{
				if (fUnitRank != value)
				{
					fUnitRank = value;
					HasChanges = true;
				}
			}
		}
		UnitRank fUnitRank;

		#endregion

		#region MaximumEssence

		public virtual int MaximumInfusion { get; }

		#endregion

		#region CurrentEssence

		[VXML(true)]
		public virtual int EssenceStacks
		{
			get => fCurrentEssence;
			set
			{
				if (value != fCurrentEssence)
				{
					fCurrentEssence = value;
					HasChanges = true;
					OnPropertyChanged(nameof(EssenceStacks));
				}
			}
		}
		int fCurrentEssence;

		#endregion

		#region MaximumEssence

		public virtual int MaximumEssence { get; }

		#endregion

		#region HasUnitSpec

		[VXML(true)]
		public virtual bool HasUnitSpec
		{
			get => fHasUnitSpec;
			set
			{
				if (fHasUnitSpec != value)
				{
					fHasUnitSpec = value;
					HasChanges = true;
					OnPropertyChanged(nameof(HasUnitSpec));
				}
			}
		}
		bool fHasUnitSpec;

		#endregion

		#region Stats

		#region Calculated Stats

		public abstract double Attack { get; }
		public abstract double AttackSpeed { get; }
		public abstract double Health { get; }
		public abstract double HealthArmor { get; }
		public abstract double HealthRegen { get; }
		public abstract double Shields { get; }
		public abstract double ShieldsArmor { get; }
		public abstract double ShieldsRegen { get; }

		#endregion

		#region Base Stats

		public abstract double AttackCount { get; }
		protected abstract double BaseAttack { get; }
		protected abstract double BaseAttackSpeed { get; }
		protected abstract double BaseHealth { get; }
		protected abstract double BaseHealthArmor { get; }
		protected abstract double BaseHealthRegen { get; }
		protected abstract double BaseShields { get; }
		protected abstract double BaseShieldsArmor { get; }
		protected abstract double BaseShieldsRegen { get; }

		#endregion

		#endregion

		#region Upgrade Increments

		protected abstract double AttackIncrement { get; }
		protected abstract double HealthIncrement { get; }
		protected abstract double HealthRegenIncrement { get; }
		protected abstract double HealthArmorIncrement { get; }
		protected abstract double ShieldIncrement { get; }
		protected abstract double ShieldRegenIncrement { get; }
		protected abstract double ShieldArmorIncrement { get; }

		#endregion

		#endregion

		public event EventHandler DescriptionChanged;
		void OnDescriptionChanged()
		{
			DescriptionChanged?.Invoke(this, new EventArgs());
		}

		#region Implementation

		public override string BizoName => "Unit";

		[VXML(true)]
		public string Key => this.GetType().Name;

		public override string ToString()
		{
			return GetDescription();
		}

		string GetDescription()
		{
			var number = "";
			if (Loadout != null)
			{
				var matchingUnits = Loadout.Units.Where(u => u.Type == Type && u.UnitRank == UnitRank && u.CurrentInfusion == CurrentInfusion).ToList();
				if (matchingUnits.Count > 1)
				{
					number = $"({matchingUnits.IndexOf(this) + 1})";
				}
			}
			var rank = UnitRank == UnitRank.None ? "" : UnitRank.ToString();
			return $"+{CurrentInfusion} {rank} {Type.AsString(EnumFormat.Description, EnumFormat.Name)} {number}";
		}

		#endregion
	}
}
