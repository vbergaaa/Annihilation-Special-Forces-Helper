using VEntityFramework.Model;

namespace VBusiness.Souls
{
	public class LowerSoul : Soul
	{
		public LowerSoul(VLoadoutSouls collection) : base(collection)
		{
		}

		public override SoulType Type => SoulType.Lower;

		protected sealed override SoulType Rarity => SoulType.Lower;

		public override int MaxAttack => 15;

		public override int MinAttack => 5;

		public override int MaxAttackSpeed => 7;

		public override int MinAttackSpeed => 5;

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

		public override int Cost => 50; // sell 10?
	}
}
