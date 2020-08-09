using System;
using System.Collections.Generic;
using System.Text;
using VEntityFramework.Data;

namespace VEntityFramework.Model
{
	public class VUnitConfiguration : VBusinessObject
	{
		#region Properties

		#region Rank

		[VXML(true)]
		public VRank Rank
		{
			get => fRank;
			set
			{
				DeactivateRank(fRank);
				fRank = value;
				ActivateRank(fRank);
			}
		}

		VRank fRank;

		#endregion

		#endregion

		#region Events

		#region OnRankChanged

		public event EventHandler<StatsEventArgs> OnRankChanged;

		void DeactivateRank(VRank rank)
		{
			var e = new StatsEventArgs() { Modification = rank?.DeactivateRank };
			OnRankChanged?.Invoke(this, e);
		}

		void ActivateRank(VRank rank)
		{
			var e = new StatsEventArgs() { Modification = rank?.ActivateRank };
			OnRankChanged?.Invoke(this, e);
		}

		#endregion

		#endregion

		#region Implementation

		public override string BizoName => "Rank";
		
		#endregion
	}
}
