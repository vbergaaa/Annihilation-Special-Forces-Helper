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
					OnPropertyChanged(new System.ComponentModel.PropertyChangedEventArgs(nameof(CurrentInfusion)));
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
					OnPropertyChanged(new System.ComponentModel.PropertyChangedEventArgs(nameof(EssenceStacks)));
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
					OnPropertyChanged(new System.ComponentModel.PropertyChangedEventArgs(nameof(HasUnitSpec)));
				}
			}
		}
		bool fHasUnitSpec;

		#endregion

		#region Stats

		public abstract double BaseAttack { get; }
		public abstract double BaseAttackSpeed { get; }
		public abstract double BaseAttackCount { get; }
		public abstract double BaseHealth { get; }
		public abstract double BaseHealthArmor { get; }
		public abstract double BaseHealthRegen { get; }
		public abstract double BaseShields { get; }
		public abstract double BaseShieldArmor { get; }
		public abstract double BaseShieldRegen { get; }

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
