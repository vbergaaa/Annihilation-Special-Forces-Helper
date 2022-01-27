using EnumsNET;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Loader;
using VEntityFramework.Data;
using VEntityFramework.DataContext;

namespace VEntityFramework.Model
{
	public abstract class VUnit : BusinessObject
	{
		public VUnit(VLoadout loadout, UnitType unitType) : base(loadout)
		{
			UnitData = GetUnitData(unitType);

			if (!loadout.Units.Contains(this) && unitType != UnitType.None)
			{
				loadout.Units.Add(this);
			}

			if (unitType == UnitType.None)
			{
				loadout.DeregisterChild(this);
			}

			loadout.CurrentUnit = this;
		}

		#region New

		public static VUnit New(UnitType type, VLoadout loadout)
		{
			return (VUnit)BizoCreator.Create(typeof(VUnit), "Unit", loadout, type);
		}

		static IUnitData GetNewUnitData(UnitType type)
		{
			var typeFullName = type != UnitType.None 
				? $"VBusiness.Units.{type}"
				: $"VBusiness.Units.EmptyUnit";
			var assembly = AssemblyLoadContext.Default.LoadFromAssemblyPath(Directory.GetCurrentDirectory() + "/VBusiness.dll");
			var myType = assembly.GetType(typeFullName);
			var ctor = myType.GetConstructors()[0];
			return (IUnitData)ctor.Invoke(null);
		}

		#endregion

		#region GetUnitData

		public static IUnitData GetUnitData(UnitType type)
		{
			if (UnitDataDictionary.TryGetValue(type, out var data))
			{
				return data;
			}
			data = GetNewUnitData(type);
			UnitDataDictionary[type] = data;
			return data;
		}
		static IDictionary<UnitType, IUnitData> UnitDataDictionary => fUnitDataDictionary ??= new Dictionary<UnitType, IUnitData>();
		static IDictionary<UnitType, IUnitData> fUnitDataDictionary;

		#endregion

		#region Properties

		#region Loadout

		[VXML(false)]
		public VLoadout Loadout => (VLoadout)Parent;

		#endregion

		#region UnitData

		[VXML(true, "Key")]
		public IUnitData UnitData { get; internal set; }

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

		public virtual int MaximumKills { get; }

		#region Rank

		[VXML(false)]
		public virtual VUnitRank Rank
		{
			get => fRank;
			protected set
			{
				using (Loadout.Stats.SuspendRefreshingStatBindings())
				{
					DeactivateRank(fRank);
					fRank = value;
					ActivateRank(fRank);
					HasChanges = true;
					OnDescriptionChanged();
				}
			}
		}
		VUnitRank fRank;

		#region ActivateRank

		void ActivateRank(VUnitRank rank)
		{
			if (rank != null && Loadout != null && IsCurrentUnit)
			{
				rank.ActivateRank();
			}
		}

		#endregion

		#region DeactivateRank

		void DeactivateRank(VUnitRank rank)
		{
			if (rank != null && Loadout != null && IsCurrentUnit)
			{
				rank.DeactivateRank();
			}
		}

		#endregion

		#endregion

		#region UnitRank

		[VXML(true)]
		public virtual UnitRankType UnitRank
		{
			get => fUnitRank;
			set
			{
				if (fUnitRank != value)
				{
					fUnitRank = value;
					HasChanges = true;
					Loadout.IncomeManager.RefreshPropertyBinding(nameof(Loadout.IncomeManager.LoadoutKillCost));
				}
			}
		}
		UnitRankType fUnitRank;

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
					OnPropertyChanged(nameof(CurrentKills));
				}
			}
		}
		int fCurrentEssence;

		#endregion

		#region CurrentKills

		public virtual int CurrentKills { get; set; }

		#endregion

		#region MaximumEssence

		public virtual int MaximumEssence { get; }

		#endregion

		#region HasUnitSpec

		public virtual bool HasUnitSpec { get; }

		#endregion

		#region IsLimitBroken

		[VXML(true)]
		public virtual bool IsLimitBroken
		{
			get => fIsLimitBroken;
			set
			{
				if (value != fIsLimitBroken)
				{
					fIsLimitBroken = value;
					HasChanges = true;
					OnPropertyChanged(nameof(IsLimitBroken));
				}
			}
		}
		bool fIsLimitBroken;

		public virtual bool IsLimitBroken_Modifiable { get; }

		#endregion

		#region LimitlessEssenceStacks

		public virtual int LimitlessEssenceStacks
		{
			get => fLimitlessEssenceStacks;
			set
			{
				if (value != fLimitlessEssenceStacks)
				{
					fLimitlessEssenceStacks = value;
					HasChanges = true;
				}
			}
		}
		int fLimitlessEssenceStacks;

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

		#endregion

		#endregion

		public event EventHandler DescriptionChanged;
		void OnDescriptionChanged()
		{
			DescriptionChanged?.Invoke(this, new EventArgs());
		}

		public static IEnumerable<UnitType> ValidSpecTypes()
		{
			return new List<UnitType>()
			{
				UnitType.None,
				UnitType.WarpLord,
				UnitType.ShieldBattery,
				UnitType.Striker,
				UnitType.LightAdept,
				UnitType.DarkShadow,
				UnitType.Dreadnought,
				UnitType.Templar,
				UnitType.Dominator,
			};
		}

		#region Implementation

		public override string BizoName => "Unit";

		public override string ToString()
		{
			return GetDescription();
		}

		string GetDescription()
		{
			var number = "";
			if (Loadout != null)
			{
				var matchingUnits = Loadout.Units.Where(u => u.UnitData.Type == UnitData.Type && u.UnitRank == UnitRank && u.CurrentInfusion == CurrentInfusion).ToList();
				if (matchingUnits.Count > 1)
				{
					number = $"({matchingUnits.IndexOf(this) + 1})";
				}
			}
			var rank = UnitRank == UnitRankType.None ? "" : UnitRank.ToString();
			return $"+{CurrentInfusion} {rank} {UnitData.Type.AsString(EnumFormat.Description, EnumFormat.Name)} {number}";
		}

		#endregion
	}
}