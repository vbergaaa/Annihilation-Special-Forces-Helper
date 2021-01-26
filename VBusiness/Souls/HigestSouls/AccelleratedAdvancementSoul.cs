using VEntityFramework.Model;

namespace VBusiness.Souls
{
	public sealed class AccelleratedAdvancementSoul : HighestSoul
	{
		public AccelleratedAdvancementSoul(VLoadoutSouls collection) : base(collection)
		{
		}

		public override VEntityFramework.Model.SoulType Type => VEntityFramework.Model.SoulType.AccelleratedAdvancement;
	}
}
