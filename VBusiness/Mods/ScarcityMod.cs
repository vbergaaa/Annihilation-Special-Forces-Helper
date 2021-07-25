using VEntityFramework.Model;

namespace VBusiness.Mods
{
	public class ScarcityMod : Mod
	{
		public ScarcityMod(VModsCollection collection) : base(collection)
		{
		}

		public override int Score => 7;

		public override string BizoName => "Scarcity";
	}
}
