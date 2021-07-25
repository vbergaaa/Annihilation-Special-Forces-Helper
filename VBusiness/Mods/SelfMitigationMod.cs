using VEntityFramework.Model;

namespace VBusiness.Mods
{
	public class SelfMitigationMod : Mod
	{
		public SelfMitigationMod(VModsCollection collection) : base(collection)
		{
		}

		public override int Score => 15;

		public override string BizoName => "SelfMitigation";

		public override string Name => "Self Mitigation";
	}
}
