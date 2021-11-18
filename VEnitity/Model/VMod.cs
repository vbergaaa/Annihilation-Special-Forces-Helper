using VEntityFramework.Data;

namespace VEntityFramework.Model
{
	public abstract class VMod : BusinessObject
	{
		public VMod(VModsCollection collection) : base(collection)
		{
			Mods = collection;
		}

		#region Loadout

		[VXML(false)]
		public virtual VLoadout Loadout => Mods.Loadout;

		[VXML(false)]
		public virtual VModsCollection Mods { get; }

		#endregion

		#region Properties

		#region Score

		public abstract int Score { get; }

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
						OnModLevelChanged(fCurrentLevel - oldValue);
						Mods?.RefreshPropertyBinding(nameof(Mods.TotalModScore));
						HasChanges = true;
					}
					OnPropertyChanged(nameof(CurrentLevel));
				}
			}
		}

		short fCurrentLevel;

		public static short MaxValue => 10;

		#endregion

		#region Name

		public virtual string Name => BizoName;

		#endregion

		#endregion

		protected virtual void OnModLevelChanged(int diff) { }
	}
}
