using VEntityFramework.Model;

namespace VBusiness.Mods
{
	public class TierMod : Mod
	{
		public TierMod(VModsCollection collection) : base(collection)
		{
		}

		public override int Score => 15;

		public override string BizoName => "Tier";
	}
}
