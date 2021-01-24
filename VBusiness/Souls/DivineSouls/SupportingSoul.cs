using VEntityFramework.Model;

namespace VBusiness.Souls
{
	public class SupportingSoul : DivineSoul
	{
		public SupportingSoul(VSoulCollection collection) : base(collection)
		{
		}

		public override SoulType Type => SoulType.Supporting;
	}
}
