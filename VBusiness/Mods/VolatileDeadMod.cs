using VEntityFramework.Model;

namespace VBusiness.Mods
{
	public class VolatileDeadMod : Mod
	{
		public VolatileDeadMod(VModsCollection collection) : base(collection)
		{
		}

		public override int Score => 13;

		public override string BizoName => "VolatileDead";

		public override string Name => "Volatile Dead";
	}
}
