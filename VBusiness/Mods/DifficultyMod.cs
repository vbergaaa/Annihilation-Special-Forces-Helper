using VEntityFramework.Model;

namespace VBusiness.Mods
{
	public class DifficultyMod : Mod
	{
		public DifficultyMod(VModsCollection collection) : base(collection)
		{
		}

		public override int Score => 0;

		public override string BizoName => "Difficulty";
	}
}
