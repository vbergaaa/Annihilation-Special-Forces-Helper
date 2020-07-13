using System;
using System.Linq;
using System.Windows.Forms;
using VEntityFramework.Model;

namespace VUserInterface
{
	public partial class VPerkControl : GroupBox
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
				LockButtonsIfRequired();
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

		private void DecrementButton_Click(object sender, EventArgs e)
		{
			if (Control.ModifierKeys == Keys.Shift)
			{
				Perk.DesiredLevel -= 10;
			}
			else
			{
				Perk.DesiredLevel -= 1;
			}
			LockButtonsIfRequired();
			RefreshParentsBinding();
		}

		private void IncrementButton_Click(object sender, EventArgs e)
		{
			if (Control.ModifierKeys == Keys.Shift)
			{
				Perk.DesiredLevel += 10;
			}
			else
			{
				Perk.DesiredLevel += 1;
			}
			LockButtonsIfRequired();
			RefreshParentsBinding();
		}

		void LockButtonsIfRequired()
		{
			IncrementButton.Enabled = Perk.DesiredLevel < Perk.MaxLevel;
			DecrementButton.Enabled = Perk.DesiredLevel > 0;
		}

		private void RefreshParentsBinding()
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
