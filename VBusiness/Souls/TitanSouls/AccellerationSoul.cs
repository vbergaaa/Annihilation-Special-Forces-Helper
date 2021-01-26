using VEntityFramework.Model;

namespace VBusiness.Souls
{
	public class AccelerationSoul : TitanSoul
	{
		public AccelerationSoul(VLoadoutSouls collection) : base(collection)
		{
		}

		public override SoulType Type => SoulType.Acceleration;

		protected override void ActivateSoulCore()
		{
			base.ActivateSoulCore();
			Loadout.Stats.Acceleration += 10;
		}

		protected override void DeactivateSoulCore()
		{
			base.ActivateSoulCore();
			Loadout.Stats.Acceleration -= 10;
		}
	}
}
