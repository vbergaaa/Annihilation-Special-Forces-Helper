using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
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
			get => fRegistry ??= Registry.GetRegistry();
			set => fRegistry = value;
		}

		Registry fRegistry;

		protected override void OnBindingContextChanged(EventArgs e)
		{
			base.OnBindingContextChanged(e);
			if (Registry != null)
			{
				this.BindingSource.DataSource = Registry;
			}
		}

		void SaveEditButton_Click(object sender, EventArgs e)
		{
			Registry.Save();
		}

	}
}
