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

		protected override int MaxAttack => 40;

		protected override int MinAttack => 30;

		protected override int MaxAttackSpeed => 25;

		protected override int MinAttackSpeed =>15;

		protected override int MaxCriticalChance => 5;

		protected override int MinCriticalChance => 2;

		protected override int MaxCriticalDamage => 6;

		protected override int MinCriticalDamage => 1;

		protected override int MaxVitals => 25;

		protected override int MinVitals => 15;

		protected override int MaxArmor => 18;

		protected override int MinArmor => 10;

		protected override int MaxMinerals => 10000;

		protected override int MinMinerals => 8000;

		protected override int MaxKills => 1000;

		protected override int MinKills => 800;
	}
}
