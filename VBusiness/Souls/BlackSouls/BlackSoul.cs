using System;
using System.Collections.Generic;
using System.Text;
using VEntityFramework.Model;

namespace VBusiness.Souls
{
	public class BlackSoul : Soul
	{
		public BlackSoul(VLoadoutSouls collection) : base(collection)
		{
		}

		public override SoulType Type => SoulType.Black;

		public override int MaxAttack => 50;

		public override int MinAttack => 40;

		public override int MaxAttackSpeed => 35;

		public override int MinAttackSpeed => 20;

		public override int MaxCriticalChance => 11;

		public override int MinCriticalChance => 5;

		public override int MaxCriticalDamage => 14;

		public override int MinCriticalDamage => 8;

		public override int MaxVitals => 35;

		public override int MinVitals => 25;

		public override int MaxArmor => 30;

		public override int MinArmor => 20;

		public override int MaxMinerals => 15000;

		public override int MinMinerals => 12000;

		public override int MaxKills => 1500;

		public override int MinKills => 1200;

		public override int Cost => 8000;

		protected override SoulType Rarity => SoulType.Black;
	}
}
