using System;
using VEntityFramework.Data;

namespace VEntityFramework.Model
{
	public abstract class VChallengePointCollection : BusinessObject
	{
		#region Constructor

		public VChallengePointCollection(VLoadout loadout) : base(loadout)
		{
			Loadout = loadout;
		}

		#endregion

		#region Properties

		#region Loadout

		[VXML(false)]
		public VLoadout Loadout { get; }

		#endregion

		#region Red

		#region Attack

		public virtual VChallengePoint Attack { get; set; }

		#endregion

		#region CriticalDamage

		public virtual VChallengePoint CriticalDamage { get; set; }

		#endregion

		#region AttackSpeed

		public virtual VChallengePoint AttackSpeed { get; set; }

		#endregion

		#region CriticalChance

		public virtual VChallengePoint CriticalChance { get; set; }

		#endregion

		#endregion

		#region Green

		#region Health

		public virtual VChallengePoint Health { get; set; }

		#endregion

		#region Shields

		public virtual VChallengePoint Shields { get; set; }

		#endregion

		#region DefensiveEssence

		public virtual VChallengePoint DefensiveEssence { get; set; }

		#endregion

		#region DamageReduction

		public virtual VChallengePoint DamageReduction { get; set; }

		#endregion

		#endregion

		#region Blue

		#region Mining

		public virtual VChallengePoint Mining { get; set; }

		#endregion

		#region Kills

		public virtual VChallengePoint Kills { get; set; }

		#endregion

		#region Veterancy

		public virtual VChallengePoint Veterancy { get; set; }

		#endregion

		#region Accelleration

		public virtual VChallengePoint Acceleration { get; set; }

		#endregion

		#endregion

		#region TotalCost

		public virtual int TotalCost { get; }

		#endregion

		#region RemainingCP

		public int RemainingCP => Loadout.Profile.ChallengePoints - TotalCost;

		#endregion

		#endregion

		#region Methods

		public void RefreshMaxLevelBindings()
		{
			Attack.RefreshPropertyBinding(nameof(Attack.MaxValue));
			CriticalDamage.RefreshPropertyBinding(nameof(CriticalDamage.MaxValue));
			CriticalChance.RefreshPropertyBinding(nameof(CriticalChance.MaxValue));
			AttackSpeed.RefreshPropertyBinding(nameof(AttackSpeed.MaxValue));
			Health.RefreshPropertyBinding(nameof(Health.MaxValue));
			Shields.RefreshPropertyBinding(nameof(Shields.MaxValue));
			DefensiveEssence.RefreshPropertyBinding(nameof(DefensiveEssence.MaxValue));
			DamageReduction.RefreshPropertyBinding(nameof(DamageReduction.MaxValue));
			Mining.RefreshPropertyBinding(nameof(Mining.MaxValue));
			Kills.RefreshPropertyBinding(nameof(Kills.MaxValue));
			Veterancy.RefreshPropertyBinding(nameof(Veterancy.MaxValue));
			Acceleration.RefreshPropertyBinding(nameof(Acceleration.MaxValue));
		}

		public void RefreshMinLevelBindings()
		{
			Attack.RefreshPropertyBinding(nameof(Attack.MinValue));
			CriticalDamage.RefreshPropertyBinding(nameof(CriticalDamage.MinValue));
			CriticalChance.RefreshPropertyBinding(nameof(CriticalChance.MinValue));
			AttackSpeed.RefreshPropertyBinding(nameof(AttackSpeed.MinValue));
			Health.RefreshPropertyBinding(nameof(Health.MinValue));
			Shields.RefreshPropertyBinding(nameof(Shields.MinValue));
			DefensiveEssence.RefreshPropertyBinding(nameof(DefensiveEssence.MinValue));
			DamageReduction.RefreshPropertyBinding(nameof(DamageReduction.MinValue));
			Mining.RefreshPropertyBinding(nameof(Mining.MinValue));
			Kills.RefreshPropertyBinding(nameof(Kills.MinValue));
			Veterancy.RefreshPropertyBinding(nameof(Veterancy.MinValue));
			Acceleration.RefreshPropertyBinding(nameof(Acceleration.MinValue));
		}

		public virtual bool HasUnlockedTier(CPTier tier, CPColor color)
		{
			return false;
		}

		public virtual bool CanSellCP(CPTier tier, CPColor color)
		{
			return false;
		}
		#endregion
	}
}