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
			Parent = parent;
		}

		VForm()
		{
			InitializeComponent();
		}

		void UpdateSaveButtons(object sender, HasChangesEventArgs e)
		{
			SaveButton.Enabled = e.HasChanges;
			CancelButton.Text = e.HasChanges ? "Cancel" : "Close";
		}

		public new VBusinessObject Parent
		{
			get => fParent;
			set
			{
				if (fParent != null)
				{
					fParent.HasChangesChanged -= UpdateSaveButtons;
				}

				fParent = value;

				if (fParent != null)
				{
					fParent.HasChangesChanged += UpdateSaveButtons;
					fParent.CascadeHasChanges();
				}

				UpdateSaveButtons(fParent, new HasChangesEventArgs { HasChanges = fParent != null && fParent.HasChanges });
			}
		}
		VBusinessObject fParent;

		void SaveButton_Click(object sender, EventArgs e)
		{
			Parent.RunPreSaveValidation();

			if (Parent.Notifications.HasErrors())
			{
				MessageBox.Show(Parent.Notifications.Errors[0], "Error");
				return;
			}

			if (Parent.Notifications.HasPrompt())
			{
				foreach (var prompt in Parent.Notifications.Prompts)
				{
					var result = MessageBox.Show(prompt, "Continue?", MessageBoxButtons.YesNo);
					if (result == DialogResult.No)
					{
						return;
					}
				}
			}

			Parent.Save();
			OnSaved?.Invoke(this, e);
		}

		void CancelButton_Click(object sender, EventArgs e)
		{
			if (Parent != null && Parent.HasChanges)
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


