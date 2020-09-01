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

namespace VUserInterface
{
	public partial class UnitConfigurationControl : UserControl
	{
		public UnitConfigurationControl()
		{
			InitializeComponent();
		}

		public UnitConfiguration Unit
		{
			get => fUnit;
			set
			{
				fUnit = value;
				UpdateRankComboBox();
			}
		}

		private void UpdateRankComboBox()
		{
			if (fUnit != null)
			{
				RankComboBox.SelectedValueChanged -= RankChanged;
				RankComboBox.SelectedIndex = (int)fUnit.UnitRank;
				RankComboBox.SelectedValueChanged += RankChanged;
			}
		}

		UnitConfiguration fUnit;

		void RankChanged(object sender, EventArgs e)
		{
			if (Unit != null && RankComboBox.SelectedValue is UnitRank rank)
			{
				Unit.UnitRank = rank;
			}
		}

		List<object> Ranks
		{
			get
			{
				if (fRanks == null)
				{
					var ranks = new List<object>
					{
						UnitRank.None,
						UnitRank.D,
						UnitRank.C,
						UnitRank.B,
						UnitRank.A,
						UnitRank.S,
						UnitRank.SD,
						UnitRank.SC,
						UnitRank.SB,
						UnitRank.SA,
						UnitRank.SS,
						UnitRank.SSD,
						UnitRank.SSC,
						UnitRank.SSB,
						UnitRank.SSA,
						UnitRank.SSS,
						UnitRank.X,
						UnitRank.SX,
						UnitRank.SSX,
						UnitRank.SSSX,
						UnitRank.XX,
						UnitRank.XD,
						UnitRank.SXD,
						UnitRank.Z,
						UnitRank.SZ,
						UnitRank.SSZ,
						UnitRank.SSSZ,
						UnitRank.XZ,
						UnitRank.XDZ,
						UnitRank.SXDZ,
						UnitRank.XYZ
					};
					fRanks = ranks;
				}
				return fRanks;
			}
		}
		List<object> fRanks;
	}
}
