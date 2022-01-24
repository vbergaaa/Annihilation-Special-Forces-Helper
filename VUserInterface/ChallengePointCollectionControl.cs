using System;
using System.Windows.Forms;
using VBusiness.ChallengePoints;
using VBusiness.Loadouts;
using VUserInterface.CommonControls;
using VUserInterface.Helpers;

namespace VUserInterface
{
	public partial class ChallengePointCollectionControl : DPIUserControl
	{
		public ChallengePointCollectionControl()
		{
			InitializeComponent();
		}

		public ChallengePointCollection ChallengePointCollection
		{
			get => fChallengePointCollection;
			set
			{
				if (fChallengePointCollection != value)
				{
					fChallengePointCollection = value;
					fChallengePointCollection.SetAllCPLimits();
					UpdateBindingIfDataSourceChanged();
				}
			}
		}
		ChallengePointCollection fChallengePointCollection;

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

		void UpdateBindingIfDataSourceChanged()
		{
			if (ChallengePointCollection != null && ChallengePointCollection != bindingSource.DataSource)
			{
				bindingSource.DataSource = ChallengePointCollection;
				bindingSource.ResetBindings(false);
			}
		}

		void OptimiseForDamageButton_Click(object sender, System.EventArgs e)
		{
			var loadout = ChallengePointCollection.Loadout as Loadout;

			if (loadout.CurrentUnit?.UnitData?.Type == VEntityFramework.Model.UnitType.None)
			{
				MessageBox.Show("Please select a unit to enable this functionality");
				return;
			}

			if (MessageBox.Show(CaptionProvider.GetOptimiseLoadoutCaption("challenge points", "damage"), "Confirmation", MessageBoxButtons.OKCancel) != DialogResult.OK)
			{
				return;
			}

			loadout.OptimiseCPForDamage();
		}

		private void OptimiseForToughnessButton_Click(object sender, System.EventArgs e)
		{
			var loadout = ChallengePointCollection.Loadout as Loadout;

			if (loadout.CurrentUnit?.UnitData?.Type == VEntityFramework.Model.UnitType.None)
			{
				MessageBox.Show("Please select a unit to enable this functionality");
				return;
			}

			if (MessageBox.Show(CaptionProvider.GetOptimiseLoadoutCaption("challenge points", "toughness"), "Confirmation", MessageBoxButtons.OKCancel) != DialogResult.OK)
			{
				return;
			}

			loadout.OptimiseCPForToughness();
		}
	}
}
