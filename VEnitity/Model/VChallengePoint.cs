using VEntityFramework.Data;

namespace VEntityFramework.Model
{
	public abstract class VChallengePoint : BusinessObject
	{
		#region Constructor

		public VChallengePoint(VChallengePointCollection manager) : base(manager)
		{
			ChallengePointCollection = manager;
		}

		#endregion

		#region Properties

		[VXML(false)]
		public VChallengePointCollection ChallengePointCollection
		{
			get; private set;
		}

		[VXML(false)]
		public VLoadout Loadout => ChallengePointCollection.Loadout;

		[VXML(true)]
		public virtual int CurrentLevel
		{
			get => fCurrentLevel;
			set
			{
				if (fCurrentLevel != value)
				{
					fCurrentLevel = value;
					HasChanges = true;
					OnPropertyChanged(nameof(CurrentLevel));
				}
			}
		}
		int fCurrentLevel;

		public virtual int MinValue { get; }
		public virtual int MaxValue { get; }
		public virtual int CostIncrement => 1;
		public virtual int NextLevelCost { get; }
		public virtual int TotalCost { get; }
		public abstract CPColor Color { get; }
		public abstract CPTier Tier { get; }
		public abstract string Name { get; }
		[VXML(true)]
		public string Key => Name;

		#endregion

		#region Methods

		public abstract void OnCPLevelChanged(int difference);

		public virtual string GetIncrementHint(int amount)
		{
			return string.Empty;
		}

		public virtual string GetDecrementHint(int amount)
		{
			return string.Empty;
		}

		public virtual double GetProposedDamageIncrease(int amount)
		{
			return 0;
		}

		public virtual double GetProposedToughnessIncrease(int amount)
		{
			return 0;
		}

		public virtual double GetProposedDamageDecrease(int amount)
		{
			return 0;
		}

		public virtual double GetProposedToughnessDecrease(int amount)
		{
			return 0;
		}

		#endregion

		#region Implementation

		public override string BizoName => "ChallengePoint";

		#endregion
	}

	public enum CPColor
	{
		None,
		Red,
		Green,
		Blue,
	}

	public enum CPTier
	{
		None,
		One,
		Two,
	}
}
