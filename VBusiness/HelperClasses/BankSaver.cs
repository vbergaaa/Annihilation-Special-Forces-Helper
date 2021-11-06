using StarCodeDecryptor;
using System;
using System.IO;
using System.Linq;
using VEntityFramework;
using VEntityFramework.Model;

namespace VBusiness
{
	public static class BankSaver
	{
		public static void CopyBankFile()
		{
			var bankFileDirectory = $"{ASFBankDecoder.GetDefaultBankFilePath()}";
			var backupDirectory = $"{Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData)}\\{DirectoryManager.ApplicationName}\\Backups\\{GetBackupName()}.SC2Bank";

			CopyFile(bankFileDirectory, backupDirectory);
		}

		static string GetBackupName()
		{
			string rank = GetRankString();
			var rp = GetRPString();
			return $"{rp}_{rank}";
		}

		private static string GetRankString()
		{
			var rank = Profile.Profile.GetProfile().Rank;
			var rankCode = rank < PlayerRank.Dominator
				? string.Join("", rank.GetDescription().Split(" ").Select(x => x[0]))
				: GetRankCodeAfterDom(rank);
			return rankCode.ToUpper();
		}

		private static string GetRPString()
		{
			var rp = Profile.Profile.GetProfile().RankPoints;
			var bankFrequency = Registry.Instance.BackupFrequency;
			if (bankFrequency == 0) { return string.Empty; }

			// this is a mess, so it gets a comment.
			// there is an easier way to do this.
			// consider an rp of 173050.
			// if we have a frequency of 1000, we want 0.173m
			// if we have a frequency of 5000, we want 0.170m <- notice the '0' here, because our freq is in the thousandths
			// if we have a frequency of 10000, we want 0.17m <- notice no '0' here, because our freq is in the ten thousandths
			var roundedRP = rp / bankFrequency * bankFrequency;
			var decimalRP = roundedRP / 1000000.0;
			var rpString = decimalRP.ToString();

			var desiredDecimals = 6 - (bankFrequency.ToString().Length - bankFrequency.ToString().Trim('0').Length);
			if (desiredDecimals > 0)
			{
				// this is to add any additional zeros that would have been excluded by the rounding
				var decimals = rpString.Split('.').Last().Length;
				while (desiredDecimals > decimals)
				{
					rpString += "0";
					decimals += 1;
				}
			}

			return rpString + "m";
		}

		private static string GetRankCodeAfterDom(PlayerRank rank)
		{
			var rankName = rank.GetDescription();
			var words = rankName.Split(" ");
			return words.Count() == 1
				? words.Last().Substring(0, 3)
				: words.First().Substring(0, 1) + words.Last().Substring(0, 3);
		}

		static void CopyFile(string sourceFile, string targetFile)
		{
			var targetDirectory = Path.GetDirectoryName(targetFile);
			DirectoryManager.EnsureDirectoryExists(targetDirectory);

			try
			{
				if (!File.Exists(targetFile))
				{
					File.Copy(sourceFile, targetFile, true);
				}
			}
			catch (Exception ex)
			{
				Log.Error("Failed to backup bank file", ex);
				throw;
			}
		}
	}
}
