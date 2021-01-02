using System;
using VEntityFramework.Model;
using VUserInterface.CommonControls;

namespace VUserInterface
{
	public partial class VPerkControl : DPIGroupBox
	{
		public VPerkControl()
		{
			InitializeComponent();
		}

		public VPerk Perk
		{
			get => fPerk;
			set
			{
				if (fPerk != value)
				{
					fPerk = value;
					UpdateBindingIfDataSourceChanged();
				}
			}
		}
		VPerk fPerk;

		void UpdateBindingIfDataSourceChanged()
		{
			if (Perk != null && Perk != this.perkBindingSource.DataSource)
			{
				this.perkBindingSource.DataSource = Perk;
				RefreshBinding(true);
			}
		}

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

		void RefreshParentsBinding()
		{
			if (this.Parent is VPerkCollectionControl parent)
			{
				parent.RefreshBindings();
			}
		}

		public void RefreshBinding(bool updateSchema)
		{
			this.perkBindingSource.ResetBindings(updateSchema);
		}
	}
}
