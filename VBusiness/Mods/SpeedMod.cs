using VEntityFramework.Model;

namespace VBusiness.Mods
{
	public class SpeedMod : Mod
	{
		public SpeedMod(VModsCollection collection) : base(collection)
		{
		}

		public override int Score => 5;

		public override string BizoName => "Speed";
	}
}
