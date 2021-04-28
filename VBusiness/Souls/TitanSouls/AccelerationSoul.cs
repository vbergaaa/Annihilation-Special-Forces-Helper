using VEntityFramework.Model;

namespace VBusiness.Souls
{
	public class AccelerationSoul : TitanSoul
	{
		public AccelerationSoul(VLoadoutSouls collection) : base(collection)
		{
		}

		public override SoulType Type => SoulType.Acceleration;

		public override void ActivateUniqueEffect()
		{
			Loadout.Stats.Acceleration += 10;
		}

		public override void DeactivateUniqueEffect()
		{
			Loadout.Stats.Acceleration -= 10;
		}
	}
}
