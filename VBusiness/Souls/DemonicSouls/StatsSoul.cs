using VEntityFramework.Model;

namespace VBusiness.Souls
{
	public class StatsSoul : DemonicSoul
	{
		public StatsSoul(VSoulCollection collection) : base(collection)
		{
		}

		public override VEntityFramework.Model.SoulType Type => VEntityFramework.Model.SoulType.Stats;

		public override int MinMinerals => 10000;
		public override int MinKills => 1000;

		public override int MinAttack => 35;
		public override int MaxAttack => 45;

		public override int MaxAttackSpeed => 30;
		public override int MinAttackSpeed => 20;

		public override int MaxCriticalChance => 7;
		public override int MinCriticalChance => 3;

		public override int MaxCriticalDamage => 8;
		public override int MinCriticalDamage => 3;

		public override int MaxVitals => 30;
		public override int MinVitals => 20;

		public override int MaxArmor => 22;
		public override int MinArmor => 14;
	}
}
