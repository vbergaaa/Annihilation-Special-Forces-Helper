using VEntityFramework.Model;

namespace VBusiness.Souls
{
	public sealed class DemolitionSoul : TormentedSoul
	{
		public DemolitionSoul(VLoadoutSouls collection) : base(collection)
		{
		}

		public override VEntityFramework.Model.SoulType Type => VEntityFramework.Model.SoulType.Demolition;

		public override int MinCriticalChance => 6;
		public override int MaxCriticalChance => 10;
	}
}
