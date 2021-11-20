using VEntityFramework.Attributes;
using VEntityFramework.Data;

namespace VEntityFramework.Model
{
	[TopLevelBusinessObject("Profile")]
	public abstract class VProfile : BusinessObject
	{
		#region Properties

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
					OnPropertyChanged(nameof(Name));
				}
			}
		}
		string fName;


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
					OnPropertyChanged(nameof(RankPoints));
				}
			}
		}
		long fRankPoints;

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
					OnPropertyChanged(nameof(Rank));
				}
			}
		}
		PlayerRank fRank;


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
					OnPropertyChanged(nameof(ModScore));
				}
			}
		}
		int fModifierScore;


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
					OnPropertyChanged(nameof(Gems));
				}
			}
		}
		int fGems;

		[VXML(true)]
		public int ChallengePoints
		{
			get => fChallengePoints;
			set {
				if (fChallengePoints != value)
				{
					fChallengePoints = value;
					HasChanges = true;
					OnPropertyChanged(nameof(ChallengePoints));
				}
			}
		}
		int fChallengePoints;

		[VXML(true)]
		public int AchievementCount
		{
			get => fAchievementCount;
			set {
				if (fAchievementCount != value)
				{
					fAchievementCount = value;
					HasChanges = true;
					OnPropertyChanged(nameof(AchievementCount));
				}
			}
		}
		int fAchievementCount;

		public virtual long PerkPoints { get; }

		public virtual VSoulCollection SoulCollection { get; }

		#endregion

		#region Implementation

		public override string BizoName => "Profile";

		#endregion
	}
}
