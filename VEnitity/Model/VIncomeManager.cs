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

		public virtual double UnitMineralCost { get; }
		public virtual double UnitKillCost { get; }

		public VLoadout Loadout { get; }
	}
}
