using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using VBusiness;
using VEntityFramework.Model;
using VBusiness.Ranks;
using VBusiness.HelperClasses;
using VBusiness.Difficulties;
using VBusiness.ChallengePoints;

namespace VUserInterface
{
	public partial class ChallengePointCollectionControl : UserControl
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
