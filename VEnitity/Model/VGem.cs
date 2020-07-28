using System;
using System.Collections.Generic;
using System.Text;
using VEntityFramework.Data;

namespace VEntityFramework.Model
{
	public abstract class VGem : VBusinessObject
	{
		#region Abstract Properties

		[VXML(true)]
		public abstract string Name { get; }

		public abstract int[] Costs { get; }

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
					if (value < 0)
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

		#region Abstract Methods

		public abstract int GetTotalCost();

		public abstract int GetCostOfNextLevel();

		#endregion

		#region Overrides

		public override string BizoName => "Gem";

		#endregion
	}
}
