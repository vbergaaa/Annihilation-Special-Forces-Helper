using System;
using System.Collections.Generic;
using System.Text;
using VEntityFramework.Model;

namespace VBusiness.Souls
{
	public class HighestSoul : Soul
	{
		public override SoulType Type => SoulType.Night;

		protected override int MaxAttack => 30;

		protected override int MinAttack => 20;

		protected override int MaxAttackSpeed => 17;

		protected override int MinAttackSpeed => 15;

		protected override int MaxCriticalChance => 0;

		protected override int MinCriticalChance => 0;

		protected override int MaxCriticalDamage => 0;

		protected override int MinCriticalDamage => 0;

		protected override int MaxVitals => 20;

		protected override int MinVitals => 15;

		protected override int MaxArmor => 15;

		protected override int MinArmor => 10;

		protected override int MaxMinerals => 4000;

		protected override int MinMinerals => 3000;

		protected override int MaxKills => 300;

		protected override int MinKills => 200;
	}
}
