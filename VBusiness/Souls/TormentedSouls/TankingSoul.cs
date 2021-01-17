using VEntityFramework.Model;

namespace VBusiness.Souls
{
	public sealed class TankingSoul : TormentedSoul
	{
		public TankingSoul(VSoulCollection collection) : base(collection)
		{
		}

		public override SoulType Type => SoulType.Tanking;

		protected override void ActivateSoulCore()
		{
			base.ActivateSoulCore();
			SoulCollection.Loadout.Stats.AdditiveArmor += 3;
			SoulCollection.Loadout.Stats.DamageReductionFromStats += 5;
		}

		protected override void DeactivateSoulCore()
		{
			base.DeactivateSoulCore();
			SoulCollection.Loadout.Stats.AdditiveArmor -= 3;
			SoulCollection.Loadout.Stats.DamageReductionFromStats -= 5;
		}
	}
}
