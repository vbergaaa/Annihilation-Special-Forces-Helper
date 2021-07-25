using VEntityFramework.Model;

namespace VBusiness.Mods
{
	public class GlassCannonMod : Mod
	{
		public GlassCannonMod(VModsCollection collection) : base(collection)
		{
		}

		public override int Score => 10;

		public override string BizoName => "GlassCannon";

		public override string Name => "Glass Cannon";
	}
}
