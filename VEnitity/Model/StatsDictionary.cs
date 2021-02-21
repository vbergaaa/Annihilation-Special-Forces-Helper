using System;
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

		public void UpdateExpontiental(string key, double value, int quantity)
		{
			key = key.ToUpper();

			if (quantity > 0)
			{
				AddMultiplesToDictionary(key, value, quantity);
			}
			else
			{
				RemoveMulitpleFromDictionary(key, value, quantity);
			}
		}

		void AddMultiplesToDictionary(string key, double value, int quantity)
		{
			if (!MultipleKeyDict.ContainsKey(key))
			{
				MultipleKeyDict.Add(key, 0);
			}

			for (var i = 0; i < quantity; i++)
			{
				MultipleKeyDict[key]++;
				var mainDictKey = key + MultipleKeyDict[key];

#if DEBUG
				if (ContainsKey(mainDictKey))
				{
					throw new Exception($"This Key should be free. Key:{mainDictKey}");
				}
#endif
				Update(mainDictKey, value);
			}
		}

		void RemoveMulitpleFromDictionary(string key, double value, int quantity)
		{
			if (!MultipleKeyDict.ContainsKey(key))
			{
#if DEBUG
				throw new Exception($"Can't remove something that never existed. Key:{key}");
#else

				return;
#endif
			}

			for (var i = 0; i > quantity; i--)
			{
				var mainDictKey = key + MultipleKeyDict[key];

#if DEBUG
				if (MultipleKeyDict[key] == 0)
				{
					throw new Exception($"Zero Keys shouldn't exist, we shouldn't try to remove them. Key={key}, quantity={quantity}, i={i}");
				}
				if (!this.ContainsKey(mainDictKey))
				{
					throw new Exception($"We shouldn't be trying to remove values that don't exist Key={key}, quantity={quantity}, i={i}");
				}
#endif
				if (this.ContainsKey(mainDictKey))
				{
					this.Remove(mainDictKey);
					MultipleKeyDict[key]--;
				}
			}
		}

		IDictionary<string, int> MultipleKeyDict => fMultipleKeyDict ??= new Dictionary<string, int>();
		IDictionary<string, int> fMultipleKeyDict;
	}
}