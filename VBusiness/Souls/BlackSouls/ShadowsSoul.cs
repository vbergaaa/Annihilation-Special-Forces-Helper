using VEntityFramework.Model;

namespace VBusiness.Souls
{
	public class ShadowsSoul : BlackSoul
	{
		public ShadowsSoul(VLoadoutSouls collection) : base(collection)
		{
		}

		public override SoulType Type => SoulType.Shadows;
	}
}
