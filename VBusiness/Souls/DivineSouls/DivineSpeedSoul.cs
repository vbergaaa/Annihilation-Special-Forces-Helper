using VEntityFramework.Model;

namespace VBusiness.Souls
{
	public class DivineSpeedSoul : DivineSoul
	{
		public DivineSpeedSoul(VSoulCollection collection) : base(collection)
		{
		}

		public override SoulType Type => SoulType.DivineSpeed;

		protected override void ActivateSoulCore()
		{
			base.ActivateSoulCore();
			SoulCollection.Loadout.Stats.CooldownReduction += 40;
			SoulCollection.Loadout.Stats.Acceleration += 5;
		}

		protected override void DeactivateSoulCore()
		{
			base.DeactivateSoulCore();
			SoulCollection.Loadout.Stats.CooldownReduction -= 40;
			SoulCollection.Loadout.Stats.Acceleration -= 5;
		}
	}
}
