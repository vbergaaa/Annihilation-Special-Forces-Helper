using System;
using System.Collections.Generic;
using System.Text;
using VEntityFramework.Data;

namespace VEntityFramework.Model
{
	public class VUnitConfiguration : VBusinessObject
	{
		#region Constructor

		public VUnitConfiguration(VLoadout loadout)
		{
			Loadout = loadout;
		}

		#endregion

		#region Properties

		#region Loadout

		[VXML(false)]
		public VLoadout Loadout { get; private set; }

		#endregion

		#region Rank

		[VXML(false)]
		public VRank Rank
		{
			get => fRank;
			protected set
			{
				DeactivateRank(fRank);
				fRank = value;
				ActivateRank(fRank);
				HasChanges = true;
			}
		}

		VRank fRank;

		#endregion

		#region UnitRank

		[VXML(true)]
		public virtual UnitRank UnitRank
		{
			get => fUnitRank;
			set
			{
				if (fUnitRank != value)
				{
					fUnitRank = value;
					HasChanges = true;
				}
			}
		}
		UnitRank fUnitRank;

		#endregion

		#endregion

		#region Methods

		#region ActivateRank

		void ActivateRank(VRank rank)
		{
			if (rank != null && Loadout != null)
			{
				rank.ActivateRank();
			}
		}

		#endregion

		#region DeactivateRank

		void DeactivateRank(VRank rank)
		{
			if (rank != null && Loadout != null)
			{
				rank.DeactivateRank();
			}
		}

		#endregion

		#endregion

		#region Implementation

		public override string BizoName => "UnitConfiguration";
		
		#endregion
	}
}
