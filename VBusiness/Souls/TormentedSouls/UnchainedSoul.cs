using VEntityFramework.Model;

namespace VBusiness.Souls
{
	public sealed class UnchainedSoul : TormentedSoul
	{
		public UnchainedSoul(VSoulCollection collection) : base(collection)
		{
		}

		public override SoulType Type => SoulType.Unchained;
	}
}
