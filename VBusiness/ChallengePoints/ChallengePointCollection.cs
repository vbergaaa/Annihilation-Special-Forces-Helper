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
			set { base.Attack = value; }
		}

		#endregion

		#region AttackSpeed

		public override VChallengePoint AttackSpeed
		{
			get => base.AttackSpeed ?? (base.AttackSpeed = new AttackSpeedCP(this));
			set { base.AttackSpeed = value; }
		}

		#endregion

		#region CriticalChance

		public override VChallengePoint CriticalChance
		{
			get => base.CriticalChance ?? (base.CriticalChance = new CriticalChanceCP(this));
			set { base.CriticalChance = value; }
		}

		#endregion

		#region CriticalDamage

		public override VChallengePoint CriticalDamage
		{
			get => base.CriticalDamage ?? (base.CriticalDamage = new CriticalDamageCP(this));
			set { base.CriticalDamage = value; }
		}

		#endregion

		#region Health

		public override VChallengePoint Health
		{
			get => base.Health ?? (base.Health = new HealthCP(this));
			set { base.Health = value; }
		}

		#endregion

		#region Shields

		public override VChallengePoint Shields
		{
			get => base.Shields ?? (base.Shields = new ShieldsCP(this));
			set { base.Shields = value; }
		}

		#endregion

		#region DefensiveEssence

		public override VChallengePoint DefensiveEssence
		{
			get => base.DefensiveEssence ?? (base.DefensiveEssence = new DefensiveEssenceCP(this));
			set => base.DefensiveEssence = value;
		}

		#endregion

		#region DamageReduction

		public override VChallengePoint DamageReduction
		{
			get => base.DamageReduction ?? (base.DamageReduction = new DamageReductionCP(this));
			set => base.DamageReduction = value;
		}

		#endregion

		#region Mining

		public override VChallengePoint Mining
		{
			get => base.Mining ?? (base.Mining = new MiningUpgradesCP(this));
			set => base.Mining = value;
		}

		#endregion

		#region Kills

		public override VChallengePoint Kills
		{
			get => base.Kills ?? (base.Kills = new KillsCP(this));
			set => base.Kills = value;
		}

		#endregion

		#region Veterancy

		public override VChallengePoint Veterancy
		{
			get => base.Veterancy ?? (base.Veterancy = new VeterancyCP(this));
			set => base.Veterancy = value;
		}

		#endregion

		#region Acceleration

		public override VChallengePoint Acceleration
		{
			get => base.Acceleration ?? (base.Acceleration = new AccelerationCP(this));
			set => base.Acceleration = value;
		}

		#endregion

		#endregion

		#region Methods

		#region RefreshCP

		public void SetAllCPLimits()
		{
			SetCPLimits(CPColor.Red);
			SetCPLimits(CPColor.Green);
			SetCPLimits(CPColor.Blue);
		}

		internal void SetCPLimits(CPColor color)
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

		public override string BizoName => "ChallengePointCollection";

		#endregion
	}
}
