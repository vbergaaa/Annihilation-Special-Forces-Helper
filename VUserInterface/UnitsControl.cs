using System;
using VBusiness.Loadouts;
using VUserInterface.CommonControls;

namespace VUserInterface
{
	public partial class UnitsControl : DPIUserControl
	{
		public UnitsControl()
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
			if (Loadout != null && Loadout != bindingSource.DataSource)
			{
				bindingSource.DataSource = Loadout;
				bindingSource.ResetBindings(false);
			}
		}
	}
}
