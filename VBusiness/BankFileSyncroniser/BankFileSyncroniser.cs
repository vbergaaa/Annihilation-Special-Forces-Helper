﻿using StarCodeDecryptor;
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
		static readonly ASFBankDecoder decoder = new(Registry.Instance.BankFileOverride);

		public static void UpdateProfile(VProfile profile = null)
		{
			try
			{
				if (profile == null)
				{
					profile = Profile.Profile.GetProfile();
				}
				profile.RankPoints = decoder.RankPoints;
				profile.AchievementCount = decoder.AchievementCount;
				profile.Gems = decoder.Gems;
				SetTotalModScoresFromString(profile.PlayerMods, decoder.ModScores);
				SetSoulCollection(profile.SoulCollection, decoder.SoulCollection);
				profile.ChallengePoints = GetChallengePointCount(decoder.Challenges);
				profile.Save();
				Log.Info("Successfully Updated Profile From Bank");
			}
			catch (Exception ex)
			{
				Log.Error("Failed to update profile from bank.", ex);
			}
		}

		private static int GetChallengePointCount(bool[,] challenges)
		{
			var cp = 0;
			var i = 0;
			foreach (var x in challenges)
			{
				i++;
				if (x)
				{
					cp++;
					if (i % 4 == 3)
					{
						cp++;
					}
				}
			}
			return cp;
		}

		private static void SetSoulCollection(VSoulCollection soulCollection, bool[] soulsInBank)
		{
			soulCollection.DiscoveredSouls.Clear();
			var uniqueSouls = Enum.GetValues<SoulType>().Where(x => x > VSoul.HighestNonUniqueSoul && x < VSoul.FirstEventSoul).ToArray();

			for (var i = 0; i < uniqueSouls.Length; i++)
			{
				if (soulsInBank[i])
				{
					soulCollection.DiscoveredSouls.Add(uniqueSouls[i]);
				}
			}
		}

		static void SetTotalModScoresFromString(VPlayerMods mods, string modScores)
		{
			mods.VeryEasy = GetNextValueFromString(ref modScores);
			mods.Easy = GetNextValueFromString(ref modScores);
			mods.Normal = GetNextValueFromString(ref modScores);
			mods.Hard = GetNextValueFromString(ref modScores);
			mods.VeryHard = GetNextValueFromString(ref modScores);
			mods.Insane = GetNextValueFromString(ref modScores);
			mods.Brutal = GetNextValueFromString(ref modScores);
			mods.Nightmare = GetNextValueFromString(ref modScores);
			mods.Torment = GetNextValueFromString(ref modScores);
			mods.Hell = GetNextValueFromString(ref modScores);
			mods.Titanic = GetNextValueFromString(ref modScores);
			mods.Mythic = GetNextValueFromString(ref modScores);
			mods.Divine = GetNextValueFromString(ref modScores);
			mods.Impossible = GetNextValueFromString(ref modScores);
			mods.ZeroV = GetNextValueFromString(ref modScores);
			mods.ZeroX = GetNextValueFromString(ref modScores);
			mods.PureBlack = GetNextValueFromString(ref modScores);
			mods.Annihilation = GetNextValueFromString(ref modScores);
		}

		private static int GetNextValueFromString(ref string modScores)
		{
			var score = modScores.Substring(0, 7);
			if (score == "?%465gd")
			{
				return 0;
			}

			var value = int.Parse(score);
			modScores = modScores.Substring(7);
			return value;
		}

		public static void UpdateAllLoadouts()
		{
			for (var i = 1; i <= 10; i++)
			{
				UpdateLoadout(i);
			}
		}

		static void UpdateLoadout(int i)
		{
			var loadoutName = GetLoadoutNameAndDeleteDuplicates(i);

			if (loadoutName != null)
			{
				VDataContext.ReadFromXML<Loadout>(loadoutName);
				Log.Info($"loaded loadout {loadoutName} into the cache, triggering a synchronisation if required.");
				return;
			}

			var loadout = VDataContext.NewWithoutCache<Loadout>();

			loadout.Slot = i;
			UpdateLoadout(loadout); ;
		}

		static string GetLoadoutNameAndDeleteDuplicates(int i)
		{
			var loadoutNames = VDataContext.GetAllFileNames<Loadout>().Where(x => x.StartsWith($"{i}-"));

			if (loadoutNames.Count() > 1)
			{
				var perkString = decoder.GetPerksStringAtSaveSlot(i);
				var loadoutName = perkString.Substring(0, 15);
				loadoutName = loadoutName.TrimStart('0');

				string matchingLoadout = null;
				var matchingLoadouts = loadoutNames.Where(x => x.ToLower() == $"{i}-{loadoutName}");
				if (matchingLoadouts.Count() == 1)
				{
					matchingLoadout = matchingLoadouts.Single();
				}

				foreach (var loadout in loadoutNames.Where(x => x != matchingLoadout))
				{
					VDataContext.Delete<Loadout>(loadout);
				}
				return matchingLoadout;
			}

			return loadoutNames.FirstOrDefault();
		}

		public static void UpdateLoadout(VLoadout loadout)
		{
			try
			{
				SetPerksFromString(loadout);
				loadout.Save();
				Log.Info($"Successfully updated loadout {loadout.Slot} from Bank");

			}
			catch (Exception ex)
			{
				Log.Error($"Failed to update loadout {loadout.Slot} from bank.", ex);
			}
		}

		static void SetPerksFromString(VLoadout loadout)
		{
			if (loadout.Slot > 0 && loadout.Slot <= 10)
			{
				var perkString = decoder.GetPerksStringAtSaveSlot(loadout.Slot);

				var loadoutName = perkString.Substring(0, 15);
				loadoutName = loadoutName.TrimStart('0');
				perkString = perkString.Substring(15);
				if (loadoutName.ToLower() != loadout.Name.ToLower())
				{
					loadout.Name = loadoutName;
				}
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

		public static void UpdateAllSouls()
		{
			for (var i = 1; i <= 10; i++)
			{
				try
				{
					UpdateSoul(i);
				}
				catch (Exception ex)
				{
					Log.Error($"Failed to sync soul {i}", ex);
				}
			}
		}

		static void UpdateSoul(int saveSlot)
		{
			var soulNames = VDataContext.GetAllFileNames<Soul>();
			var soulName = soulNames.FirstOrDefault(x => x.StartsWith($"{saveSlot}-"));

			var soulString = decoder.GetSoulString(saveSlot);
			if (!string.IsNullOrEmpty(soulString))
			{
				var soul = GetSoulFromString(saveSlot, soulName, soulString);
				soulString = soulString.Substring(7);
				soul.Attack = GetNextValue(ref soulString);
				soul.AttackSpeed = GetNextValue(ref soulString);
				soul.Vitals = GetNextValue(ref soulString);
				soul.Minerals = GetNextValue(ref soulString) * 1000;
				soul.Kills = GetNextValue(ref soulString) * 100;
				soul.Armor = GetNextValue(ref soulString);
				soul.CriticalChance = GetNextValue(ref soulString);
				soul.CriticalDamage = GetNextValue(ref soulString);
				soul.Save();
				Log.Info($"Successfully synced soul {saveSlot} with bank");
			}
			else
			{
				Log.Info($"Skipped syncing soul {saveSlot} as it appears to be empty");
			}
		}

		static int GetNextValue(ref string soulString)
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
				soul = VDataContext.ReadFromXML<Soul>(soulName);

				if (soul.Type != soulType)
				{
					VDataContext.Delete<Soul>(soulName);
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
				"EA" => GetEventSoul(tier),
				_ => SoulType.None
			};
		}

		private static SoulType GetEventSoul(int tier)
		{
			return tier switch
			{
				99 => SoulType.ChristmasEvent,
				_ => SoulType.None,
			};
		}
	}
}
