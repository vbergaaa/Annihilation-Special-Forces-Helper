using VEntityFramework.Model;

namespace VBusiness.Souls
{
	public sealed class HunterSoul : LowestSoul
	{
		public HunterSoul(VLoadoutSouls collection) : base(collection)
		{
		}

		public override VEntityFramework.Model.SoulType Type => VEntityFramework.Model.SoulType.Hunter;
	}
}
