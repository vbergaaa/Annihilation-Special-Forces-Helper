using System;
using System.Collections.Generic;
using VBusiness;
using VEntityFramework.Model;
using VBusiness.HelperClasses;
using VUserInterface.CommonControls;
using EnumsNET;
using System.Linq;
using VBusiness.Units;
using VBusiness.Loadouts;

namespace VUserInterface
{
	public partial class LoadoutConfigurationControl : DPIUserControl
	{
		public LoadoutConfigurationControl()
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

		#region Difficulty

		List<object> DifficultyList
		{
			get => fDifficultyList ??= BindingHelper<DifficultyLevel>.ConvertForBinding(Enums.GetValues<DifficultyLevel>().ToList());
		}
		List<object> fDifficultyList;

		#endregion

		#region UnitSpec

		List<object> UnitSpecList
		{
			get => fUnitSpecList ??= BindingHelper<UnitType>.ConvertForBinding(VUnit.ValidSpecTypes().ToList());
		}
		List<object> fUnitSpecList;

		#endregion
	}
}
