using VEntityFramework.Interfaces;
using VEntityFramework.Model;

namespace VBusiness.Weapons
{
	public class SplitterAdeptBasicWeapon : BaseAdeptBounceWeapon
	{
		public SplitterAdeptBasicWeapon()
		{
		}

		public override double BaseAttack => 45;

		public override double BaseAttackPeriod => 1.2;

		public override double AttackIncrement => 1.8;

		protected override int MaxBounces => 4;

		protected override double BounceDamagePercentage => 90;

		protected override bool IncludeTransferInDamageCalcs => false;

		public override double AttackCount => 3;

		protected override ICritChances Crits
		{
			get
			{
				return usePrecisionTargetingCrits
					? PrecisionTargetingCrits
					: base.Crits;
			}
		}
		ICritChances PrecisionTargetingCrits;
		bool usePrecisionTargetingCrits;

		public override double GetDamageToEnemy(VLoadout loadout, IEnemyStatCard enemy)
		{
			// this is to apply Precision Targetting
			// gain 10 cc
			// CD: 30
			// DUR: 10
			InitialiseCrits(loadout);
			var precisionTargetingUptime = 10 / (30 / (loadout.Stats.CooldownSpeed / 100));
			precisionTargetingUptime = System.Math.Min(precisionTargetingUptime, 1);
			usePrecisionTargetingCrits = true;

			var totalDamage = precisionTargetingUptime * base.GetDamageToEnemy(loadout, enemy);

			if (precisionTargetingUptime != 1)
			{
				usePrecisionTargetingCrits = false;
				totalDamage += (1 - precisionTargetingUptime) * base.GetDamageToEnemy(loadout, enemy);
			}
			return totalDamage;
		}

		void InitialiseCrits(VLoadout loadout)
		{
			if (PrecisionTargetingCrits == default)
			{
				loadout.Stats.CriticalChance += 10;
				PrecisionTargetingCrits = WeaponHelper.GetCritChances(loadout);
				loadout.Stats.CriticalChance -= 10;
			};
		}
	}
}
