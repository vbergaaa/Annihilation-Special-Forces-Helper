using System;
using System.Collections.Generic;
using System.Linq;
using VEntityFramework;
using VEntityFramework.Model;

namespace VBusiness.Mods
{
	public class ModsCollection : VModsCollection
	{
		public ModsCollection(VLoadout loadout) : base(loadout)
		{
		}

		#region Mods

		#region AllMods

		public override IEnumerable<VMod> AllMods
		{
			get
			{
				yield return Damage;
				yield return Health;
				yield return Armor;
				yield return SelfMitigation;
				yield return Speed;
				yield return DamageReduction;
				yield return Difficulty;
				yield return Potency;
				yield return Taxes;
				yield return Rank;
				yield return Tier;
				yield return Scarcity;
				yield return Bountyless;
				yield return Unwell;
				yield return RankReversion;
				yield return BossPower;
				yield return CriticalMiscalculation;
				yield return GlassCannon;
				yield return Supply;
				yield return VolatileDead;
			}
		}

		#endregion

		#region Damage

		public override VMod Damage => fDamage ??= new DamageMod(this);
		VMod fDamage;

		#endregion

		#region Health

		public override VMod Health => fHealth ??= new HealthMod(this);
		VMod fHealth;

		#endregion

		#region Armor

		public override VMod Armor => fArmor ??= new ArmorMod(this);
		VMod fArmor;

		#endregion

		#region SelfMitigation

		public override VMod SelfMitigation => fSelfMitigation ??= new SelfMitigationMod(this);
		VMod fSelfMitigation;

		#endregion

		#region Speed

		public override VMod Speed => fSpeed ??= new SpeedMod(this);
		VMod fSpeed;

		#endregion

		#region DamageReduction

		public override VMod DamageReduction => fDamageReduction ??= new DamageReductionMod(this);
		VMod fDamageReduction;

		#endregion

		#region Difficulty

		public override VMod Difficulty => fDifficulty ??= new DifficultyMod(this);
		VMod fDifficulty;

		#endregion

		#region Potency

		public override VMod Potency => fPotency ??= new PotencyMod(this);
		VMod fPotency;

		#endregion

		#region Taxes

		public override VMod Taxes => fTaxes ??= new TaxesMod(this);
		VMod fTaxes;

		#endregion

		#region Rank

		public override VMod Rank => fRank ??= new RankMod(this);
		VMod fRank;

		#endregion

		#region Tier

		public override VMod Tier => fTier ??= new TierMod(this);
		VMod fTier;

		#endregion

		#region Scarcity

		public override VMod Scarcity => fScarcity ??= new ScarcityMod(this);
		VMod fScarcity;

		#endregion

		#region Bountyless

		public override VMod Bountyless => fBountyless ??= new BountylessMod(this);
		VMod fBountyless;

		#endregion

		#region Unwell

		public override VMod Unwell => fUnwell ??= new UnwellMod(this);
		VMod fUnwell;

		#endregion

		#region RankReversion

		public override VMod RankReversion => fRankReversion ??= new RankReversionMod(this);
		VMod fRankReversion;

		#endregion

		#region BossPower

		public override VMod BossPower => fBossPower ??= new BossPowerMod(this);
		VMod fBossPower;

		#endregion

		#region CriticalMiscalculation

		public override VMod CriticalMiscalculation => fCriticalMiscalculation ??= new CriticalMiscalculationMod(this);
		VMod fCriticalMiscalculation;

		#endregion

		#region GlassCannon

		public override VMod GlassCannon => fGlassCannon ??= new GlassCannonMod(this);
		VMod fGlassCannon;

		#endregion

		#region Supply

		public override VMod Supply => fSupply ??= new SupplyMod(this);
		VMod fSupply;

		#endregion

		#region VolatileDead

		public override VMod VolatileDead => fVolatileDead ??= new VolatileDeadMod(this);
		VMod fVolatileDead;

		#endregion

		#endregion

		#region ModScore

		public override int TotalModScore
		{
			get
			{
				var difficulty = Loadout.UnitConfiguration.DifficultyLevel;
				var score = AllMods.Sum(x => x.Score * x.CurrentLevel);

				if (difficulty >= DifficultyLevel.Impossible)
				{
					score -= Tier.CurrentLevel * Tier.Score; // tier up mod isn't implemented in Imp+ yet
					ErrorReporter.ReportDebug("Time to fix this, as tier should now be implemented for Imp+", () => difficulty > DifficultyLevel.ZeroV);
				}

				if (difficulty >= DifficultyLevel.Hard)
				{
					score = (int)(score * (1.0 + .0249 * Potency.CurrentLevel));
				}

				if (difficulty >= DifficultyLevel.Nightmare)
				{
					score = (int)(score * (1.0 + .0249 * Difficulty.CurrentLevel));
				}

				var maxModBonuses = AllMods.Count(x => x.CurrentLevel == x.MaxValue);

				if (difficulty >= DifficultyLevel.Impossible && Tier.CurrentLevel == 10)
				{
					maxModBonuses -= 1;
				}

				score += score * (maxModBonuses / 2) / 100;

				if (difficulty >= DifficultyLevel.Hard && difficulty < DifficultyLevel.Nightmare)
				{
					score *= 80;
					score /= 100;
				}
				else if (difficulty >= DifficultyLevel.Nightmare)
				{
					score *= 64;
					score /= 100;
				}

#if DEBUG
				if (PreventRoundingModscoreForTest)
				{
					return score;
				}
#endif
				return (int)Math.Min(2000, score);
			}
		}

#if DEBUG
		internal bool PreventRoundingModscoreForTest { get; set; }
#endif

		#endregion


	}
}