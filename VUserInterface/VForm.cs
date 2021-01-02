using System;
using System.Windows.Forms;
using VBusiness.Loadouts;
using VEntityFramework;
using VEntityFramework.Data;
using VEntityFramework.Model;

namespace VUserInterface
{
	public abstract partial class VForm : Form
	{
		protected VForm(VBusinessObject parent) : this()
		{
			Parent = parent;
		}

		internal static VForm Create(VBusinessObject bizo)
		{
			if (bizo is VSoul soul)
			{
				return new SoulForm(soul);
			}
			if (bizo is Loadout loadout)
			{
				return new VLoadoutForm(loadout);
			}
			return null;
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

		protected override void OnSizeChanged(EventArgs e)
		{
			base.OnSizeChanged(e);

			UpdateSaveButtonLocations();
		}

		void UpdateSaveButtonLocations()
		{
			if (SaveButton != null && CancelButton != null)
			{
				this.SaveButton.Location = new System.Drawing.Point(this.Width - 180, this.Height - 30);
				this.CancelButton.Location = new System.Drawing.Point(this.Width - 90, this.Height - 30);
			}
		}

		public event EventHandler<EventArgs> OnSaved;
	}
}


