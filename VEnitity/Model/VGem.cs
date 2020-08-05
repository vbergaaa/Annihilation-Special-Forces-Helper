using System;
using System.Collections.Generic;
using System.Text;
using VEntityFramework.Data;

namespace VEntityFramework.Model
{
	public abstract class VGem : VBusinessObject
	{
		#region Abstract Properties
		
		public abstract string Name { get; }

		#endregion

		#region Properties

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
					else
					{
						fCurrentLevel = value;
					}

					if (fCurrentLevel != oldValue)
					{
						OnPerkLevelChanged(fCurrentLevel, oldValue);
						OnPropertyChanged(new System.ComponentModel.PropertyChangedEventArgs(nameof(CurrentLevel)));
						HasChanges = true;
					}
				}
			}
		}
		short fCurrentLevel;

		[VXML(true)]
		public string Key => Name;

		public int NextLevelCost => GetCostOfNextLevel();

		#endregion

		#region Abstract Methods

		public abstract int GetTotalCost();

		public abstract int GetCostOfNextLevel();

		protected abstract Action<VStats> GetStatsModifier(int levelDifference);

		#endregion

		#region Events

		public event EventHandler<StatsEventArgs> GemLevelChanged;

		void OnPerkLevelChanged(int newLevel, int oldLevel)
		{
			var e = new StatsEventArgs();
			e.Modification = GetStatsModifier(newLevel - oldLevel);

			if (e.Modification != null)
			{
				GemLevelChanged?.Invoke(this, e);
			}
		}

		#endregion

		#region Overrides

		public override string BizoName => "Gem";

		#endregion
	}
}
