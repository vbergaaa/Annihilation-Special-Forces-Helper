using System;
using System.Collections.Generic;
using System.Text;
using VEntityFramework.Model;

namespace VBusiness.Souls
{
	public class HighSoul : Soul
	{
		public override SoulType Type => SoulType.High;

		protected override int MaxAttack => 20;

		protected override int MinAttack => 10;

		protected override int MaxAttackSpeed => 12;

		protected override int MinAttackSpeed => 10;

		protected override int MaxCriticalChance => 0;

		protected override int MinCriticalChance => 0;

		protected override int MaxCriticalDamage => 0;

		protected override int MinCriticalDamage => 0;

		protected override int MaxVitals => 12;

		protected override int MinVitals => 10;

		protected override int MaxArmor => 0;

		protected override int MinArmor => 0;

		protected override int MaxMinerals => 2000;

		protected override int MinMinerals => 1000;

		protected override int MaxKills => 100;

		protected override int MinKills => 100;
	}
}
