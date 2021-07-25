using VEntityFramework.Model;

namespace VBusiness.Mods
{
	public class DamageMod : Mod
	{
		public DamageMod(VModsCollection collection) : base(collection)
		{
		}

		public override int Score => 10;

		public override string BizoName => "Damage";
	}
}
