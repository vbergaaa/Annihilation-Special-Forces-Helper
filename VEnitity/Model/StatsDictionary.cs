using System;
using System.Collections.Generic;

namespace VEntityFramework.Model
{
	public class StatsDictionary : Dictionary<string, double>
	{
		public StatsDictionary(string debugName)
		{
			this.debugName = debugName;
		}

		readonly string debugName;

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

			ErrorReporter.ReportDebug(
				$"Why do you have less then 0 of this Stat? Dictionary:{debugName}, key:{key}, value:{this[key]}",
				() => key == "CORE" ? this[key] + 17 < 0: this[key] < 0);
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

				ErrorReporter.ReportDebug(ContainsKey(mainDictKey), $"This Key should be free. Key:{mainDictKey}");

				Update(mainDictKey, value);
			}
		}

		void RemoveMulitpleFromDictionary(string key, double value, int quantity)
		{
			if (!MultipleKeyDict.ContainsKey(key))
			{
				ErrorReporter.ReportDebug($"Can't remove something that never existed. Key:{key}");
				return;
			}

			for (var i = 0; i > quantity; i--)
			{
				var mainDictKey = key + MultipleKeyDict[key];

				ErrorReporter.ReportDebug(MultipleKeyDict[key] == 0, $"Zero Keys shouldn't exist, we shouldn't try to remove them. Key={key}, quantity={quantity}, i={i}");
				ErrorReporter.ReportDebug(!this.ContainsKey(mainDictKey), $"We shouldn't be trying to remove values that don't exist Key={key}, quantity={quantity}, i={i}");

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