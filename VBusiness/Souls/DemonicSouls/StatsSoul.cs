using System;
using System.Collections.Generic;
using System.Text;
using VEntityFramework.Model;

namespace VBusiness.Souls
{
	public class StatsSoul : DemonicSoul
	{
		public StatsSoul(VSoulCollection collection) : base(collection)
		{
		}

		public override VEntityFramework.Model.SoulType Type => VEntityFramework.Model.SoulType.Stats;

		protected override int MinMinerals => 10000;
		protected override int MinKills => 1000;

		protected override int MinAttack => 35;
		protected override int MaxAttack => 45;

		protected override int MaxAttackSpeed => 30;
		protected override int MinAttackSpeed => 20;

		protected override int MaxCriticalChance => 7;
		protected override int MinCriticalChance => 3;

		protected override int MaxCriticalDamage => 8;
		protected override int MinCriticalDamage => 3;

		protected override int MaxVitals => 30;
		protected override int MinVitals => 20;

		protected override int MaxArmor => 22;
		protected override int MinArmor => 14;
	}
}
