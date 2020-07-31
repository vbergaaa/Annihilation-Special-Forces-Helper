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
The 'Damage' score above is accurate, and represents how much total damage you deal compared to base stats for regular auto attacks. Any benefit from spells, abilities, or passives is not taken into consideration. It is calculated from the stats below this disclaimer.

The calculation used for 'Toughness' above depends on the ratio of armor, shields and health that a unit has, and as such is not accurate for all units. It represents the amount of damage it takes to kill a unit in 100 hits, normalised to a score of 100. It is scored this way because the difficulty you are playing on and stats of your unit is unknown and as such, is more of a guideline and not a true indication of a units toughness.
For the score above, a unit with 100 HP, 50 Shields, and 5 base armor was used.

The stats below reflect stats in game, except include unit specific stats as well, such as those granted by Trifecta Power, Unit Specialization, etc.", "Calculations Disclaimer");
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
