using StarCodeDecryptor;
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
				fProfile = VDataContext.Instance.Get<Profile>();
			}
			return fProfile;
		}

		public override void OnLoaded()
		{

			if (Registry.Instance.SyncProfileWithBank)
			{
				try
				{
					var bankReader = new ASFBankDecoder(Registry.Instance.BankFileOverride);
					RankPoints = bankReader.RankPoints;
					Gems = bankReader.Gems;
					ModScore = GetTotalModScoresFromString(bankReader.ModScores);
				}
				catch
				{
					ErrorReporter.ReportDebug("Something went wrong reading the bank");
				}
			}
		}

		int GetTotalModScoresFromString(string modScores)
		{
			var totalScore = 0;
			while (modScores.Length > 0)
			{
				var score = modScores.Substring(0, 7);
				if (score == "?%465gd")
				{
					break;
				}
				totalScore += int.Parse(score);
				modScores = modScores.Substring(7);
			}
			return totalScore;
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
	}
}
