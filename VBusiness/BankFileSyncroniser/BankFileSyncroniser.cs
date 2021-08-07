using StarCodeDecryptor;
using System;
using System.Linq;
using VBusiness.Loadouts;
using VBusiness.Perks;
using VBusiness.Souls;
using VEntityFramework;
using VEntityFramework.Data;
using VEntityFramework.Model;

namespace VBusiness
{
	public static class BankFileSyncroniser
	{

		static readonly ASFBankDecoder decoder = new ASFBankDecoder(Registry.Instance.BankFileOverride);
		#region Profile

		public static void UpdateProfile(VProfile profile = null)
		{
			try
			{
				if (profile == null)
				{
					profile = Profile.Profile.GetProfile();
				}
				profile.RankPoints = decoder.RankPoints;
				profile.Gems = decoder.Gems;
				profile.ModScore = GetTotalModScoresFromString(decoder.ModScores);
				profile.Save();
			}
			catch
			{
				ErrorReporter.ReportDebug("Something went wrong reading the bank");
			}
		}

		static int GetTotalModScoresFromString(string modScores)
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

		#endregion

		#region Perks

		public static void UpdateAllLoadouts()
		{
			for (var i = 1; i <= 10; i++)
			{
				UpdateLoadout(i);
			}
		}

		static void UpdateLoadout(int i)
		{
			var loadoutNames = VDataContext.Instance.GetAllFileNames<Loadout>();
			var loadoutName = loadoutNames.FirstOrDefault(x => x.StartsWith($"{i}-"));
			var loadout = loadoutName != null
				? VDataContext.Instance.ReadFromXML<Loadout>(loadoutName)
				: VDataContext.Instance.NewWithoutCache<Loadout>();

			loadout.Slot = i;
			UpdateLoadout(loadout);
		}

		public static void UpdateLoadout(VLoadout loadout)
		{
			try
			{
				SetPerksFromString(loadout);
			}
			catch (Exception ex)
			{
				ErrorReporter.ReportDebug($"Failed to set perks from bank file: ${ex.Message}");
			}
			loadout.Save();
		}

		static void SetPerksFromString(VLoadout loadout)
		{
			if (loadout.Slot > 0 && loadout.Slot <= 10 && Registry.Instance.SyncLoadoutsWithBank)
			{
				var perkString = decoder.GetPerksStringAtSaveSlot(loadout.Slot);
				var loadoutName = perkString.Substring(0, 15);
				loadoutName = loadoutName.TrimStart('0');
				loadout.Name = loadoutName;
				perkString = perkString.Substring(15);
				var oldShouldRestrict = loadout.ShouldRestrict;
				loadout.ShouldRestrict = false;
				foreach (var perk in ((PerkCollection)loadout.Perks).AllPerks)
				{
					if (!string.IsNullOrEmpty(perkString))
					{
						var perkLength = Math.Max(2, perk.MaxLevel.ToString().Length);
						var perkValue = int.Parse(perkString.Substring(0, perkLength));
						perkString = perkString.Substring(perkLength);

						perk.DesiredLevel = (short)perkValue;
					}
				}
				loadout.ShouldRestrict = oldShouldRestrict;
			}
		}

		#endregion

		#region Souls

		public static void UpdateAllSouls()
		{
			for (var i = 1; i <= 10; i++)
			{
				UpdateSoul(i);
			}
		}

		static void UpdateSoul(int saveSlot)
		{
			var soulNames = VDataContext.Instance.GetAllFileNames<Soul>();
			var soulName = soulNames.FirstOrDefault(x => x.StartsWith($"{saveSlot}-"));

			var soulString = decoder.GetSoulString(saveSlot);
			if (!string.IsNullOrEmpty(soulString))
			{
				var soul = GetSoulFromString(saveSlot, soulName, soulString);
				soulString = soulString.Substring(7);
				soul.Attack = GetNextValue(ref soulString, soul);
				soul.AttackSpeed = GetNextValue(ref soulString, soul);
				soul.Vitals = GetNextValue(ref soulString, soul);
				soul.Minerals = GetNextValue(ref soulString, soul) * 1000;
				soul.Kills = GetNextValue(ref soulString, soul) * 100;
				soul.Armor = GetNextValue(ref soulString, soul);
				soul.CriticalChance = GetNextValue(ref soulString, soul);
				soul.CriticalDamage = GetNextValue(ref soulString, soul);
				soul.Save();
			}
		}

		static int GetNextValue(ref string soulString, Soul soul)
		{
			if (soulString.Length >= 2)
			{
				var value = int.Parse(soulString.Substring(0, 2));

				soulString = soulString.Length >= 5
					? soulString.Substring(5)
					: string.Empty;
				return value;
			}
			else
			{
				return 0;
			}
		}

		private static Soul GetSoulFromString(int saveSlot, string soulName, string soulString)
		{
			var typeCode = soulString.Substring(0, 4);
			var soulType = GetSoulTypeFromSoulCode(typeCode);

			Soul soul;
			if (soulName != null)
			{
				soul = VDataContext.Instance.ReadFromXML<Soul>(soulName);

				if (soul.Type != soulType)
				{
					VDataContext.Instance.Delete<Soul>(soulName);
					soul = Soul.New(soulType, null);
				}
			}
			else
			{
				soul = Soul.New(soulType, null);
			}

			soul.SaveSlot = saveSlot;
			return soul;
		}

		static SoulType GetSoulTypeFromSoulCode(string typeCode)
		{
			var tier = int.Parse(typeCode.Substring(2)); // this represents rarity, e.g DemonicSoul/HPB soul
			var type = typeCode.Substring(0, 2);

			return type switch
			{
				"RG" => (SoulType)tier,
				"RA" => VSoul.HighestNonUniqueSoul + (tier * 3 - 2),
				"RB" => VSoul.HighestNonUniqueSoul + (tier * 3 - 1),
				"RC" => VSoul.HighestNonUniqueSoul + (tier * 3 - 0),
				_ => SoulType.None
			};
		}

		#endregion
	}
}
