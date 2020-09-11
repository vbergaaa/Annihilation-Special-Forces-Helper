using System;
using System.Collections.Generic;
using System.Text;
using VEntityFramework.Model;

namespace VBusiness.ChallengePoints
{
	public abstract class ChallengePoint : VChallengePoint
	{
		#region Constructor

		public ChallengePoint(VChallengePointCollection manager) : base(manager)
		{
		}

		#endregion

		#region Properties

		#region CurrentLevel

		public override int CurrentLevel
		{
			get => base.CurrentLevel;
			set
			{
				var oldValue = base.CurrentLevel;
				if (value <= MaxValue && value >= MinValue)
				{
					base.CurrentLevel = value;
					var effectiveCPDifference = GetCPDifference(base.CurrentLevel, oldValue);
					OnCPLevelChanged(effectiveCPDifference);

					((ChallengePointCollection)ChallengePointCollection).SetCPLimits(Color);
				}
			}
		}

		int GetCPDifference(int newValue, int oldValue)
		{
			var diff = 0;
			if (newValue > oldValue)
			{
				for (var i = newValue; i > oldValue; i--)
				{
					diff += ((i + 2) / 2);
				}
			}
			else if (oldValue > newValue)
			{
				for (var i = oldValue; i > newValue; i--)
				{
					diff -= ((i + 2) / 2); 
				}
			}
			return diff;
		}

		#endregion

		#region NextLevelCost

		public override int NextLevelCost => 1 + CurrentLevel * CostIncrement;

		#endregion

		#region TotalCost

		public override int TotalCost
		{
			get
			{
				var total = 0;
				for (var i = 0; i < CurrentLevel; i++)
				{
					total += 1 + i * CostIncrement;
				}
				return total;
			}
		}

		#endregion

		#endregion

		#region Methods

		#region SetDefaultValues

		protected override void SetDefaultValuesCore()
		{
			MaxValue = int.MaxValue;
		}

		#endregion

		#endregion
	}
}
