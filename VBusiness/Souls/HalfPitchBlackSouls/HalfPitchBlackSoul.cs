using System;
using System.Collections.Generic;
using System.Text;
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

		public override int MinAttack => 40; // 49,55, 42, 55, 49, 53, 51

		public override int MaxAttackSpeed => 30;

		public override int MinAttackSpeed => 20; // 24, 24, 27, 24, 23, 24, 32

		public override int MaxCriticalChance => 12; // 8, 7, 9, 11, 12, 9, 12

		public override int MinCriticalChance => 8;

		public override int MaxCriticalDamage => 17; // 11, 16, 11, 15, 13, 11, 17

		public override int MinCriticalDamage => 11;

		public override int MaxVitals => 40; // 33, 39, 40, 33, 31, 38, 30

		public override int MinVitals => 30;

		public override int MaxArmor => 30; // 24, 28, 20, 30, 30, 20, 30

		public override int MinArmor => 20;

		public override int MaxMinerals => 18000; // 15, 17, 16, 18, 18, 17, 17

		public override int MinMinerals => 15000;

		public override int MaxKills => 1800; // 16, 15, 17, 18, 16, 16, 18

		public override int MinKills => 1500;

		public override int Cost => 10000;

		protected override SoulType Rarity => SoulType.HalfPitchBlack;
	}
}
