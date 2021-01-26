using VEntityFramework.Model;

namespace VBusiness.Souls
{
	public sealed class TankingSoul : TormentedSoul
	{
		public TankingSoul(VLoadoutSouls collection) : base(collection)
		{
		}

		public override SoulType Type => SoulType.Tanking;

		protected override void ActivateSoulCore()
		{
			base.ActivateSoulCore();
			Loadout.Stats.AdditiveArmor += 3;
			Loadout.Stats.DamageReductionFromStats += 5;
		}

		protected override void DeactivateSoulCore()
		{
			base.DeactivateSoulCore();
			Loadout.Stats.AdditiveArmor -= 3;
			Loadout.Stats.DamageReductionFromStats -= 5;
		}
	}
}
