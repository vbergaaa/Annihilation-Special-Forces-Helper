using System.ComponentModel;
using VEntityFramework.Attributes;
using VEntityFramework.Data;

namespace VEntityFramework.Model
{
	[TopLevelBusinessObject("Profile")]
	public abstract class VProfile : BusinessObject
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
					OnPropertyChanged(nameof(Name));
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
					OnPropertyChanged(nameof(RankPoints));
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
					OnPropertyChanged(nameof(Rank));
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
					OnPropertyChanged(nameof(ModScore));
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
					OnPropertyChanged(nameof(Gems));
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
					OnPropertyChanged(nameof(ChallengePoints));
				}
			}
		}
		int fChallengePoints;

		#endregion

		#region PerkPoints

		public virtual long PerkPoints { get; }

		#endregion

		#region SoulCollection

		public virtual VSoulCollection SoulCollection { get; }

		#endregion

		#endregion

		#region Implementation

		public override string BizoName => "Profile";

		#endregion
	}
}
