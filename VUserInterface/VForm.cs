using System;
using System.Drawing;
using System.Windows.Forms;
using VBusiness.Loadouts;
using VEntityFramework.Data;
using VEntityFramework.Model;
using VUserInterface.CommonControls;

namespace VUserInterface
{
	public abstract partial class VForm : DPIForm
	{
		protected VForm(BusinessObject parent) : this()
		{
			Parent = parent;
		}

		internal static VForm Create(BusinessObject bizo)
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

		public bool BizoHasChanges
		{
			get => fBizoHasChanges;
			set
			{
				fBizoHasChanges = value;
				UpdateCancelButton();
			}
		}
		bool fBizoHasChanges;

		protected virtual void UpdateCancelButton()
		{
			CancelButton.Text = fBizoHasChanges ? "Cancel" : "Close";
			CancelButton.DialogResult = fBizoHasChanges ? DialogResult.Cancel : DialogResult.OK;
		}


		public new BusinessObject Parent
		{
			get => fParent;
			set
			{
				fParent = value;
				if (fParent != null)
				{
					BindingSource.DataSource = fParent;
				}
			}
		}
		BusinessObject fParent;

		void SaveButton_Click(object sender, EventArgs e)
		{
			var parent = GetParentToSave();
			parent.RunPreSaveValidation();

			if (parent.Notifications.HasErrors())
			{
				MessageBox.Show(parent.Notifications.Errors[0], "Error");
				return;
			}

			if (parent.Notifications.HasPrompt())
			{
				foreach (var prompt in parent.Notifications.Prompts)
				{
					var result = MessageBox.Show(prompt, "Continue?", MessageBoxButtons.YesNo);
					if (result == DialogResult.No)
					{
						return;
					}
				}
			}

			parent.Save();
			OnSaved?.Invoke(this, e);
		}

		protected virtual BusinessObject GetParentToSave()
		{
			return Parent;
		}

		protected virtual void CancelButton_Click(object sender, EventArgs e)
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
				SaveButton.Location = new Point(ClientSize.Width - DPIScalingHelper.GetScaledX(180), ClientSize.Height - DPIScalingHelper.GetScaledY(30));
				CancelButton.Location = new Point(ClientSize.Width - DPIScalingHelper.GetScaledX(90), ClientSize.Height - DPIScalingHelper.GetScaledY(30));
			}
		}

		public event EventHandler<EventArgs> OnSaved;
	}
}


