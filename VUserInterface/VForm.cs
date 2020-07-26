using System;
using System.Windows.Forms;
using VEntityFramework;
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
			Parent.HasChangesChanged += UpdateSaveButtons;
		}

		VForm()
		{
			InitializeComponent();
		}

		private void UpdateSaveButtons(object sender, HasChangesEventArgs e)
		{
			SaveButton.Enabled = e.HasChanges;
			CancelButton.Text = e.HasChanges ? "Cancel" : "Close";
		}

		public new VBusinessObject Parent { get; set; }

		void SaveButton_Click(object sender, EventArgs e)
		{
			var canSave = Parent.RunPreSaveValidation(out var errorMessage);
			if (!canSave)
			{
				MessageBox.Show(errorMessage, "Error");
			}
			else
			{
				Parent.Save();
				OnSaved?.Invoke(this, e);
			}
		}

		void CancelButton_Click(object sender, EventArgs e)
		{
			if (Parent.HasChanges)
			{
				var result = MessageBox.Show("You have unsaved changes, are you sure you wish to cancel?", "Confirm Cancel", MessageBoxButtons.YesNo);
				if (result == DialogResult.No)
				{
					return;
				}
			}

			Close();
		}

		public event EventHandler<EventArgs> OnSaved;
	}
}


