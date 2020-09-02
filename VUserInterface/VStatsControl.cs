using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using VEntityFramework.Model;
using System.Threading;

namespace VUserInterface
{
	public partial class VStatsControl : GroupBox
	{
		public VStatsControl()
		{
			InitializeComponent();
		}

		protected override void OnBindingContextChanged(EventArgs e)
		{
			base.OnBindingContextChanged(e);
			if (Stats != null)
			{
				this.statsBindingSource.DataSource = Stats;
			}
		}

		public VStats Stats { get; set; }

		private void DisclaimerLabel_Click(object sender, EventArgs e)
		{
			MessageBox.Show(@"This sidebar represents the stats page that you can view in game.

The first two stats, 'Damage' and 'Toughness', are estimations of a units total attack and defence, and take all the base stats into consideration. Theoretically, by maximizing these value, you would have a stronger unit in game. However, the 'Toughness' stat cannot be accurately measured without knowing what unit you are using, and the 'Damage' stat does not consider spells or area of affect damage, and as such both of these values should be only be treated as a guideline to your total strength.

All stats on this page also include unit specific stats. For example, if you have a perk like 'Trifecta Power', that increases the stats of individual units, or if you have a rank selected in the 'Unit' tab, these stats are included in this sidebar."
, "Information about statistics");
		}

		private void DisclaimerLabel_MouseHover(object sender, EventArgs e)
		{
			Cursor.Current = Cursors.Hand;
		}

		private void DisclaimerLabel_MouseMove(object sender, EventArgs e)
		{
			Cursor.Current = Cursors.Hand;
		}
	}
}
