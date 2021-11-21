using System;
using VBusiness.PlayerRanks;
using VBusiness.Souls;
using VEntityFramework;
using VEntityFramework.Data;
using VEntityFramework.Model;

namespace VBusiness.Profile
{
	public class Profile : VProfile
	{
		#region GetProfile

		public static Profile GetProfile()
		{
			if (fProfile == null)
			{
				fProfile = VDataContext.Get<Profile>();
			}
			return fProfile;
		}

		static Profile fProfile;

		#endregion

		#region Properties

		#region Perk Points

		public override long PerkPoints
		{
			get
			{
				var roundedRp = Math.Floor(RankPoints / 1000m) * 1000;
				var roundedModScore = Math.Floor(ModScore / 100m) * 100;
				var modBonus = (long)(roundedRp * roundedModScore * 0.00005m);
				return RankPoints + modBonus;
			}
		}

		#endregion

		#region SoulCollection

		public override VSoulCollection SoulCollection
		{
			get
			{

				if (fSoulCollection == null)
				{
					fSoulCollection = new SoulCollection(this);
				}
				return fSoulCollection;
			}
		}
		VSoulCollection fSoulCollection;

		#endregion

		#endregion

		#region Validation

		protected override void RunPreSaveValidationCore()
		{
			base.RunPreSaveValidationCore();
			ValidateName();
		}

		void ValidateName()
		{
			if (Name == "")
			{
				Notifications.AddError("Profile Name cannot be left blank.");
			}
		}

		#endregion

		#region Implementation

		protected override string GetSaveNameForXML()
		{
			return Name;
		}

		internal DifficultyLevel GetRecommendedDifficulty()
		{
			return Rank.GetRecommendedDifficulty();
		}

		#endregion

#if DEBUG
		public DisposableAction TemporarilyModifyProfile(int rp, int modScore)
		{
			var oldRp = RankPoints;
			var oldModScore = ModScore;
			RankPoints = rp;
			ModScore = modScore;

			return new DisposableAction(() =>
			{
				RankPoints = oldRp;
				ModScore = oldModScore;
			});
		}
#endif
	}
}
