using System;
using VEntityFramework.Data;

namespace VEntityFramework.Model
{
	public abstract class VPerk : VBusinessObject
	{
		#region Abstract Members

		protected abstract string name { get; }

		public abstract string Description { get; }

		public abstract byte Page { get; }

		public abstract byte Position { get; }

		public abstract int StartingCost { get; }

		public abstract int IncrementCost { get; }

		public abstract short MaxLevel { get; }

		public abstract int RemainingCost { get; }

		public abstract int TotalCost { get; }

		public abstract int CurrentCost { get; }

		protected int LevelChange { get; set; }

		#endregion

		#region Events

		public event EventHandler<StatsEventArgs> PerkLevelChanged;

		void OnPerkLevelChanged(int newLevel, int oldLevel)
		{
			var e = new StatsEventArgs();
			e.Modification = GetStatsModifier(newLevel - oldLevel);

			if (e.Modification != null)
			{
				PerkLevelChanged?.Invoke(this, e);
			}
		}

		#endregion

		#region Properties

		public string Name => $"{name} Perk";

		[VXML(true)]
		public string Code => $"{Page}_{Position}";

		#region CurrentLevel

		[VXML(false)]
		public virtual short CurrentLevel
		{
			get { return fCurrentLevel; }
			set
			{
				if (value != fCurrentLevel)
				{
					if (value > MaxLevel)
					{
						fCurrentLevel = MaxLevel;
					}
					else if (value < 0)
					{
						fCurrentLevel = 0;
					}
					else
					{
						fCurrentLevel = value;
					}
					OnPropertyChanged(new System.ComponentModel.PropertyChangedEventArgs(nameof(CurrentLevel)));
					HasChanges = true;
				}
			}
		}
		short fCurrentLevel;

		#endregion

		#region DesiredLevel


		[VXML(true)]
		public virtual short DesiredLevel
		{
			get { return fDesiredLevel; }
			set
			{
				if (value != fDesiredLevel)
				{
					var oldValue = fDesiredLevel;

					if (value > MaxLevel)
					{
						fDesiredLevel = MaxLevel;
					}
					else if (value < 0)
					{
						fDesiredLevel = 0;
					}
					else
					{
						fDesiredLevel = value;
					}

					var newValue = fDesiredLevel;

					if (newValue != oldValue)
					{
						OnPropertyChanged(new System.ComponentModel.PropertyChangedEventArgs(nameof(DesiredLevel)));
						OnPerkLevelChanged(newValue, oldValue);
						HasChanges = true;
					}
				}
			}
		}
		short fDesiredLevel;

		#endregion

		#endregion

		#region Methods

		protected abstract Action<VStats> GetStatsModifier(int levelDifference);

		#endregion

		#region Overrides

		public override string ToString()
		{
			return $"{Code}, {Name}";
		}

		public override string BizoName => "Perk";

		#endregion
	}
}
