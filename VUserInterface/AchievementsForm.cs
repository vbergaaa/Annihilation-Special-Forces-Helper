using System.Diagnostics;
using System.Windows.Forms;
using StarCodeDecryptor;
using VBusiness;
using VUserInterface.CommonControls;

namespace VUserInterface
{
	public partial class AchievementsForm : Form
	{
		public AchievementsForm()
		{
			InitializeComponent();
			FillValues();
		}

		private void FillValues()
		{
			var labelCount = 0;
			var achievements = new ASFBankDecoder(Registry.Instance.BankFileOverride).GetAchievements();

			foreach (var control in Controls)
			{
				if (control is VLabel label && label.Name.StartsWith("label"))
				{
					labelCount++;

					var i = (label.Location.X - 110) / 50;
					var j = (label.Location.Y - 40) / 20;

					if (j % 2 == 0)
					{
						label.BackColor = System.Drawing.Color.FromArgb(210, 210, 210);
					}

					label.Text = achievements[j][i] ? "X" : string.Empty;
				}
			}
			
			if (labelCount != 270)
			{
				Debugger.Break();
			}
		}
	}
}
