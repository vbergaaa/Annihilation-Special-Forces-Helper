using System;
using System.Collections.Generic;
using VBusiness.HelperClasses;
using VUserInterface.CommonControls;
using EnumsNET;
using System.Linq;
using VBusiness.Loadouts;
using VBusiness.Rooms;

namespace VUserInterface
{
	public partial class LoadoutIncomeControl : DPIUserControl
	{
		public LoadoutIncomeControl()
		{
			InitializeComponent();
		}

		public Loadout Loadout
		{
			get => fLoadout;
			set
			{
				if (fLoadout != value)
				{
					fLoadout = value;
					UpdateBindingIfDataSourceChanged();
				}
			}
		}
		Loadout fLoadout;

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
			if (Loadout != null && Loadout != BindingSource.DataSource)
			{
				BindingSource.DataSource = Loadout;
				BindingSource.ResetBindings(false);
			}
		}

		#region Events

		void BrutaliskOverrideCheckBox_CheckedChanged(object sender, System.EventArgs e)
		{
			var checkbox = sender as VCheckControl;
			BrutaliskOverrideControl.Enabled = checkbox.Checked;
			BrutaliskOverrideControl.Refresh();
		}

		#endregion

		#region FarmRoom

		List<object> FarmRoomList
		{
			get => fFarmRoomList ??= BindingHelper<RoomNumber>.ConvertForBinding(Enums.GetValues<RoomNumber>().ToList());
		}
		List<object> fFarmRoomList;

		#endregion
	}
}
