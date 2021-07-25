using VEntityFramework.Model;

namespace VBusiness.Mods
{
	public class UnwellMod : Mod
	{
		public UnwellMod(VModsCollection collection) : base(collection)
		{
		}

		public override int Score => 7;

		public override string BizoName => "Unwell";
	}
}
