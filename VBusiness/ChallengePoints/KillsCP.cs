using VEntityFramework.Model;

namespace VBusiness.ChallengePoints
{
	public class KillsCP : ChallengePoint
	{
		#region Constructor

		public KillsCP(VChallengePointCollection manager) : base(manager)
		{
		}

		#endregion

		#region Implementation

		public override CPColor Color => CPColor.Blue;

		public override CPTier Tier => CPTier.One;

		public override void OnCPLevelChanged(int difference)
		{
		}

		#endregion
	}
}
