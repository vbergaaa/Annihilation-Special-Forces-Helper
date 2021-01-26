using VEntityFramework.Model;

namespace VBusiness.Souls
{
	public sealed class PowerWarpingSoul : NightSoul
	{
		public PowerWarpingSoul(VLoadoutSouls collection) : base(collection)
		{
		}

		public override VEntityFramework.Model.SoulType Type => VEntityFramework.Model.SoulType.PowerWarping;
	}
}
