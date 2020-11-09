using System;
using System.Collections.Generic;
using System.Text;
using VEntityFramework.Model;

namespace VBusiness.Souls
{
	public class DemonicSoul : Soul
	{
		public DemonicSoul(VSoulCollection collection) : base(collection)
		{
		}

		public override SoulType Type => SoulType.Demonic;

		protected sealed override SoulType Rarity => SoulType.Demonic;

		public override int MaxAttack => 40;

		public override int MinAttack => 30;

		public override int MaxAttackSpeed => 25;

		public override int MinAttackSpeed =>15;

		public override int MaxCriticalChance => 5;

		public override int MinCriticalChance => 2;

		public override int MaxCriticalDamage => 6;

		public override int MinCriticalDamage => 1;

		public override int MaxVitals => 25;

		public override int MinVitals => 15;

		public override int MaxArmor => 18;

		public override int MinArmor => 10;

		public override int MaxMinerals => 10000;

		public override int MinMinerals => 8000;

		public override int MaxKills => 1000;

		public override int MinKills => 800;

		public override int Cost => 2500; // Sell 150
	}
}
