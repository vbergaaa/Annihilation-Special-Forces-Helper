using VEntityFramework.Model;

namespace VBusiness.Souls
{
	public class HigherSoul : Soul
	{
		public HigherSoul(VSoulCollection collection) : base(collection)
		{
		}

		public override SoulType Type => SoulType.Higher;

		protected sealed override SoulType Rarity => SoulType.Higher;

		public override int MaxAttack => 20;

		public override int MinAttack => 10;

		public override int MaxAttackSpeed => 15;

		public override int MinAttackSpeed => 10;

		public override int MaxCriticalChance => 0;

		public override int MinCriticalChance => 0;

		public override int MaxCriticalDamage => 0;

		public override int MinCriticalDamage => 0;

		public override int MaxVitals => 12;

		public override int MinVitals => 10;

		public override int MaxArmor => 10;

		public override int MinArmor => 5;

		public override int MaxMinerals => 3000;

		public override int MinMinerals => 2000;

		public override int MaxKills => 200;

		public override int MinKills => 200;

		public override int Cost => 650; // sell 60
	}
}
