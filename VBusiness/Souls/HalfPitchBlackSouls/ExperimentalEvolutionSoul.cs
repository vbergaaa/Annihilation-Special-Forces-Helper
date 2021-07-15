using VEntityFramework.Model;

namespace VBusiness.Souls
{
	public class ExperimentalEvolutionSoul : HalfPitchBlackSoul
	{
		public ExperimentalEvolutionSoul(VLoadoutSouls collection) : base(collection)
		{
		}

		public override SoulType Type => SoulType.ExperimentalEvolution;
		public override void ActivateUniqueEffect()
		{
			Loadout.IncomeManager.InfuseRecycle += 100;
		}

		public override void DeactivateUniqueEffect()
		{
			Loadout.IncomeManager.InfuseRecycle -= 100;
		}
	}
}
