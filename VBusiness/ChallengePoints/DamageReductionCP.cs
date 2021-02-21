using VEntityFramework.Model;

namespace VBusiness.ChallengePoints
{
	public class DamageReductionCP : ChallengePoint
	{
		#region Constructor

		public DamageReductionCP(VChallengePointCollection manager) : base(manager)
		{
		}

		#endregion

		#region Implementation

		public override CPColor Color => CPColor.Green;

		public override CPTier Tier => CPTier.Two;

		public override string Name => "Damage Reduction";

		public override void OnCPLevelChanged(int difference)
		{
			ChallengePointCollection.Loadout.Stats.UpdateDamageReduction("Core", 0.3999 * difference);
		}

		#endregion
	}
}
