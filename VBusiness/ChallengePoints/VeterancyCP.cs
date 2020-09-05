using VEntityFramework.Model;

namespace VBusiness.ChallengePoints
{
	public class VeterancyCP : ChallengePoint
	{
		#region Constructor

		public VeterancyCP(VChallengePointCollection manager) : base(manager)
		{
		}

		#endregion

		#region Implementation

		public override CPColor Color => CPColor.Blue;

		public override CPTier Tier => CPTier.Two;

		public override void OnCPLevelChanged(int difference)
		{
		}

		#endregion
	}
}
