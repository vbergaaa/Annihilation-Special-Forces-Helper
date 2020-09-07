using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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
			get => base.Attack ?? (base.Attack = new AttackCP(this));
			set
			{
				base.Attack = value;
				SetCPLimits(Attack.Color);
			}
		}

		#endregion

		#endregion

		#region Methods

		#region RefreshCP

		void SetCPLimits(CPColor color)
		{
			LockTier1IfNecessary(color);
			LockTier2IfNecessary(color);
		}

		#region Tier 1

		void LockTier1IfNecessary(CPColor color)
		{
			var tier1 = AllCP.Where(cp => cp.Color == color && cp.Tier == CPTier.One);

			if (ShouldLockTier1MinValues(color))
			{
				LockMinValues(tier1);
			}
			else
			{
				UnlockMinValues(tier1);
			}
		}

		bool ShouldLockTier1MinValues(CPColor color)
		{
			return AllCP.Where(cp => cp.Color == color && cp.Tier == CPTier.One).Sum(cp => cp.CurrentLevel) <= 2
				&& AllCP.Where(cp => cp.Color == color && cp.Tier == CPTier.Two).Sum(cp => cp.CurrentLevel) > 0;
		}

		#endregion

		#region Tier 2

		void LockTier2IfNecessary(CPColor color)
		{
			var tier2 = AllCP.Where(cp => cp.Color == color && cp.Tier == CPTier.Two);
			if (ShouldLockTier2MaxValues(color))
			{
				LockMaxValues(tier2);
			}
			else
			{
				UnlockMaxValues(tier2);
			}
		}

		bool ShouldLockTier2MaxValues(CPColor color)
		{
			return AllCP.Where(cp => cp.Color == color && cp.Tier == CPTier.One).Sum(cp => cp.CurrentLevel) < 2;
		}

		#endregion

		#region Common

		void LockMinValues(IEnumerable<VChallengePoint> tier)
		{
			foreach (var cp in tier)
			{
				cp.MinValue = cp.CurrentLevel;
			}
		}

		void UnlockMinValues(IEnumerable<VChallengePoint> tier1)
		{
			foreach (var cp in tier1)
			{
				cp.MinValue = 0;
			}
		}

		void LockMaxValues(IEnumerable<VChallengePoint> tier)
		{
			foreach (var cp in tier)
			{
				cp.MaxValue = 0;
			}
		}

		void UnlockMaxValues(IEnumerable<VChallengePoint> tier1)
		{
			foreach (var cp in tier1)
			{
				cp.MaxValue = int.MaxValue;
			}
		}

		#endregion

		#endregion

		#endregion

		#region Lookups

		List<VChallengePoint> AllCP
		{
			get => fAllCP ?? (fAllCP = GetAllCPs());
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

		public override string BizoName => "Challenge Point Collection";

		#endregion
	}
}
