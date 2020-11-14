using System;
using System.ComponentModel;
using VEntityFramework.Attributes;
using VEntityFramework.Data;

namespace VEntityFramework.Model
{
	[TopLevelBusinessObject("Profile")]
	public abstract class VProfile : VBusinessObject
	{
		#region Properties

		#region Name

		[VXML(true)]
		public string Name
		{
			get => fName;
			set
			{
				if (fName != value)
				{
					fName = value;
					HasChanges = true;
					OnPropertyChanged(new PropertyChangedEventArgs(nameof(Name)));
				}
			}
		}
		string fName;

		#endregion

		#region RankPoints


		[VXML(true)]
		public long RankPoints
		{
			get => fRankPoints;
			set
			{
				if (fRankPoints != value)
				{
					fRankPoints = value;
					HasChanges = true;
					OnPropertyChanged(new PropertyChangedEventArgs(nameof(RankPoints)));
				}
			}
		}
		long fRankPoints;

		#endregion

		#region Rank


		[VXML(true)]
		public PlayerRank Rank
		{
			get => fRank;
			set
			{
				if (fRank != value)
				{
					fRank = value;
					HasChanges = true;
					OnPropertyChanged(new PropertyChangedEventArgs(nameof(Rank)));
				}
			}
		}
		PlayerRank fRank;

		#endregion

		#region ModifierScore


		[VXML(true)]
		public int ModScore
		{
			get => fModifierScore;
			set
			{
				if (fModifierScore != value)
				{
					fModifierScore = value;
					HasChanges = true;
					OnPropertyChanged(new PropertyChangedEventArgs(nameof(ModScore)));
				}
			}
		}
		int fModifierScore;

		#endregion

		#region Gems


		[VXML(true)]
		public int Gems
		{
			get => fGems;
			set
			{
				if (fGems != value)
				{
					fGems = value;
					HasChanges = true;
					OnPropertyChanged(new PropertyChangedEventArgs(nameof(Gems)));
				}
			}
		}
		int fGems;

		#endregion

		#region ChallengePoints


		[VXML(true)]
		public int ChallengePoints
		{
			get => fChallengePoints;
			set
			{
				if (fChallengePoints != value)
				{
					fChallengePoints = value;
					HasChanges = true;
					OnPropertyChanged(new PropertyChangedEventArgs(nameof(ChallengePoints)));
				}
			}
		}
		int fChallengePoints;

		#endregion

		#region PerkPoints

		public virtual long PerkPoints { get; }

		#endregion

		#endregion

		#region Implementation

		public override string BizoName => "Profile";

		#endregion
	}
}
