using VEntityFramework.Model;

namespace VBusiness.Mods
{
	public class HealthMod : Mod
	{
		public HealthMod(VModsCollection collection) : base(collection)
		{
		}

		public override int Score => 6;

		public override string BizoName => "Health";
	}
}
