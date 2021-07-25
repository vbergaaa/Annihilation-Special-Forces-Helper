using VEntityFramework.Model;

namespace VBusiness.Mods
{
	public class RankMod : Mod
	{
		public RankMod(VModsCollection collection) : base(collection)
		{
		}

		public override int Score => 10;

		public override string BizoName => "Rank";
	}
}
