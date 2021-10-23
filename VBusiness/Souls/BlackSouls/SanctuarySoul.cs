using VEntityFramework.Model;

namespace VBusiness.Souls
{
	public class SanctuarySoul : BlackSoul
	{
		public SanctuarySoul(VLoadoutSouls collection) : base(collection)
		{
		}

		public override SoulType Type => SoulType.Sanctuary;
	}
}
