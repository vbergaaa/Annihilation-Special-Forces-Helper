using System;
using System.Windows.Forms;
using VBusiness;

namespace VUserInterface
{
	public partial class RegistryControl : UserControl
	{
		public RegistryControl()
		{
			InitializeComponent();
		}

		public Registry Registry
		{
			get => fRegistry ??= Registry.Instance;
			set => fRegistry = value;
		}

		Registry fRegistry;

		protected override void OnBindingContextChanged(EventArgs e)
		{
			base.OnBindingContextChanged(e);
			if (Registry != null)
			{
				BindingSource.DataSource = Registry;
			}
		}

		void SaveEditButton_Click(object sender, EventArgs e)
		{
			Registry.Save();
		}

	}
}
