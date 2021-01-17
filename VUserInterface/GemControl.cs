using System;
using VEntityFramework.Model;
using VUserInterface.CommonControls;

namespace VUserInterface
{
	public partial class GemControl : DPIGroupBox
	{
		public GemControl()
		{
			InitializeComponent();
		}

		public VGem	Gem
		{
			get => fGem;
			set
			{
				fGem = value;
				UpdateBindingIfDataSourceChanged();
			}
		}
		VGem fGem;

		void UpdateBindingIfDataSourceChanged()
		{
			if (Gem != null && Gem != this.gemBindingSource.DataSource)
			{
				this.gemBindingSource.DataSource = Gem;
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

		void RefreshBinding(bool updateSchema)
		{
			gemBindingSource.ResetBindings(updateSchema);
		}
	}
}
