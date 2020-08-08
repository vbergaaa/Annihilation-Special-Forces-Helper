using System;
using System.Collections.Generic;
using System.Text;
using VEntityFramework.Model;

namespace VBusiness.Souls
{
	public class TitanSoul : Soul
	{
		public override SoulType Type => SoulType.Titan;

		protected sealed override SoulType Rarity => SoulType.Titan;

		protected override int MaxAttack => 45;

		protected override int MinAttack => 30;

		protected override int MaxAttackSpeed => 30;

		protected override int MinAttackSpeed => 20;

		protected override int MaxCriticalChance => 8;

		protected override int MinCriticalChance => 3;

		protected override int MaxCriticalDamage => 10;

		protected override int MinCriticalDamage => 3;

		protected override int MaxVitals => 30;

		protected override int MinVitals => 15;

		protected override int MaxArmor => 20;

		protected override int MinArmor => 10;

		protected override int MaxMinerals => 11000;

		protected override int MinMinerals => 8000;

		protected override int MaxKills => 1100;

		protected override int MinKills => 800;
	}
}
