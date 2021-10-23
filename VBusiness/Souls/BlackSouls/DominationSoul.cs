using VEntityFramework.Model;

namespace VBusiness.Souls
{
	public class DominationSoul : BlackSoul
	{
		public DominationSoul(VLoadoutSouls collection) : base(collection)
		{
		}

		public override SoulType Type => SoulType.Domination;
	}
}
