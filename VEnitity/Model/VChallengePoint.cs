﻿using VEntityFramework.Data;

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

		#region Loadout

		[VXML(false)]
		public VChallengePointCollection ChallengePointCollection { get; private set; }

		#endregion

		#region CurrentLevel

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

		#endregion

		#region MinValue

		public virtual int MinValue { get; }

		#endregion

		#region MaxValue

		public virtual int MaxValue { get; }

		#endregion

		#region CostIncrement

		public virtual int CostIncrement => 1;

		#endregion

		#region NextLevelCost

		public virtual int NextLevelCost { get; }

		#endregion

		#region TotalCost

		public virtual int TotalCost { get; }

		#endregion

		#region Color

		public abstract CPColor Color { get; }

		#endregion

		#region Tier

		public abstract CPTier Tier { get; }

		#endregion

		#region Name

		public abstract string Name { get; }

		[VXML(true)]
		public string Key => Name;

		#endregion

		#endregion

		#region Methods

		#region CPLevelChanged

		public abstract void OnCPLevelChanged(int difference);

		#endregion

		#endregion

		#region Implementation

		public override string BizoName => "ChallengePoint";

		#endregion

		int fCurrentLevel;
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
