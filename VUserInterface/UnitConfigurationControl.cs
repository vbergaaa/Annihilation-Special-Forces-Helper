using System;
using System.Collections.Generic;
using VBusiness;
using VEntityFramework.Model;
using VBusiness.Ranks;
using VBusiness.HelperClasses;
using VBusiness.Difficulties;
using VUserInterface.CommonControls;

namespace VUserInterface
{
	public partial class UnitConfigurationControl : DPIUserControl
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
