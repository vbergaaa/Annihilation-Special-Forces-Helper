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

namespace VUserInterface
{
	public partial class UnitConfigurationControl : UserControl
	{
		public UnitConfigurationControl()
		{
			InitializeComponent();
		}

		public UnitConfiguration UnitConfiguration
		{
			get => fUnit;
			set
			{
				if (fUnit != value)
				{
					fUnit = value;
					UpdateBindingIfDataSourceChanged();
				}
			}
		}
		UnitConfiguration fUnit;

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
			if (UnitConfiguration != null && UnitConfiguration != bindingSource.DataSource)
			{
				bindingSource.DataSource = UnitConfiguration;
				bindingSource.ResetBindings(false);
			}
		}

		#region Rank

		List<object> RankList
		{
			get => fRankList ?? (fRankList = BindingHelper<VEntityFramework.Model.UnitRank>.ConvertForBinding(new RankLookup().GetRanks()));
		}
		List<object> fRankList;

		#endregion

		#region Difficulty

		List<object> DifficultyList
		{
			get => fDifficultyList ?? (fDifficultyList = BindingHelper<DifficultyLevel>.ConvertForBinding(new DifficultyLookup().GetDifficulties()));
		}
		List<object> fDifficultyList;

		#endregion
	}
}
