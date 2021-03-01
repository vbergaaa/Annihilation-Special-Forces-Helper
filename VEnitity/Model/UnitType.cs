using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace VEntityFramework.Model
{
	public enum UnitType
	{
		None,
		
		// Basic
		Probe,
		[Description("Warp Lord")]
		WarpLord,
		[Description("Shield Battery")]
		ShieldBattery,
		Striker,
		[Description("Light Adept")]
		LightAdept,
		[Description("Dark Shadow")]
		DarkShadow,
		Dreadnought,
		Templar,
		Dominator,

		// DNA1
		[Description("Dark Probe")]
		DarkProbe,
		[Description("Dark Warp Lord")]
		DarkWarpLord,
		[Description("Dark Shield Battery")]
		DarkShieldBattery,
		[Description("Dark Striker")]
		DarkStriker,
		[Description("Forged Adept")]
		ForgedAdept,
		[Description("Dark Avenger")]
		DarkAvenger,
		[Description("Unstable Dreadnought")]
		UnstableDreadnought,
		[Description("High Templar")]
		HighTemplar,
		[Description("Arch Dominator")]
		ArchDominator,

		// DNA2
		[Description("Evolution Probe")]
		EvolutionProbe,
		[Description("Berserker Warp Lord")]
		BerserkerWarpLord,
		[Description("Splitter Adept")]
		SplitterAdept,
		[Description("Blood Avenger")]
		BloodAvenger,
		[Description("Annihilation Dreadnought")]
		AnnihilationDreadnought,

		// Hero
		[Description("Terminator Warp Lord")]
		TerminatorWarpLord,

		// Hidden
		Dragoon,
		Reaver,
		Disruptor,
		Colossus,
		[Description("Wrath Walker")]
		WrathWalker,
		[Description("Purification Walker")]
		PurificationWalker,
		Prisoner,
		[Description("Stone Prisoner")]
		StonePrisoner,
		[Description("Blade Dancer")]
		BladeDancer,
		[Description("Blade Master")]
		BladeMaster,
		[Description("Omni Blader")]
		OmniBlader,
		Archon,
		[Description("Dark Archon")]
		DarkArchon,
		Ascendant,
		[Description("Crimson Archon")]
		CrimsonArchon,
		[Description("Winged Archon")]
		WingedArchon,
	}
}
