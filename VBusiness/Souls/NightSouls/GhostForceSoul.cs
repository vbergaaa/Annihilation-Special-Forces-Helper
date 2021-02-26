using VEntityFramework.Model;

namespace VBusiness.Souls
{
	public sealed class GhostForceSoul : NightSoul
	{
		public GhostForceSoul(VLoadoutSouls collection) : base(collection)
		{
		}

		public override VEntityFramework.Model.SoulType Type => VEntityFramework.Model.SoulType.GhostForce;
	}
}
