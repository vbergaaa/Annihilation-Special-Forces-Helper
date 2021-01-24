using VEntityFramework.Model;

namespace VBusiness.Souls
{
	public class DivineSoul : Soul
	{
		public DivineSoul(VSoulCollection collection) : base(collection)
		{
		}

		public override SoulType Type => SoulType.Divine;

		public override int MaxAttack => 45;

		public override int MinAttack => 35;

		public override int MaxAttackSpeed => 30;

		public override int MinAttackSpeed => 20;

		public override int MaxCriticalChance => 10;

		public override int MinCriticalChance => 4;

		public override int MaxCriticalDamage => 12;

		public override int MinCriticalDamage => 6;

		public override int MaxVitals => 30;

		public override int MinVitals => 15;

		public override int MaxArmor => 25;

		public override int MinArmor => 15;

		public override int MaxMinerals => 12000;

		public override int MinMinerals => 10000;

		public override int MaxKills => 1200;

		public override int MinKills => 1000;

		public override int Cost => 6000;

		protected override SoulType Rarity => SoulType.Divine;
	}
}
