using VEntityFramework.Data;

namespace VEntityFramework.Model
{
	public abstract class VGem : BusinessObject
	{
		#region Constructor

		public VGem(VGemCollection collection) : base(collection)
		{
			GemCollection = collection;
		}

		#endregion

		#region Properties

		[VXML(false)]
		public VLoadout Loadout => GemCollection.Loadout;

		[VXML(false)]
		public VGemCollection GemCollection { get; private set; }

		public virtual short MaxValue { get; }

		[VXML(true)]
		public virtual short CurrentLevel
		{
			get => fCurrentLevel;
			set {
				if (value != fCurrentLevel)
				{
					var oldValue = fCurrentLevel;

					if (value < 0)
					{
						fCurrentLevel = 0;
					}
					else if (value > MaxValue)
					{
						fCurrentLevel = MaxValue;
					}
					else
					{
						fCurrentLevel = value;
					}

					if (fCurrentLevel != oldValue)
					{
						OnPerkLevelChanged(fCurrentLevel - oldValue);
						GemCollection?.RefreshPropertyBinding(nameof(GemCollection.TotalCost));
						HasChanges = true;
						GemCollection.RefreshMaxLevelBindings();
					}
					OnPropertyChanged(nameof(CurrentLevel));
					OnPropertyChanged(nameof(NextLevelCost));
				}
			}
		}
		short fCurrentLevel;

		[VXML(true)]
		public string Key => Name;

		public int NextLevelCost => GetCostOfNextLevel();

		public abstract string Name { get; }

		protected abstract decimal BaseCost { get; }

		protected abstract decimal IncrementCost { get; }

		public virtual string GetIncrementHint(int x)
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

		public virtual string GetDecrementHint(int x)
		{
			return string.Empty;
		}

		#endregion

		#region Abstract Methods

		public abstract int GetTotalCost();

		public abstract int GetCostOfNextLevel();

		#endregion

		#region Events

		protected virtual void OnPerkLevelChanged(int difference)
		{
		}

		#endregion

		#region Overrides

		public override string BizoName => "Gem";

		#endregion
	}
}
