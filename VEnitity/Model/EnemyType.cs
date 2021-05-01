using System.ComponentModel;

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
		Hydralisk,
		Pygalisk,
		[Description("Primal Hydralisk")]
		PrimalHydralisk,

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
		MajorAsylum,

		// Buildings
		[Description("Spine Crawler")]
		SpineCrawler,
		[Description("Evolution Chamber")]
		EvolutionChamber,
		Hatchery,
		[Description("Spawning Pool")]
		SpawningPool,
		[Description("Spore Crawler")]
		SporeCrawler,
		[Description("Roach Warren")]
		RoachWarren,
		Spire,
		Lair,
		[Description("Hydralisk Den")]
		HydraliskDen,
		[Description("Spore Cannon")]
		SporeCannon,
		Hive,
		[Description("Pygalisk Cavern")]
		PygaliskCavern,
	}
}
