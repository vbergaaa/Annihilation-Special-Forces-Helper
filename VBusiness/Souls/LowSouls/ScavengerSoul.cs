using VEntityFramework.Model;

namespace VBusiness.Souls
{
	public sealed class ScavengerSoul : LowSoul
	{
		public ScavengerSoul(VLoadoutSouls collection) : base(collection)
		{
		}

		public override VEntityFramework.Model.SoulType Type => VEntityFramework.Model.SoulType.Scavenger;
	}
}
