using VEntityFramework.Model;

namespace VBusiness.Souls
{
	public class ChristmasEventSoul : Soul
	{
		public ChristmasEventSoul(VLoadoutSouls collection) : base(collection)
		{
		}

		public override SoulType Type => SoulType.ChristmasEvent;

		public override int MaxAttack => 0;

		public override int MinAttack => 0;

		public override int MaxAttackSpeed => 0;

		public override int MinAttackSpeed => 0;

		public override int MaxCriticalChance => 0;

		public override int MinCriticalChance => 0;

		public override int MaxCriticalDamage => 0;

		public override int MinCriticalDamage => 0;

		public override int MaxVitals => 0;

		public override int MinVitals => 0;

		public override int MaxArmor => 0;

		public override int MinArmor => 0;

		public override int MaxMinerals => 10000;

		public override int MinMinerals => 10000;

		public override int MaxKills => 1000;

		public override int MinKills => 1000;

		public override int Cost => 1000;

		protected override SoulType Rarity => SoulType.ChristmasEvent;
	}
}
