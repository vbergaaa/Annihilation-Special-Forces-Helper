using VEntityFramework.Model;

namespace VBusiness.Souls
{
	public sealed class WellAmplificationSoul : HighestSoul
	{
		public WellAmplificationSoul(VLoadoutSouls collection) : base(collection)
		{
		}

		public override VEntityFramework.Model.SoulType Type => VEntityFramework.Model.SoulType.WellAmplification;
	}
}
