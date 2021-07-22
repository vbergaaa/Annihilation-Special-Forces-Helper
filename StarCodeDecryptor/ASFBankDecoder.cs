using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Xml;

namespace StarCodeDecryptor
{
	public class ASFBankDecoder
	{
		public ASFBankDecoder(string bankPathOverride)
		{
			this.fBankPathOverride = bankPathOverride;
		}

		#region Key

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
		string fKey;

		#endregion

		#region RankPoints

		public int RankPoints
		{
			get
			{
				var rp = ExtractValueFromXml("RGB", "Pleb");
				rp = Starcode.Decrypt(rp, Key, 10);
				return Convert.ToInt32(rp);
			}
		}

		#endregion

		#region Gems

		public int Gems
		{
			get
			{
				var gems = ExtractValueFromXml("WTF", "^?^?");
				gems = Starcode.Decrypt(gems, Key, 3);
				return Convert.ToInt32(gems);
			}
		}

		#endregion

		#region Bank

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

		string fBankPathOverride = null;

		string GetDefaultBankFilePath()
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

		readonly Dictionary<string, string> keyMappings = new Dictionary<string, string>
		{
			{ "E%YRTHty5e54h84t75ysthD?Y%U"     ,"T$EY5hd54g4wy%YHDTrst4yu5" },
			{ "E$Z%?yh54drt6YEH%YUZJ"           ,"E$Y%eht47568W4yzZUHT" },
			{ "$E?%E$YHDZEY$%Z$?T%EYHWUYSYFJH"  ,"$EZYUjtdn5z4tw4zyrdU%YHD" },
			{ "$#E?%$%$?*WYDHRYUSY$"            ,"SRY54zYRTY54u7RTYUEje65YSYtd" },
			{ "$RS?e%D?uJd5rsYd5H?JytDYSR"      ,"EZ%?R?UEuhes45e57E%?Y%" }
		};

		#endregion
	}
}
