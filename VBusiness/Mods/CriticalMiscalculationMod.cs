using VEntityFramework.Model;

namespace VBusiness.Mods
{
	public class CriticalMiscalculationMod : Mod
	{
		public CriticalMiscalculationMod(VModsCollection collection) : base(collection)
		{
		}

		public override int Score => 12;

		public override string BizoName => "CriticalMiscalculation";

		public override string Name => "Critical Miscalculation";
	}
}
