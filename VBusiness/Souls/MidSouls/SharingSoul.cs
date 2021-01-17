using VEntityFramework.Model;

namespace VBusiness.Souls
{
	public sealed class SharingSoul : MidSoul
	{
		public SharingSoul(VSoulCollection collection) : base(collection)
		{
		}

		public override VEntityFramework.Model.SoulType Type => VEntityFramework.Model.SoulType.Sharing;
	}
}
