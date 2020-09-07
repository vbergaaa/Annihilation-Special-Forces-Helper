using VEntityFramework.Data;

namespace VEntityFramework.Model
{
	public abstract class VChallengePointCollection : VBusinessObject
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

		#endregion
	}
}