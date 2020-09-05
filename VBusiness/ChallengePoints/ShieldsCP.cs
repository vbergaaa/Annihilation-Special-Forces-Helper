using VEntityFramework.Model;

namespace VBusiness.ChallengePoints
{
	public class ShieldsCP : ChallengePoint
	{
		#region Constructor

		public ShieldsCP(VChallengePointCollection manager) : base(manager)
		{
		}

		#endregion

		#region Implementation

		public override CPColor Color => CPColor.Green;

		public override CPTier Tier => CPTier.One;

		public override void OnCPLevelChanged(int difference)
		{
			ChallengePointCollection.Loadout.Stats.Shields += 2 * difference;
		}

		#endregion
	}
}
