﻿using VEntityFramework.Model;

namespace VBusiness.Mods
{
	public class ArmorMod : Mod
	{
		public ArmorMod(VModsCollection collection) : base(collection)
		{
		}

		public override int Score => 12;

		public override string BizoName => "Armor";

		protected override void OnModLevelChanged(int diff)
		{
			base.OnModLevelChanged(diff);

			Loadout.Stats.RefreshPropertyBinding(nameof(Loadout.Stats.Damage));
		}
	}
}
