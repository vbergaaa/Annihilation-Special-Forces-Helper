﻿using System;
using System.Collections.Generic;
using System.Text;
using VEntityFramework.Model;

namespace VBusiness.ChallengePoints
{
	public class AttackCP : ChallengePoint
	{
		#region Constructor

		public AttackCP(VChallengePointCollection collection) : base(collection) { }

		#endregion

		#region Implementation

		public override CPColor Color => CPColor.Red;

		public override CPTier Tier => CPTier.One;

		public override void OnCPLevelChanged(int difference)
		{
			ChallengePointCollection.Loadout.Stats.Attack += 2 * difference;
		}

		#endregion
	}
}
