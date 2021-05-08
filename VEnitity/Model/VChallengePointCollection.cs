﻿using VEntityFramework.Data;

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

		#endregion
	}
}