using VEntityFramework.Model;

namespace VBusiness.Souls
{
	public sealed class GlowingDeterminationSoul : HighestSoul
	{
		public GlowingDeterminationSoul(VLoadoutSouls collection) : base(collection)
		{
		}

		public override VEntityFramework.Model.SoulType Type => VEntityFramework.Model.SoulType.GlowingDetermination;
	}
}
