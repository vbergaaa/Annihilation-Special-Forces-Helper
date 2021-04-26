using System;
using System.Collections.Generic;
using VBusiness;
using VEntityFramework.Model;
using VBusiness.Ranks;
using VBusiness.HelperClasses;
using VUserInterface.CommonControls;
using EnumsNET;
using System.Linq;
using VBusiness.Units;

namespace VUserInterface
{
	public partial class UnitConfigurationControl : DPIUserControl
	{
		public UnitConfigurationControl()
		{
			InitializeComponent();
		}

		public UnitConfiguration UnitConfiguration
		{
			get => fUnit;
			set
			{
				if (fUnit != value)
				{
					fUnit = value;
					UpdateBindingIfDataSourceChanged();
				}
			}
		}
		UnitConfiguration fUnit;

		protected override void OnBindingContextChanged(EventArgs e)
		{
			base.OnBindingContextChanged(e);
			UpdateBindingIfDataSourceChanged();
		}

		protected override void OnParentBindingContextChanged(EventArgs e)
		{
			base.OnParentBindingContextChanged(e);
			UpdateBindingIfDataSourceChanged();
		}

		void UpdateBindingIfDataSourceChanged()
		{
			if (UnitConfiguration != null && UnitConfiguration != bindingSource.DataSource)
			{
				bindingSource.DataSource = UnitConfiguration;
				bindingSource.ResetBindings(false);
			}
		}

		void UnitsLoadList_IndexChanged(object sender, EventArgs e)
		{
			isSettingUnitFromLoadList = true;
			var unitName = (string)UnitsLoadList.CurrentItem;
			if (unitName != null)
			{
				UnitConfiguration.Loadout.SetCurrentUnit(unitName);
				CurrentUnitControl.ChangeDisplayState(isSettingUnitFromUnitDropBox);
			}
			isSettingUnitFromLoadList = false;
		}

		bool isSettingUnitFromLoadList;

		void CurrentUnitControl_UnitChanged(object sender, EventArgs e)
		{
			isSettingUnitFromUnitDropBox = true;
			var indexToSelect = isSettingUnitFromLoadList ? UnitsLoadList.CurrentIndex : -1;
			UnitsLoadList.RefreshList(indexToSelect);
			isSettingUnitFromUnitDropBox = false;
		}
		bool isSettingUnitFromUnitDropBox;

		void UnitsLoadList_NewButtonClicked(object sender, EventArgs e)
		{
			var newUnit = VUnit.New(UnitType.None, UnitConfiguration.Loadout);
			UnitConfiguration.Loadout.CurrentUnit = newUnit;
			CurrentUnitControl.ChangeDisplayState(true);
			UnitsLoadList.CurrentIndex = -1;
		}

		void UnitsLoadList_DeleteButtonClicked(object sender, EventArgs e)
		{
			var selectedIndex = UnitsLoadList.CurrentIndex;
			if (selectedIndex >= 0)
			{
				UnitConfiguration.Loadout.Units.RemoveAt(selectedIndex);

				if (UnitConfiguration.Loadout.Units.Count > selectedIndex)
				{
					UnitConfiguration.Loadout.CurrentUnit = UnitConfiguration.Loadout.Units[selectedIndex];
					UnitsLoadList.CurrentIndex = selectedIndex;
				}
				else if (UnitConfiguration.Loadout.Units.Count > 0)
				{
					UnitConfiguration.Loadout.CurrentUnit = UnitConfiguration.Loadout.Units.Last();
					UnitsLoadList.CurrentIndex = UnitConfiguration.Loadout.Units.Count - 1;
				}
				else
				{
					UnitConfiguration.Loadout.CurrentUnit = VUnit.New(UnitType.None, UnitConfiguration.Loadout);
				}
			}
		}

		void UnitConfigurationControl_VisibleChanged(object sender, EventArgs e)
		{
			this.bindingSource.ResetBindings(false);
		}
	}
}
