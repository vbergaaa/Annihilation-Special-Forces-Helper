using VEntityFramework.Model;

namespace VBusiness.ChallengePoints
{
	public class DefensiveEssenceCP : ChallengePoint
	{
		#region Constructor

		public DefensiveEssenceCP(VChallengePointCollection manager) : base(manager)
		{
		}

		#endregion

		#region Implementation

		public override CPColor Color => CPColor.Green;

		public override CPTier Tier => CPTier.Two;

		public override string Name => "Defensive Essence";

		public override void OnCPLevelChanged(int difference)
		{
			ChallengePointCollection.Loadout.Stats.DefensiveEssenceStacks += difference;
		}

		#endregion
	}
}
