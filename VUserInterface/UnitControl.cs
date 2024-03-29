﻿using EnumsNET;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using VBusiness.HelperClasses;
using VEntityFramework;
using VEntityFramework.Model;
using VUserInterface.CommonControls;

namespace VUserInterface
{
	public partial class UnitControl : DPIUserControl
	{
		public UnitControl()
		{
			InitializeComponent();
		}

		#region Unit

		public VUnit Unit
		{
			get => fUnit;
			set
			{
				if (fUnit != value && value != null && !isSettingUnit)
				{
					if (fUnit != null)
					{
						fUnit.DescriptionChanged -= UpdateUnitsListBindings;
					}
					value.DescriptionChanged += UpdateUnitsListBindings;
					var loadout = value.Loadout;
					fUnit = value;
					isSettingUnit = true;
					BindingSource.DataSource = fUnit;
					if (loadout.CurrentUnit != fUnit)
					{
						loadout.CurrentUnit = fUnit;
					}
					OnUnitChanged();
					isSettingUnit = false;
				}
			}
		}

		VUnit fUnit;
		bool isSettingUnit;

		#endregion

		#region Units Type

		internal List<object> UnitsTypesList => fUnitsTypesList ??= GetUnitTypes();
		List<object> fUnitsTypesList;

		#endregion

		#region Rank

		List<object> RanksList => fRankList ??= BindingHelper<UnitRankType>.ConvertForBinding(Enums.GetValues<UnitRankType>().ToList());
		List<object> fRankList;

		#endregion

		#region UnitTypeDropBoxChanged

		void UnitTypeDropBox_SelectedValueChanged(object sender, System.EventArgs e)
		{
			if (Unit != null && !isSettingUnit)
			{
				var loadout = Unit.Loadout;
				RemoveExistingUnit(loadout);
				var unitType = (UnitType)UnitTypeDropBox.SelectedValue;
				var newUnit = VUnit.New(unitType, loadout);

				Unit = newUnit;
			}
		}

		private void RemoveExistingUnit(VLoadout loadout)
		{
			if (loadout.Units.Contains(Unit))
			{
				loadout.Units.Remove(Unit);
			}
			else if (Unit.UnitData.Type != UnitType.None)
			{
				ErrorReporter.ReportDebug("Why isn't the current unit in the loadouts list?");
			}
		}

		void UpdateUnitsListBindings(object sender, System.EventArgs e)
		{
			OnUnitChanged();
		}

		#endregion

		public event EventHandler UnitChanged;
		void OnUnitChanged()
		{
			UnitChanged?.Invoke(this, new EventArgs());
		}

        static List<object> GetUnitTypes()
		{
			var list = new List<object>
			{
				UnitType.None,
				string.Empty,
				UnitType.Probe,
				UnitType.DarkProbe,
				UnitType.EvolutionProbe,
				string.Empty,
				UnitType.WarpLord,
				UnitType.DarkWarpLord,
				UnitType.BerserkerWarpLord,
				UnitType.TerminatorWarpLord,
				string.Empty,
				UnitType.ShieldBattery,
				UnitType.DarkShieldBattery,
				string.Empty,
				UnitType.Striker,
				UnitType.DarkStriker,
				UnitType.MirrorStriker,
				UnitType.ParadoxStriker,
				string.Empty,
				UnitType.LightAdept,
				UnitType.ForgedAdept,
				UnitType.SplitterAdept,
				UnitType.DuplicatorAdept,
				string.Empty,
				UnitType.DarkShadow,
				UnitType.DarkAvenger,
				UnitType.BloodAvenger,
				string.Empty,
				UnitType.Dreadnought,
				UnitType.UnstableDreadnought,
				UnitType.AnnihilationDreadnought,
				string.Empty,
				UnitType.Templar,
				UnitType.HighTemplar,
				string.Empty,
				UnitType.Dominator,
				UnitType.ArchDominator,
				string.Empty,
				UnitType.Dragoon,
				UnitType.Reaver,
				UnitType.Disruptor,
				UnitType.Colossus,
				UnitType.WrathWalker,
				UnitType.PurificationWalker,
				string.Empty,
				UnitType.Prisoner,
				UnitType.StonePrisoner,
				UnitType.BladeDancer,
				UnitType.BladeMaster,
				UnitType.OmniBlader,
				string.Empty,
				UnitType.OrbDancer,
				UnitType.OrbOrbiter,
				UnitType.GalacticOrbiter,
				string.Empty,
				UnitType.Archon,
				UnitType.DarkArchon,
				UnitType.Ascendant,
				UnitType.CrimsonArchon,
				UnitType.WingedArchon,
				string.Empty,
				UnitType.Artifact
			};

			return list;
		}
	}
}
