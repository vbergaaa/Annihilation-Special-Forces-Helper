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
				fUnit = value;
				UpdateBindingIfDataSourceChanged();
				UpdateRankComboBox();
				UpdateDifficultyComboBox();
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

		void UpdateRankComboBox()
		{
			if (fUnit != null)
			{
				RankDropBox.SelectedValueChanged -= RankChanged;
				RankDropBox.SelectedIndex = (int)fUnit.UnitRank;
				RankDropBox.SelectedValueChanged += RankChanged;
			}
		}

		void RankChanged(object sender, EventArgs e)
		{
			if (UnitConfiguration != null && RankDropBox.SelectedValue is UnitRank rank)
			{
				UnitConfiguration.UnitRank = rank;
			}
		}

		List<object> RankList
		{
			get => fRankList ?? (fRankList = BindingHelper<UnitRank>.ConvertForBinding(new RankLookup().GetRanks()));
		}
		List<object> fRankList;

		#endregion

		#region Difficulty

		void UpdateDifficultyComboBox()
		{
			if (fUnit != null)
			{
				RankDropBox.SelectedValueChanged -= RankChanged;
				RankDropBox.SelectedIndex = (int)fUnit.UnitRank;
				RankDropBox.SelectedValueChanged += RankChanged;
			}
		}

		void DifficultyChanged(object sender, EventArgs e)
		{
			if (UnitConfiguration != null && DifficultyDropBox.SelectedValue is DifficultyLevel difficulty)
			{
				UnitConfiguration.DifficultyLevel = difficulty;
			}
		}

		List<object> DifficultyList
		{
			get => fDifficultyList ?? (fDifficultyList = BindingHelper<DifficultyLevel>.ConvertForBinding(new DifficultyLookup().GetDifficulties()));
		}
		List<object> fDifficultyList;

		#endregion
	}
}
