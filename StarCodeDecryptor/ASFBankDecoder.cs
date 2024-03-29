﻿using System;
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

		public string ExtractValueFromXml(string section, string key)
		{
			var node = Bank.SelectSingleNode($"//Section[@name=\"{section}\"]/Key[@name=\"{key}\"]/Value");
			return node.Attributes[0].Value;
		}

		public string GetValue(string key1, string key2, int validates)
		{
			var count = ExtractValueFromXml(key1, key2); 
			count = Starcode.Decrypt(count, Key, validates);
			return count;
		}

		public bool[] SoulCollection
		{
			get
			{
				try
				{
					var souls = GetValue("745%GD", "CoC", 2);
					return Enumerable.Range(0, 54).Select(x => souls.Substring(x * 3, 3) == "?5?").ToArray();
				}
				catch
				{
					return new bool[54];
				}
			}
		}

		public bool[,] Challenges
		{
			get
			{
				try
				{
					var codes = new[]
					{
						"O00",
						"0OO",
						"0o0",
						"EXL",
						"ARC",
						"PSG",
						"SPR",
						"(((",
						")))",
						"JJJ",
						"QQQ",
						"CRB"
					};
					var strings = codes.Select(x => GetValue(x, "%?%?", 2)).ToArray();

					var array2 = new bool[45, 4];

					for (var i = 0; i <= 3; i++)
					{
						for (var j = 0; j <= 2; j++)
						{
							for (var k = 0; k < 15; k++)
							{
								if (strings[(i) * 3 + j].Substring(k * 6, 6) == "%$#?y4")
								{
									array2[j * 15 + k, i] = true;
								}
							}
						}
					}

					return array2;
				}
				catch
				{
					return new bool[45,4];
				}
			}
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

		// "Kappa", "????" - no idea.. ?$%yAtu6ruyhTdzgWR%EYe -- probably a rank

		// "BPR", "bleP" - experience, eg. 6095

		// var x = decoder.GetValue("6H7dRT", "HoH", 2); //3g$3g$3g$3g$3g$3g$3g$3g$3g$3g$3g$3g$3g$3g$3g$3g$3g$3g$3g$3g$3g$3g$3g$3g$3g$3g$3g$3g$3g$3g$3g$3g$3g$3g$3g$3g$3g$3g$3g$3g$3g$3g$3g$3g$3g$3g$3g$3g$3g$3g$3g$3g$3g$3g$3g$3g$3g$3g$3g$3g$?%465gd%Y
	}
}
