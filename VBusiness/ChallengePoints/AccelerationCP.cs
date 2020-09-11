using VEntityFramework.Model;

namespace VBusiness.ChallengePoints
{
	public class AccelerationCP : ChallengePoint
	{
		#region Constructor

		public AccelerationCP(VChallengePointCollection manager) : base(manager)
		{
		}

		#endregion

		#region CostIncrement

		public override int CostIncrement => 2;

		#endregion

		#region Implementation

		public override CPColor Color => CPColor.Blue;

		public override CPTier Tier => CPTier.Two;

		public override string Name => "Acceleration";

		public override void OnCPLevelChanged(int difference)
		{
			ChallengePointCollection.Loadout.Stats.Acceleration += 1.2 * difference;
		}

		#endregion
	}
}
