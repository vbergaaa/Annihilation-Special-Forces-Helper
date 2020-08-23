using System;
using System.Collections.Generic;
using System.Text;
using VEntityFramework.Model;

namespace VBusiness.Souls
{
	public class TormentedSoul : Soul
	{
		public TormentedSoul(VSoulCollection collection) : base(collection)
		{
		}

		public override SoulType Type => SoulType.Tormented;

		protected sealed override SoulType Rarity => SoulType.Tormented;

		public override int MaxAttack => 35;

		public override int MinAttack => 30;

		public override int MaxAttackSpeed => 20;

		public override int MinAttackSpeed => 15;

		public override int MaxCriticalChance => 5;

		public override int MinCriticalChance => 1;

		public override int MaxCriticalDamage => 0;

		public override int MinCriticalDamage => 0;

		public override int MaxVitals => 20;

		public override int MinVitals => 15;

		public override int MaxArmor => 16;

		public override int MinArmor => 10;

		public override int MaxMinerals => 8000;

		public override int MinMinerals => 6000;

		public override int MaxKills => 800;

		public override int MinKills => 600;
	}
}
