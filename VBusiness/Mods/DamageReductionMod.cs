﻿using VEntityFramework.Model;

namespace VBusiness.Mods
{
	public class DamageReductionMod : Mod
	{
		public DamageReductionMod(VModsCollection collection) : base(collection)
		{
		}

		public override int Score => 15;

		public override string BizoName => "DamageReduction";

		public override string Name => "Damage Reduction";

		protected override void OnModLevelChanged(int diff)
		{
			base.OnModLevelChanged(diff);

			Loadout.Stats.RefreshPropertyBinding(nameof(Loadout.Stats.Damage));
		}
	}
}
