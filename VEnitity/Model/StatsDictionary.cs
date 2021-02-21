using System.Collections.Generic;

namespace VEntityFramework.Model
{
	public class StatsDictionary : Dictionary<string, double>
	{
		public void Update(string key, double amount)
		{
			key = key.ToUpper();

			if (ContainsKey(key))
			{
				this[key] += amount;
			}
			else
			{
				Add(key, amount);
			}

#if DEBUG
			if (this[key] < 0)
			{
				throw new System.Exception($"Why do you have less then 0 DR? key:{key}, value:{this[key]}");
			}
#endif
		}
	}
}