using VEntityFramework.Data;

namespace VEntityFramework.Model
{
	public abstract class VGem : VBusinessObject
	{
		#region Constructor

		public VGem(VGemCollection collection) : base(collection)
		{
			GemCollection = collection;
		}

		#endregion

		#region Properties

		#region GemCollection

		[VXML(false)]
		public VGemCollection GemCollection { get; private set; }

		#endregion

		#region MaxValue

		public virtual short MaxValue { get; }

		#endregion

		#region CurrentLevel

		[VXML(true)]
		public virtual short CurrentLevel
		{
			get { return fCurrentLevel; }
			set
			{
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

		#endregion

		#region Key

		[VXML(true)]
		public string Key => Name;

		#endregion

		#region NextLevelCost

		public int NextLevelCost => GetCostOfNextLevel();

		#endregion

		#region Abstract Properties

		public abstract string Name { get; }

		protected abstract decimal BaseCost { get; }

		protected abstract decimal IncrementCost { get; }

		#endregion

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
