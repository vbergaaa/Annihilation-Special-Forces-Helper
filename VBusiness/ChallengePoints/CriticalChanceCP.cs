using VEntityFramework.Model;

namespace VBusiness.ChallengePoints
{
	public class CriticalChanceCP : ChallengePoint
	{
		#region Constructor

		public CriticalChanceCP(VChallengePointCollection manager) : base(manager)
		{
		}

		#endregion

		#region Implementation

		public override CPColor Color => CPColor.Red;

		public override CPTier Tier => CPTier.Two;

		public override void OnCPLevelChanged(int difference)
		{
			ChallengePointCollection.Loadout.Stats.CriticalChance += 1 * difference;
		}

		#endregion
	}
}
