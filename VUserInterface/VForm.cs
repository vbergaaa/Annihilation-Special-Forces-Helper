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

		public new VBusinessObject Parent
		{
			get => fParent;
			set
			{
				fParent = value;
				if (fParent != null)
				{
					this.BindingSource.DataSource = fParent;
				}
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


