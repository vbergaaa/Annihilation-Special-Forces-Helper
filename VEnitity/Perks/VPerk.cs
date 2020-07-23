﻿using VEntityFramework.Data;

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

		#endregion

		#region Properties

		public string Name => $"{name} Perk";

		[VXML(true)]
		public string Code => $"{Page}_{Position}";

		#region CurrentLevel

		[VXML(true)]
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
					OnPropertyChanged(new System.ComponentModel.PropertyChangedEventArgs(nameof(DesiredLevel)));
					HasChanges = true;
				}
			}
		}
		short fDesiredLevel;

		#endregion

		public abstract int RemainingCost { get; }

		public abstract int TotalCost { get; }

		public abstract int CurrentCost { get; }

		#endregion

		#region object Overrides

		public override string ToString()
		{
			return $"{Code}, {Name}";
		}

		public override string BizoName => "Perk";

		#endregion
	}
}
