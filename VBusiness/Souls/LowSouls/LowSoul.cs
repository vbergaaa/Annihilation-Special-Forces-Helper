using System;
using System.Collections.Generic;
using System.Text;
using VEntityFramework.Model;

namespace VBusiness.Souls
{
	public class LowSoul : Soul
	{
		public LowSoul(VSoulCollection collection) : base(collection)
		{
		}

		public override SoulType Type => SoulType.Low;

		protected sealed override SoulType Rarity => SoulType.Low;

		public override int MaxAttack => 15;

		public override int MinAttack => 5;

		public override int MaxAttackSpeed => 10;

		public override int MinAttackSpeed => 5;

		public override int MaxCriticalChance => 0;

		public override int MinCriticalChance => 0;

		public override int MaxCriticalDamage => 0;

		public override int MinCriticalDamage => 0;

		public override int MaxVitals => 10;

		public override int MinVitals => 5;

		public override int MaxArmor => 0;

		public override int MinArmor => 0;

		public override int MaxMinerals => 0;

		public override int MinMinerals => 0;

		public override int MaxKills => 0;

		public override int MinKills => 0;
	}
}
