using VEntityFramework.Model;

namespace VBusiness.Souls
{
	public class HalfPitchBlackSoul : Soul
	{
		public HalfPitchBlackSoul(VLoadoutSouls collection) : base(collection)
		{
		}

		public override SoulType Type => SoulType.HalfPitchBlack;

		public override int MaxAttack => 55;

		public override int MinAttack => 40;

		public override int MaxAttackSpeed => 35;

		public override int MinAttackSpeed => 20;

		public override int MaxCriticalChance => 12;

		public override int MinCriticalChance => 8;

		public override int MaxCriticalDamage => 17;

		public override int MinCriticalDamage => 11;

		public override int MaxVitals => 40;

		public override int MinVitals => 30;

		public override int MaxArmor => 30;

		public override int MinArmor => 20;

		public override int MaxMinerals => 18000;

		public override int MinMinerals => 15000;

		public override int MaxKills => 1800;

		public override int MinKills => 1500;

		public override int Cost => 10000;

		protected override SoulType Rarity => SoulType.HalfPitchBlack;
	}
}
