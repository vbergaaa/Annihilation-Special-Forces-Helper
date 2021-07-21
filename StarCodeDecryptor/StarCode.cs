using System;

namespace StarCodeDecryptor
{
	public static class Starcode
	{
		readonly static string fAlphabet = "0123456789abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ!$%/()=?,.-;:_^#+* @{[]}|~`";

		public static string Decrypt(string s, string key, int hashCount)
		{
			s = RemoveHash(s, hashCount);
			return Decrypt(s, key);
		}

		public static string Decrypt(string s, string key)
		{
			int ls = s.Length;
			int lk = key.Length;
			string ret = "";
			for (int i = 0; i < ls; ++i)
			{
				ret += shiftBackward(s.Substring(i, 1), key.Substring(i % lk, 1));
			}
			return ret;
		}

		public static string RemoveHash(string lp_string, int lp_securityLevel)
		{
			return lp_string.Substring(lp_securityLevel);
		}

		static string chr(int i)
		{
			return fAlphabet.Substring(i, 1);
		}

		static int ord(string i)
		{
			return fAlphabet.IndexOf(i);
		}

		static string shiftBackward(string s, string k)
		{
			int c = ord(s) - ord(k);
			return c < 0
				? chr((c + fAlphabet.Length) % fAlphabet.Length)
				: chr(c % fAlphabet.Length);
		}
	}
}

