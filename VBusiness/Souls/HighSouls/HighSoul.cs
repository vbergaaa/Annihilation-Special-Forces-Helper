using VEntityFramework.Model;

namespace VBusiness.Souls
{
	public class HighSoul : Soul
	{
		public HighSoul(VSoulCollection collection) : base(collection)
		{
		}

		public override SoulType Type => SoulType.High;

		protected sealed override SoulType Rarity => SoulType.High;

		public override int MaxAttack => 20;

		public override int MinAttack => 10;

		public override int MaxAttackSpeed => 12;

		public override int MinAttackSpeed => 10;

		public override int MaxCriticalChance => 0;

		public override int MinCriticalChance => 0;

		public override int MaxCriticalDamage => 0;

		public override int MinCriticalDamage => 0;

		public override int MaxVitals => 12;

		public override int MinVitals => 10;

		public override int MaxArmor => 0;

		public override int MinArmor => 0;

		public override int MaxMinerals => 2000;

		public override int MinMinerals => 1000;

		public override int MaxKills => 100;

		public override int MinKills => 100;

		public override int Cost => 400; // sell 40-45??
	}
}
