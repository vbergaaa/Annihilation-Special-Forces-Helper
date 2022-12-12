using VEntityFramework.Model;

namespace VBusiness.Souls
{
	public class DominationSoul : BlackSoul
	{
		public DominationSoul(VLoadoutSouls collection) : base(collection)
		{
		}

		public override SoulType Type => SoulType.Domination;

		public override void ActivateUniqueEffect()
		{
			base.ActivateUniqueEffect();
			Loadout.Stats.RefreshPropertyBinding(nameof(Loadout.Stats.Damage));
		}

		public override void DeactivateUniqueEffect()
		{
			base.ActivateUniqueEffect();
			Loadout.Stats.RefreshPropertyBinding(nameof(Loadout.Stats.Damage));
		}
	}
}
