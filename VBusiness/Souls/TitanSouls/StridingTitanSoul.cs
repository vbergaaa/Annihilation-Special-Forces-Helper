using VEntityFramework.Model;

namespace VBusiness.Souls
{
	public sealed class StridingTitanSoul : TitanSoul
	{
		public StridingTitanSoul(VSoulCollection collection) : base(collection)
		{
		}

		public override SoulType Type => SoulType.StridingTitan;

		protected override void ActivateSoulCore()
		{
			base.ActivateSoulCore();
			SoulCollection.Loadout.Stats.Attack += 20;
			SoulCollection.Loadout.Stats.AttackSpeed += 20;
			SoulCollection.Loadout.Stats.Health += 20;
			SoulCollection.Loadout.Stats.Shields += 20;
		}

		protected override void DeactivateSoulCore()
		{
			base.DeactivateSoulCore();
			SoulCollection.Loadout.Stats.Attack -= 20;
			SoulCollection.Loadout.Stats.AttackSpeed -= 20;
			SoulCollection.Loadout.Stats.Health -= 20;
			SoulCollection.Loadout.Stats.Shields -= 20;
		}
	}
}
