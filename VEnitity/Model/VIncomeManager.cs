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
				}
			}
		}
		int fTripleWarp;

		public VLoadout Loadout { get; }
	}
}
