using System.Collections.Generic;
using System.Linq;
using VEntityFramework;
using VEntityFramework.Model;

namespace VBusiness.ChallengePoints
{
	public class ChallengePointCollection : VChallengePointCollection
	{
		#region Constructor

		public ChallengePointCollection(VLoadout loadout) : base(loadout)
		{
		}

		#endregion

		#region Properties

		#region Attack

		public override VChallengePoint Attack
		{
			get => base.Attack ??= new AttackCP(this);
			set { base.Attack = value; }
		}

		#endregion

		#region AttackSpeed

		public override VChallengePoint AttackSpeed
		{
			get => base.AttackSpeed ??= new AttackSpeedCP(this);
			set { base.AttackSpeed = value; }
		}

		#endregion

		#region CriticalChance

		public override VChallengePoint CriticalChance
		{
			get => base.CriticalChance ??= new CriticalChanceCP(this);
			set { base.CriticalChance = value; }
		}

		#endregion

		#region CriticalDamage

		public override VChallengePoint CriticalDamage
		{
			get => base.CriticalDamage ??= new CriticalDamageCP(this);
			set { base.CriticalDamage = value; }
		}

		#endregion

		#region Health

		public override VChallengePoint Health
		{
			get => base.Health ??= new HealthCP(this);
			set { base.Health = value; }
		}

		#endregion

		#region Shields

		public override VChallengePoint Shields
		{
			get => base.Shields ??= new ShieldsCP(this);
			set { base.Shields = value; }
		}

		#endregion

		#region DefensiveEssence

		public override VChallengePoint DefensiveEssence
		{
			get => base.DefensiveEssence ??= new DefensiveEssenceCP(this);
			set => base.DefensiveEssence = value;
		}

		#endregion

		#region DamageReduction

		public override VChallengePoint DamageReduction
		{
			get => base.DamageReduction ??= new DamageReductionCP(this);
			set => base.DamageReduction = value;
		}

		#endregion

		#region Mining

		public override VChallengePoint Mining
		{
			get => base.Mining ??= new MiningUpgradesCP(this);
			set => base.Mining = value;
		}

		#endregion

		#region Kills

		public override VChallengePoint Kills
		{
			get => base.Kills ??= new KillsCP(this);
			set => base.Kills = value;
		}

		#endregion

		#region Veterancy

		public override VChallengePoint Veterancy
		{
			get => base.Veterancy ??= new VeterancyCP(this);
			set => base.Veterancy = value;
		}

		#endregion

		#region Acceleration

		public override VChallengePoint Acceleration
		{
			get => base.Acceleration ??= new AccelerationCP(this);
			set => base.Acceleration = value;
		}

		#endregion

		#region TotalCost

		public override int TotalCost => AllCP.Sum(cp => cp.TotalCost);

		#endregion

		#endregion

		#region Methods

		#region RefreshCP

		public void SetAllCPLimits()
		{
			RefreshMinLevelBindings();
			RefreshMaxLevelBindings();
		}

		#region Tier 1

		public override bool CanSellCP(CPTier tier, CPColor color)
		{
			ErrorReporter.ReportDebug(tier == CPTier.None, "Where is this coming from");
			ErrorReporter.ReportDebug(tier != CPTier.One && tier != CPTier.Two, "uncomment t3 statement below to activate tier 3. Please test.");

			var canSell = true;

			//if (tier == CPTier.Three)
			//{
			//	return true;
			//}

			//if (AllCP.Any(cp => cp.Color == color && cp.Tier == CPTier.Three && cp.CurrentLevel > 0))
			//{
			//	canSell = AllCP.Where(cp => cp.Color == color && cp.Tier <= CPTier.Two).Sum(cp => cp.CurrentLevel) > 5;
			//}

			if (tier == CPTier.Two)
			{
				return canSell;
			}

			if (AllCP.Any(cp => cp.Color == color && cp.Tier == CPTier.Two && cp.CurrentLevel > 0))
			{
				canSell = AllCP.Where(cp => cp.Color == color && cp.Tier == CPTier.One).Sum(cp => cp.CurrentLevel) > 2;
			}

			return canSell;
		}

		#endregion

		#region HasUnlockedTier

		public override bool HasUnlockedTier(CPTier tier, CPColor color)
		{
			ErrorReporter.ReportDebug(tier == CPTier.None, "Where is this coming from");
			ErrorReporter.ReportDebug(tier != CPTier.One && tier != CPTier.Two, "uncomment t3 in switch to activate");

			return tier switch
			{
				CPTier.One => true,
				CPTier.Two => AllCP.Where(cp => cp.Color == color && cp.Tier <= CPTier.One).Sum(cp => cp.CurrentLevel) >= 2 && (Loadout.Profile.ChallengePoints >= 10 || !Loadout.ShouldRestrict),
				//CPTier.Three => AllCP.Where(cp => cp.Color == color && cp.Tier <= CPTier.Two).Sum(cp => cp.CurrentLevel) >= 5 && (Loadout.Profile.ChallengePoints >= 20 || !Loadout.ShouldRestrict),
				_ => false
			};
		}

		#endregion

		#endregion

		#endregion

		#region Lookups

		List<VChallengePoint> AllCP
		{
			get => fAllCP ??= GetAllCPs();
		}
		List<VChallengePoint> fAllCP;

		List<VChallengePoint> GetAllCPs()
		{
			return new List<VChallengePoint>()
			{
				Attack,
				CriticalDamage,
				AttackSpeed,
				CriticalChance,
				Health,
				Shields,
				DefensiveEssence,
				DamageReduction,
				Mining,
				Kills,
				Veterancy,
				Acceleration,
			};
		}
		#endregion

		#region Implementation

		public override string BizoName => "ChallengePointCollection";

		#endregion
	}
}
