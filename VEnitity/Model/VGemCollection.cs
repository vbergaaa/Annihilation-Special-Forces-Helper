using System;
using System.Collections.Generic;
using System.Text;
using VEntityFramework.Data;

namespace VEntityFramework.Model
{
	public abstract class VGemCollection : VBusinessObject
	{
		public override string BizoName => "GemCollection";

		public abstract VGem AttackGem { get; set; }
		public abstract VGem AttackSpeedGem { get; set; }
		public abstract VGem HealthGem { get; set; }
		public abstract VGem HealthArmorGem { get; set; }
		public abstract VGem ShieldsGem { get; set; }
		public abstract VGem ShieldsArmorGem { get; set; }
		public abstract VGem DoubleWarpGem { get; set; }
		public abstract VGem CriticalDamageGem { get; set; }
		public abstract VGem CriticalChanceGem { get; set; }

		public abstract VGem[] Gems { get; }
	}
}
