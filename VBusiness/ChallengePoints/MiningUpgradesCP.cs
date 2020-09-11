using VEntityFramework.Model;

namespace VBusiness.ChallengePoints
{
	public class MiningUpgradesCP : ChallengePoint
	{
		#region Constructor

		public MiningUpgradesCP(VChallengePointCollection manager) : base(manager)
		{
		}

		#endregion

		#region Implementation

		public override CPColor Color => CPColor.Blue;

		public override CPTier Tier => CPTier.One;

		public override string Name => "Mining";

		public override void OnCPLevelChanged(int difference)
		{
		}

		#endregion
	}
}
