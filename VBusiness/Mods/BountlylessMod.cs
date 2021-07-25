using VEntityFramework.Model;

namespace VBusiness.Mods
{
	public class BountylessMod : Mod
	{
		public BountylessMod(VModsCollection collection) : base(collection)
		{
		}

		public override int Score => 6;

		public override string BizoName => "Bountyless";
	}
}
