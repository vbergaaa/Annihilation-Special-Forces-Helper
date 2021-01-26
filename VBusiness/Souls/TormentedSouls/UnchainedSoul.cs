using VEntityFramework.Model;

namespace VBusiness.Souls
{
	public sealed class UnchainedSoul : TormentedSoul
	{
		public UnchainedSoul(VLoadoutSouls collection) : base(collection)
		{
		}

		public override SoulType Type => SoulType.Unchained;
	}
}
