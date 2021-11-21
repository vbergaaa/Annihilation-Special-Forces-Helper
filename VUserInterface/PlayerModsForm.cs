using VEntityFramework;
using VEntityFramework.Data;

namespace VUserInterface
{
	public partial class PlayerModsForm : VForm
	{
		public PlayerModsForm(VPlayerMods parent) : base(parent)
		{
			PlayerMods = parent;
			InitializeComponent();
		}

		public VPlayerMods PlayerMods
		{
			get;
		}

		protected override BusinessObject GetParentToSave()
		{
			return PlayerMods.Profile;
		}
	}
}
