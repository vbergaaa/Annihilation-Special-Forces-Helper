using System;

namespace VModel
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

		[VXML(include: true)]
		public string Code => $"{Page}_{Position}";

		public short CurrentLevel { get; set; }

		#region DesiredLevel


		[VXML(include:true)]
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
				}
			}
		}
		short fDesiredLevel;

		public abstract int Cost { get; }

		#endregion

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
