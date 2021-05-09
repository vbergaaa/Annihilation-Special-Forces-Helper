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
					ChallengePointCollection.RefreshPropertyBinding(nameof(ChallengePointCollection.TotalCost));
					((ChallengePointCollection)ChallengePointCollection).SetAllCPLimits();
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

		#region MinLevel

		public override int MinValue
		{
			get
			{
				if (IsLoading || CurrentLevel == 0)
				{
					return 0;
				}

				return CanSellCP()
					? CurrentLevel - 1
					: CurrentLevel;
			}
		}

		bool CanSellCP()
		{
			return ChallengePointCollection.CanSellCP(Tier, Color);
		}

		#endregion

		#region MaxLevel

		public override int MaxValue
		{
			get
			{
				if (IsLoading)
				{
					return 10;
				}

				if (HasUnlockedTier())
				{
					if (!ChallengePointCollection.Loadout.ShouldRestrict)
					{
						return 10;
					}

					return CanAffordNextLevel()
						? CurrentLevel + 1
						: CurrentLevel;
				}
				return CurrentLevel;
			}
		}

		bool CanAffordNextLevel()
		{
			return NextLevelCost <= ChallengePointCollection.RemainingCP;
		}

		bool HasUnlockedTier()
		{
			return ChallengePointCollection.HasUnlockedTier(Tier, Color);
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
	}
}
