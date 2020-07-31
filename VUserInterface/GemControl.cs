using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using VEntityFramework.Model;

namespace VUserInterface
{
	public partial class GemControl : GroupBox
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

		void DecrementCurrentButton_Click(object sender, EventArgs e)
		{
			if (Control.ModifierKeys == Keys.Shift)
			{
				Gem.CurrentLevel -= 10;
			}
			else
			{
				Gem.CurrentLevel -= 1;
			}
			LockButtonsIfRequired();
			RefreshParentsBinding();
		}

		void LockButtonsIfRequired()
		{
			DecrementCurrentButton.Enabled = Gem.CurrentLevel != 0; 
		}

		void IncrementCurrentButton_Click(object sender, EventArgs e)
		{
			if (Control.ModifierKeys == Keys.Shift)
			{
				Gem.CurrentLevel += 10;
			}
			else
			{
				Gem.CurrentLevel += 1;
			}
			LockButtonsIfRequired();
			RefreshParentsBinding();
		}

		void RefreshBinding(bool updateSchema)
		{
			gemBindingSource.ResetBindings(updateSchema);
		}

		void RefreshParentsBinding()
		{
			if (Parent is VGemCollectionControl parent)
			{
				parent.RefreshBindings();
			}
		}
	}
}
