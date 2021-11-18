using EnumsNET;
using System;
using System.Collections.Generic;
using System.Linq;
using VBusiness.HelperClasses;
using VBusiness.Rooms;
using VEntityFramework.Model;
using VUserInterface.CommonControls;

namespace VUserInterface
{
	public partial class LoadoutIncomeControl : DPIUserControl
	{
		public LoadoutIncomeControl()
		{
			InitializeComponent();
		}

		public VIncomeManager IncomeManager
		{
			get => fIncomeManager;
			set
			{
				if (fIncomeManager != value)
				{
					fIncomeManager = value;
					UpdateBindingIfDataSourceChanged();
				}
			}
		}
		VIncomeManager fIncomeManager;

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
			if (IncomeManager != null && IncomeManager != BindingSource.DataSource)
			{
				BindingSource.DataSource = IncomeManager;
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

		List<object> FarmRoomList => fFarmRoomList ??= BindingHelper<RoomNumber>.ConvertForBinding(Enums.GetValues<RoomNumber>().ToList());
		List<object> fFarmRoomList;

		#endregion
	}
}
