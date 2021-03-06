﻿using VEntityFramework.Model;

namespace VBusiness.ChallengePoints
{
	public class HealthCP : ChallengePoint
	{
		#region Constructor

		public HealthCP(VChallengePointCollection manager) : base(manager)
		{
		}

		#endregion

		#region Implementation

		public override CPColor Color => CPColor.Green;

		public override CPTier Tier => CPTier.One;

		public override string Name => "Health";

		public override void OnCPLevelChanged(int difference)
		{
			ChallengePointCollection.Loadout.Stats.UpdateHealth("Core", 2 * difference);
		}

		#endregion
	}
}
