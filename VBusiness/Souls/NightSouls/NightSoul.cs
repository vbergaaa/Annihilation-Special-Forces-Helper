using System;
using System.Collections.Generic;
using System.Text;
using VEntityFramework.Model;

namespace VBusiness.Souls
{
	public class NightSoul : Soul
	{
		public NightSoul(VSoulCollection collection) : base(collection)
		{
		}

		public override SoulType Type => SoulType.Night;

		protected sealed override SoulType Rarity => SoulType.Night;

		public override int MaxAttack => 35;

		public override int MinAttack => 25;

		public override int MaxAttackSpeed => 20;

		public override int MinAttackSpeed => 15;

		public override int MaxCriticalChance => 0;

		public override int MinCriticalChance => 0;

		public override int MaxCriticalDamage => 0;

		public override int MinCriticalDamage => 0;

		public override int MaxVitals => 20;

		public override int MinVitals => 15;

		public override int MaxArmor => 15;

		public override int MinArmor => 10;

		public override int MaxMinerals => 6000;

		public override int MinMinerals => 4000;

		public override int MaxKills => 600;

		public override int MinKills => 400;
	}
}
