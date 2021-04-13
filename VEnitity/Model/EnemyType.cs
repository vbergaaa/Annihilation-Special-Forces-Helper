using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace VEntityFramework.Model
{
	public enum EnemyType
	{
		None,

		// main unit tree
		[Description("InfestedTerran")]
		InfestedTerran,
		Zergling,
		Roach,
		[Description("Hydralisk")]
		Hydra,
		Pygalisk,
		[Description("Primal Hydralisk")]
		PrimalHydra,

		// aberation tree
		Abberation,
		[Description("Giant Abberation")]
		GiantAbberation,
		Infestor,
		[Description("Swarm Host")]
		SwarmHost,

		// Queen Tree
		Queen,
		[Description("Great Queen")]
		GreatQueen,
		[Description("Empress Queen")]
		EmpressQueen,
		[Description("Monarch Queen")]
		MonarchQueen,

		// Bosses
		[Description("Sergeant Ramone")]
		SergeantRamone,
		[Description("Lieutenant Railgul")]
		LieutenantRailgul,
		[Description("Captain Gamala")]
		CaptainGamala,
		[Description("Major Asylum")]
		MajorAsylum
	}
}
