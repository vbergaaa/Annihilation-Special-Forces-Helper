using System.Windows.Forms;
using VEntityFramework;

namespace VUserInterface
{
	public partial class PlayerModsControl : UserControl
	{
		public PlayerModsControl()
		{
			InitializeComponent();
		}

		public VPlayerMods PlayerMods
		{
			get => fMods;
			set 
			{
				if (value != null && value != fMods)
				{
					fMods = value;
					bindingSource.DataSource = fMods;
				}
			}
		}
		VPlayerMods fMods;
	}
}
