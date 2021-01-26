using VEntityFramework.Model;

namespace VBusiness.Souls
{
	public sealed class ConvenienceSoul : HighSoul
	{
		public ConvenienceSoul(VLoadoutSouls collection) : base(collection)
		{
		}

		public override VEntityFramework.Model.SoulType Type => VEntityFramework.Model.SoulType.Convenience;
	}
}
