using VEntityFramework.Model;

namespace VBusiness.Souls
{
	public class SupportingSoul : DivineSoul
	{
		public SupportingSoul(VLoadoutSouls collection) : base(collection)
		{
		}

		public override SoulType Type => SoulType.Supporting;
	}
}
