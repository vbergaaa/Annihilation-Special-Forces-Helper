using VEntityFramework.Model;

namespace VBusiness.Mods
{
	public class SupplyMod : Mod
	{
		public SupplyMod(VModsCollection collection) : base(collection)
		{
		}

		public override int Score => 10;

		public override string BizoName => "Supply";
	}
}
