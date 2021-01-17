using VEntityFramework.Model;

namespace VBusiness.Souls
{
	public class MidSoul : Soul
	{
		public MidSoul(VSoulCollection collection) : base(collection)
		{
		}

		public override SoulType Type => SoulType.Mid;

		protected sealed override SoulType Rarity => SoulType.Mid;

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

		public override int MaxKills => 0;

		public override int MinKills => 0;

		public override int Cost => 250; // SELL 30
	}
}
