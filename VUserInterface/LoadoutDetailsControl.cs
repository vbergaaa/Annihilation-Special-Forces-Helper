﻿using EnumsNET;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using VBusiness.HelperClasses;
using VBusiness.Loadouts;
using VEntityFramework.Model;
using VUserInterface.CommonControls;

namespace VUserInterface
{
	public partial class LoadoutDetailsControl : DPIUserControl
	{
		public LoadoutDetailsControl()
		{
			InitializeComponent();
		}

		#region Loadout

		public Loadout Loadout
		{
			get => fLoadout;
			set
			{
				fLoadout = value;
				ResetDataBindings();
			}
		}
		Loadout fLoadout;

		private void ResetDataBindings()
		{
			if (Loadout != null && Loadout != BindingSource.DataSource)
			{
				BindingSource.DataSource = Loadout;
				BindingSource.ResetBindings(false);
			}
		}

		#endregion

		#region Difficulty

		List<object> DifficultyList => fDifficultyList ??= BindingHelper<DifficultyLevel>.ConvertForBinding(Enums.GetValues<DifficultyLevel>().ToList());
		List<object> fDifficultyList;

		#endregion

		#region UnitSpec

		List<object> UnitSpecList => fUnitSpecList ??= BindingHelper<UnitType>.ConvertForBinding(VUnit.ValidSpecTypes().ToList());
		List<object> fUnitSpecList;

		#endregion
	}
}
