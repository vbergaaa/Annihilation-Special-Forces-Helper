using VEntityFramework.Model;

namespace VBusiness.Mods
{
	public class BossPowerMod : Mod
	{
		public BossPowerMod(VModsCollection collection) : base(collection)
		{
		}

		public override int Score => 10;

		public override string BizoName => "BossPower";

		public override string Name => "Boss Power";
	}
}
