using System;
using System.Collections.Generic;
using System.Linq;
using VEntityFramework.Data;

namespace VEntityFramework.DataContext
{
	public class BizoCache
	{
		BizoCache() { }

		public static BizoCache Instance => fInstance ??= new BizoCache();
		static BizoCache fInstance;

		Dictionary<Type, Dictionary<string, BusinessObject>> fCache = new Dictionary<Type, Dictionary<string, BusinessObject>>();

		#region Exists

		public bool Exists(BusinessObject bizo)
		{
			return Exists(bizo.GetType(), bizo.XmlLocation);
		}

		public bool Exists(Type type, string name)
		{
			name = name != null ? DirectoryManager.GetShortName(name) : null;
			var cacheType = GetStorageType(type);

			if (cacheType != null)
			{
				if (fCache.TryGetValue(cacheType, out var cache))
				{
					return name != null && cache.TryGetValue(name, out _)
						|| name == null && cache.Values.Any();
				}
			}
			return false;
		}

		#endregion

		public void Add(BusinessObject bizo)
		{
			var name = DirectoryManager.GetShortName(bizo.XmlLocation);
			var cacheType = GetStorageType(bizo.GetType());

			if (fCache.TryGetValue(cacheType, out var cache))
			{
				ErrorReporter.ReportDebug(cache.TryGetValue(name, out _), $"A bizo with the name {name} already exists in this cache, why are we trying to add it again?");
				cache[name] = bizo;
			}
			else
			{
				var newCache = new Dictionary<string, BusinessObject>
				{
					[name] = bizo
				};
				fCache[cacheType] = newCache;
			}
		}

		#region Retrieve

		public BusinessObject Retrieve(Type type, string name)
		{
			var cacheType = GetStorageType(type);

			if (name != null)
			{
				if (fCache.TryGetValue(cacheType, out var cache) && cache.TryGetValue(name, out var bizo))
				{
					return bizo;
				}
			}
			else
			{
				if (fCache.TryGetValue(cacheType, out var cache))
				{
					return cache.Values.First();
				}
			}

			return null;
		}

        #endregion

        static Type GetStorageType(Type type)
		{
			if (typeof(BusinessObject).IsAssignableFrom(type) && type != typeof(BusinessObject))
			{
				while (type.BaseType != typeof(BusinessObject))
				{
					type = type.BaseType;
				}
				return type;
			}
			else
			{
				ErrorReporter.ReportDebug($"Why are you trying to cache a {type.FullName}?");
				return null;
			}
		}
	}
}
