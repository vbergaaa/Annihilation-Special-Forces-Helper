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
	public partial class VStatsControl : GroupBox
	{
		public VStatsControl()
		{
			InitializeComponent();
		}

		protected override void OnBindingContextChanged(EventArgs e)
		{
			base.OnBindingContextChanged(e);
			this.statsBindingSource.DataSource = Stats;
		}

		public VStats Stats { get; set; }

		private void DisclaimerLabel_Click(object sender, System.EventArgs e)
		{
			MessageBox.Show(@"
The 'Damage' and 'Toughness' stats above are estimations of a units total attack and defence, and take all the base stats into consideration. Theoretically, by maximizing these value, you would have a stronger unit in game.

The 'Toughness' rating should be treated as a guideline, and will not be accurate for all units, considering each unit has different amounts of health, shields, and armor.

The 'Damage' rating is more accurate, however it does not consider damage dealt from abilities, passives, or area of affect.

Finally, all stats on this page include unit specific stats. So if you have the perk 'trifecta power' selected, it will assume your unit has SSS, and add those stats to the sidebar.");
		}

		private void DisclaimerLabel_MouseHover(object sender, System.EventArgs e)
		{
			Cursor.Current = Cursors.Hand;
		}

		private void DisclaimerLabel_MouseMove(object sender, System.EventArgs e)
		{
			Cursor.Current = Cursors.Hand;
		}
	}
}
