using EnumsNET;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using VBusiness.HelperClasses;
using VBusiness.Units;
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

		#region ChangeDisplayState

		public void ChangeDisplayState(bool isModifiable)
		{
			UnitTypeLabel.Visible = !isModifiable;
			UnitTypeDropBox.Visible = isModifiable;
			AddButton.Visible = isModifiable;
		}

		#endregion

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
					var isFirstSet = false;
					if (fUnit == null)
					{
						isFirstSet = true;
					}
					var loadout = value.Loadout;
					fUnit = value;
					isSettingUnit = true;
					BindingSource.DataSource = fUnit;
					if (loadout.CurrentUnit != fUnit)
					{
						loadout.CurrentUnit = fUnit;
					}
					if (isFirstSet)
					{
						ChangeDisplayState(fUnit.UnitData.Type == UnitType.None);
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

		List<object> UnitsTypesList
		{
			get => fUnitsTypesList ??= BindingHelper<UnitType>.ConvertForBinding(Enums.GetValues<UnitType>().ToList());
		}
		List<object> fUnitsTypesList;

		#endregion

		#region Rank

		List<object> RanksList
		{
			get => fRankList ??= BindingHelper<UnitRankType>.ConvertForBinding(Enums.GetValues<UnitRankType>().ToList());
		}
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

		#region UnitChanged

		public event EventHandler UnitChanged;
		void OnUnitChanged()
		{
			UnitChanged?.Invoke(this, new EventArgs());
		}

		#endregion

		#region AddButton_Click

		private void AddButton_Click(object sender, System.EventArgs e)
		{
			ChangeDisplayState(false);
		}

		#endregion
	}
}
