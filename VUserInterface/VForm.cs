using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using VBusiness.Loadouts;
using VEntityFramework.Data;

namespace VUserInterface
{
	public abstract partial class VForm : Form
	{
		protected VForm(VBusinessObject parent) : this()
		{
			if (parent == null)
			{
				throw new ArgumentException("Vform parent must always exist");
			}

			Parent = parent;
		}

		VForm()
		{
			InitializeComponent();
		}

		public new VBusinessObject Parent { get; set; }

		void SaveButton_Click(object sender, EventArgs e)
		{
			var succeeded = Parent.Save();
			OnSaved?.Invoke(this, e);

			if (succeeded)
			{
				MessageBox.Show("Save Successful");
			}
			else
			{
				MessageBox.Show("Save Failed");
			}
		}

		void CancelButton_Click(object sender, EventArgs e)
		{
			var result = MessageBox.Show("Are you sure you wish to close this form? Unsaved changes will be lost", "Cancel?", MessageBoxButtons.YesNo);
			if (result == DialogResult.Yes)
			{
				Close();
			}
		}

		public event EventHandler<EventArgs> OnSaved;
	}
}


