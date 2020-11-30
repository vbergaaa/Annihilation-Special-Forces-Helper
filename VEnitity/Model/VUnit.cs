using System;
using System.Collections.Generic;
using System.Text;

namespace VEntityFramework.Model
{
	public abstract class VUnit
	{
		#region Properties

		#region Economy Info

		public abstract Unit BaseUnit { get; }
		public abstract bool IsHidden { get; }
		public abstract int BaseMineralCost { get; }
		public abstract int MineralCost { get; }
		public abstract int KillCost { get; }
		public abstract Evolution Evolution { get; }
		public abstract int Infusion { get; set; }

		#endregion

		#endregion
	}

	public enum Evolution
	{
		Basic,
		DNA1,
		DNA2,
		Hero,
		SuperHero
	}

	public enum Unit
	{
		Probe,
		WarpLord,
		ShieldBattery,
		Striker,
		LightAdept,
		DarkShadow,
		Dreadnought,
		Templar,
	}
}
