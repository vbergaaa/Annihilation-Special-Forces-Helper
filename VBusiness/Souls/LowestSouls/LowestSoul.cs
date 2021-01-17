using VEntityFramework.Model;

namespace VBusiness.Souls
{
	public class LowestSoul : Soul
	{
		public LowestSoul(VSoulCollection collection) : base(collection)
		{
		}

		public override SoulType Type => SoulType.Lowest;

		protected sealed override SoulType Rarity => SoulType.Lowest;

		public override int MaxAttack => 10;

		public override int MinAttack => 1;

		public override int MaxAttackSpeed => 5;

		public override int MinAttackSpeed => 1;

		public override int MaxCriticalChance => 0;

		public override int MinCriticalChance => 0;

		public override int MaxCriticalDamage => 0;

		public override int MinCriticalDamage => 0;

		public override int MaxVitals => 0;

		public override int MinVitals => 0;

		public override int MaxArmor => 0;

		public override int MinArmor => 0;

		public override int MaxMinerals => 0;

		public override int MinMinerals => 0;

		public override int MaxKills => 0;

		public override int MinKills => 0;

		public override int Cost => 20; // sell=5
	}
}
