using VBusiness.Units;
using VEntityFramework.Model;

namespace VBusiness.Souls
{
	public sealed class GhostForceSoul : NightSoul
	{
		public GhostForceSoul(VLoadoutSouls collection) : base(collection)
		{
		}

		public override VEntityFramework.Model.SoulType Type => VEntityFramework.Model.SoulType.GhostForce;

		public override void ActivateUniqueEffect()
		{
			base.ActivateUniqueEffect();
			((Unit)Loadout.CurrentUnit).UpdateStatsFromEssence(1);
		}

		public override void DeactivateUniqueEffect()
		{
			base.DeactivateUniqueEffect();
			((Unit)Loadout.CurrentUnit).UpdateStatsFromEssence(-1);
		}
	}
}
