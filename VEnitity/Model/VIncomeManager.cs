using System;
using System.Collections.Generic;
using System.Text;
using VEntityFramework.Data;

namespace VEntityFramework.Model
{
	public class VIncomeManager : BusinessObject
	{
		public VIncomeManager(VLoadout loadout) : base(loadout)
		{
			Loadout = loadout;
		}
		public override string BizoName => "IncomeManager";

		#region Double Warp

		public virtual int DoubleWarp
		{
			get => fDoubleWarp;
			set
			{
				if (fDoubleWarp != value)
				{
					fDoubleWarp = value;
					RefreshPropertyBinding(nameof(DoubleWarp));
					RefreshPropertyBinding(nameof(UnitMineralCost));
				}
			}
		}
		int fDoubleWarp;

		#endregion

		#region Triple Warp

		public virtual int TripleWarp
		{
			get => fTripleWarp;
			set
			{
				if (fTripleWarp != value)
				{
					fTripleWarp = value;
					RefreshPropertyBinding(nameof(TripleWarp));
					RefreshPropertyBinding(nameof(UnitMineralCost));
				}
			}
		}
		int fTripleWarp;

		#endregion

		#region Rank Revision

		public virtual int RankRevision
		{
			get => fRankRevision;
			set
			{
				if (fRankRevision != value)
				{
					fRankRevision = value;
					RefreshPropertyBinding(nameof(RankRevision));
					RefreshPropertyBinding(nameof(UnitKillCost));
				}
			}
		}
		int fRankRevision;

		#endregion

		#region HasRefundSoul

		public bool HasRefundSoul
		{
			get => fHasRefundSoul;
			set
			{
				if (fHasRefundSoul != value)
				{
					fHasRefundSoul = value;
					RefreshPropertyBinding(nameof(UnitKillCost));
				}
			}
		}
		bool fHasRefundSoul;

		#endregion

		public virtual double UnitMineralCost { get; }
		public virtual double UnitKillCost { get; }

		public VLoadout Loadout { get; }
	}
}
