using System;
using VEntityFramework.Attributes;
using VEntityFramework.Data;

namespace VEntityFramework.Model
{
	[VXMLParent("PeckCollection")]
	public abstract class VPerk : VBusinessObject
	{
		#region Constructor

		public VPerk(VPerkCollection collection)
		{
			PerkCollection = collection;
		}

		internal VPerk() : base()
		{
		}

		#endregion

		#region Properties

		#region Name

		public string Name => $"{PerkName} Perk";

		#endregion

		#region Code

		[VXML(true)]
		public string Code => $"{Page}_{Position}";

		#endregion

		#region CurrentLevel

		[VXML(false)]
		public virtual short CurrentLevel
		{
			get => fCurrentLevel;
			set
			{
				if (value != fCurrentLevel)
				{
					fCurrentLevel = value;
					HasChanges = true;
					OnPropertyChanged(new System.ComponentModel.PropertyChangedEventArgs(nameof(CurrentLevel)));
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
					fDesiredLevel = value;
					HasChanges = true;
					OnPropertyChanged(new System.ComponentModel.PropertyChangedEventArgs(nameof(DesiredLevel)));
					OnLevelChanged(fDesiredLevel - oldValue);
				}
			}
		}
		short fDesiredLevel;

		#endregion

		#region PerkCollection

		[VXML(include:false)]
		public virtual VPerkCollection PerkCollection { get; internal set; }

		#endregion

		#region Abstract Getters

		protected abstract string PerkName { get; }

		public abstract string Description { get; }

		public abstract byte Page { get; }

		public abstract byte Position { get; }

		public abstract int StartingCost { get; }

		public abstract int IncrementCost { get; }

		public abstract short MaxLevel { get; }

		public abstract int RemainingCost { get; }

		public abstract int TotalCost { get; }

		public abstract int CurrentCost { get; }

		#endregion

		#endregion

		#region OnLevelChanged

		protected virtual void OnLevelChanged(int difference)
		{
		}

		#endregion

		#region Methods

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
