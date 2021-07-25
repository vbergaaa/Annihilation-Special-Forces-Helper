using VEntityFramework.Model;

namespace VBusiness.Mods
{
	public class PotencyMod : Mod
	{
		public PotencyMod(VModsCollection collection) : base(collection)
		{
		}

		public override int Score => 0;

		public override string BizoName => "Potency";
	}
}
