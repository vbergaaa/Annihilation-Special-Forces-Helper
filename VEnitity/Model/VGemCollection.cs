﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using VEntityFramework.Data;

namespace VEntityFramework.Model
{
	public abstract class VGemCollection : VBusinessObject
	{
		#region Constructor

		public VGemCollection(VLoadout loadout)
		{
			Loadout = loadout;
		}

		#endregion

		#region Properties

		#region Loadout

		public VLoadout Loadout { get; private set; }

		#endregion

		#region Abstract Properties

		public abstract VGem AttackGem { get; }
		public abstract VGem AttackSpeedGem { get; }
		public abstract VGem HealthGem { get; }
		public abstract VGem HealthArmorGem { get; }
		public abstract VGem ShieldsGem { get; }
		public abstract VGem ShieldsArmorGem { get; }
		public abstract VGem DoubleWarpGem { get; }
		public abstract VGem CritDamageGem { get; }
		public abstract VGem CritChanceGem { get; }

		public abstract VGem[] Gems { get; }

		#endregion

		#endregion

		#region Methods

		#region TotalCost

		public int TotalCost { get => Gems.Sum(g => g.GetTotalCost()); }

		#endregion

		#endregion

		#region Implementation

		public override string BizoName => "GemCollection";
		
		#endregion
	}
}

