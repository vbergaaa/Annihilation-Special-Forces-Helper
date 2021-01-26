using VEntityFramework.Model;

namespace VBusiness.Souls
{
	public class DivineSpeedSoul : DivineSoul
	{
		public DivineSpeedSoul(VLoadoutSouls collection) : base(collection)
		{
		}

		public override SoulType Type => SoulType.DivineSpeed;

		protected override void ActivateSoulCore()
		{
			base.ActivateSoulCore();
			Loadout.Stats.CooldownReduction += 40;
			Loadout.Stats.Acceleration += 5;
		}

		protected override void DeactivateSoulCore()
		{
			base.DeactivateSoulCore();
			Loadout.Stats.CooldownReduction -= 40;
			Loadout.Stats.Acceleration -= 5;
		}
	}
}
