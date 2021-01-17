using VEntityFramework.Model;

namespace VBusiness.Souls
{
	public sealed class WellAmplificationSoul : HighestSoul
	{
		public WellAmplificationSoul(VSoulCollection collection) : base(collection)
		{
		}

		public override VEntityFramework.Model.SoulType Type => VEntityFramework.Model.SoulType.WellAmplification;
	}
}
