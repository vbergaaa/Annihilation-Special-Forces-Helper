using System;
using System.Collections.Generic;
using System.Text;
using VEntityFramework.Data;

namespace VEntityFramework.Model
{
	public abstract class VUnit : VBusinessObject
	{
		public VUnit(VLoadout loadout) : base(loadout)
		{
		}

		#region Properties

		#region Loadout

		[VXML(false)]
		public VLoadout Loadout => (VLoadout)Parent;

		#endregion

		#region Stats

		public abstract double BaseAttack { get; }
		public abstract double BaseAttackSpeed { get; }
		public abstract double BaseAttackCount { get; }
		public abstract double BaseAttackRange { get; }
		public abstract double BaseHealth { get; }
		public abstract double BaseHealthArmor { get; }
		public abstract double BaseHealthRegen { get; }
		public abstract double BaseShields { get; }
		public abstract double BaseShieldArmor { get; }
		public abstract double BaseShieldRegen { get; }
		public abstract double BaseShieldRegenDelay { get; }

		#endregion

		#endregion

		#region Implementation

		public override string BizoName => "Unit";

		[VXML(true)]
		public string Key => this.GetType().Name;

		#endregion
	}
}
