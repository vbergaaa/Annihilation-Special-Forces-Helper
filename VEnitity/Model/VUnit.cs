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

		#region Stats

		public abstract int BaseDamage { get; }
		public abstract int BaseArmor { get; }
		public abstract int BaseHealth { get; }

		#endregion

		#region Properties

		#region Loadout

		[VXML(false)]
		public VLoadout Loadout => (VLoadout)Parent;

		#endregion

		#endregion

		#region Implementation

		public override string BizoName => "Unit";

		[VXML(true)]
		public string Key => this.GetType().Name;

		#endregion
	}
}
