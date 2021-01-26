using VEntityFramework.Model;

namespace VBusiness.Souls
{
	public class TitanSoul : Soul
	{
		public TitanSoul(VLoadoutSouls collection) : base(collection)
		{
		}

		public override SoulType Type => SoulType.Titan;

		protected sealed override SoulType Rarity => SoulType.Titan;

		public override int MaxAttack => 45;

		public override int MinAttack => 30;

		public override int MaxAttackSpeed => 30;

		public override int MinAttackSpeed => 20;

		public override int MaxCriticalChance => 8;

		public override int MinCriticalChance => 3;

		public override int MaxCriticalDamage => 10;

		public override int MinCriticalDamage => 3;

		public override int MaxVitals => 30;

		public override int MinVitals => 15;

		public override int MaxArmor => 20;

		public override int MinArmor => 10;

		public override int MaxMinerals => 11000;

		public override int MinMinerals => 8000;

		public override int MaxKills => 1100;

		public override int MinKills => 800;

		public override int Cost => 4000; //Sell 190
	}
}
