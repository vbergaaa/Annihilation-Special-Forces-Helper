using System;
using VBusiness.ChallengePoints;
using VUserInterface.CommonControls;

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
	}
}
