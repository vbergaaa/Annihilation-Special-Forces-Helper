using VEntityFramework.Model;

namespace VBusiness.ChallengePoints
{
	public class CriticalDamageCP : ChallengePoint
	{
		#region Constructor

		public CriticalDamageCP(VChallengePointCollection manager) : base(manager)
		{
		}

		#endregion

		#region Implementation

		public override CPColor Color => CPColor.Red;

		public override CPTier Tier => CPTier.One;

		public override string Name => "Critical Damage";

		public override void OnCPLevelChanged(int difference)
		{
			ChallengePointCollection.Loadout.Stats.CriticalDamage += 2 * difference;
		}

		#endregion
	}
}
