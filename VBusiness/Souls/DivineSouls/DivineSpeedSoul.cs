using VEntityFramework.Model;

namespace VBusiness.Souls
{
	public class DivineSpeedSoul : DivineSoul
	{
		public DivineSpeedSoul(VLoadoutSouls collection) : base(collection)
		{
		}

		public override SoulType Type => SoulType.DivineSpeed;

		public override void ActivateUniqueEffect()
		{
			Loadout.Stats.UpdateCooldownSpeed("Core", 40);
			Loadout.Stats.UpdateAcceleration("Core", 5);
		}

		public override void DeactivateUniqueEffect()
		{
			Loadout.Stats.UpdateCooldownSpeed("Core", -40);
			Loadout.Stats.UpdateAcceleration("Core", -5);
		}
	}
}
