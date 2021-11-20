using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Xml;

namespace StarCodeDecryptor
{
	public class ASFBankDecoder
	{
		public ASFBankDecoder(string bankPathOverride)
		{
			fBankPathOverride = bankPathOverride;
		}

		public string Key
		{
			get
			{
				if (fKey == null)
				{
					var rawKey = ExtractValueFromXml("uoY", "kcuF");
					rawKey = Starcode.Decrypt(rawKey, "whyyouhackin", 3);
					var mappedKey = keyMappings[rawKey];
					var playerKey = ExtractValueFromXml("645", "%$Y");
					fKey = Starcode.Decrypt(playerKey, mappedKey, 3);
				}
				return fKey;
			}
		}

		public string GetSoulString(int soulSlot)
		{
			var charAsInt = 64 + soulSlot;
			var lastChar = (char)charAsInt;
			var encryptedSoul = ExtractValueFromXml("01020304050", "LUOS" + lastChar);
			var soulString = Starcode.Decrypt(encryptedSoul, Key, 5);

			return soulString;
		}

		string fKey;

		public int RankPoints
		{
			get
			{
				var rp = ExtractValueFromXml("RGB", "Pleb");
				rp = Starcode.Decrypt(rp, Key, 10);
				return Convert.ToInt32(rp);
			}
		}

		public int AchievementCount
		{
			get 
			{
				var count = ExtractValueFromXml("FTW", "?^?^");
				count = Starcode.Decrypt(count, Key, 3);
				return Convert.ToInt32(count);			
			}
		}

		public int Gems
		{
			get
			{
				var gems = ExtractValueFromXml("WTF", "^?^?");
				gems = Starcode.Decrypt(gems, Key, 3);
				return Convert.ToInt32(gems);
			}
		}

		public string GetPerksStringAtSaveSlot(int slot)
		{
			var bankString = ExtractValueFromXml("Loads", $"Save{slot}");
			return Starcode.Decrypt(bankString, Key, 3);
		}

		public string ModScores
		{
			get {
				var gems = ExtractValueFromXml("534G%#", "H*H");
				gems = Starcode.Decrypt(gems, Key, 2);
				return gems;
			}
		}

		public bool[][] GetAchievements()
		{
			var diffs = new[]
			{
				"101",
				"102",
				"103",
				"201",
				"202",
				"301",
				"400",
				"499",
				"598",
				"699",
				"800",
				"999",
				"505",
				"000",
				"808",
				"555",
				"123",
				"321"  
			};

			var pages = diffs.Select(x => Starcode.Decrypt(ExtractValueFromXml(x, "?^^?"), Key, 2));
			return pages.Select(page => Enumerable.Range(0, 15).Select(x => page.Substring(x * 6, 6) == "857548").ToArray()).ToArray();
		}

		public XmlDocument Bank
		{
			get
			{
				if (fBank == null)
				{
					var xml = new XmlDocument();
					var xmlPath = string.IsNullOrEmpty(fBankPathOverride)
						? GetDefaultBankFilePath()
						: fBankPathOverride;
					xml.Load(xmlPath);
					fBank = xml;
				}
				return fBank;
			}
		}
		XmlDocument fBank;
		readonly string fBankPathOverride = null;

		public static string GetDefaultBankFilePath()
		{
			var rootLocation = $"{Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)}\\StarCraft II\\Accounts";
			var files = Directory.GetFiles(rootLocation, "TDUHOK.SC2Bank", SearchOption.AllDirectories);
			return files.FirstOrDefault();
		}

		string ExtractValueFromXml(string section, string key)
		{
			var node = Bank.SelectSingleNode($"//Section[@name=\"{section}\"]/Key[@name=\"{key}\"]/Value");
			return node.Attributes[0].Value;
		}

		readonly Dictionary<string, string> keyMappings = new()
        {
			{ "E%YRTHty5e54h84t75ysthD?Y%U"     ,"T$EY5hd54g4wy%YHDTrst4yu5" },
			{ "E$Z%?yh54drt6YEH%YUZJ"           ,"E$Y%eht47568W4yzZUHT" },
			{ "$E?%E$YHDZEY$%Z$?T%EYHWUYSYFJH"  ,"$EZYUjtdn5z4tw4zyrdU%YHD" },
			{ "$#E?%$%$?*WYDHRYUSY$"            ,"SRY54zYRTY54u7RTYUEje65YSYtd" },
			{ "$RS?e%D?uJd5rsYd5H?JytDYSR"      ,"EZ%?R?UEuhes45e57E%?Y%" }
		};

		// "685$TYSHS", "YGSDG%$" -modscore codes, e.g, 77XYZ77XYZ77XYZ77XYZ77XYZ77XYZ77XYZ77XYZ77XYZ55XDZ55XDZ444XZ444XZ111SZ555SS00000000000000056d$%54eyh%?

		// "Kappa", "????" - no idea.. ?$%yAtu6ruyhTdzgWR%EYe 

		// "BPR", "bleP" - experience, eg. 6095
	}
}
