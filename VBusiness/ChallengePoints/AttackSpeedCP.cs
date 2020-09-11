using VEntityFramework.Model;

namespace VBusiness.ChallengePoints
{
	public class AttackSpeedCP : ChallengePoint
	{
		#region Constructor

		public AttackSpeedCP(VChallengePointCollection manager) : base(manager)
		{
		}

		#endregion

		#region Implementation

		public override CPColor Color => CPColor.Red;

		public override CPTier Tier => CPTier.Two;

		public override string Name => "Attack Speed";

		public override void OnCPLevelChanged(int difference)
		{
			ChallengePointCollection.Loadout.Stats.AttackSpeed += 1.5 * difference;
		}

		#endregion
	}
}
