using System;
using System.Collections.Generic;
using System.Text;
using VEntityFramework.Data;

namespace VEntityFramework.DataContext
{
	public class BizoCache
	{
		BizoCache() { }

		public static BizoCache Instance => fInstance ??= new BizoCache();
		static BizoCache fInstance;

		Dictionary<Type, Dictionary<string, VBusinessObject>> fCache = new Dictionary<Type, Dictionary<string, VBusinessObject>>();

		public bool Exists(VBusinessObject bizo)
		{
			return Exists(bizo.GetType(), bizo.XmlLocation);
		}

		public bool Exists(Type type, string name)
		{
			var cacheType = GetStorageType(type);

			if (cacheType != null)
			{
				return fCache.TryGetValue(cacheType, out var cache) && cache.TryGetValue(name, out _);
			}
			return false;
		}

		public void Add(VBusinessObject bizo)
		{
			var name = DirectoryManager.GetShortName(bizo.XmlLocation);
			var cacheType = GetStorageType(bizo.GetType());

			if (fCache.TryGetValue(cacheType, out var cache))
			{
#if DEBUG
				if (cache.TryGetValue(name, out _)) throw new DeveloperException($"A bizo with the name {name} already exists in this cache, why are we trying to add it again?");
#endif
				cache[name] = bizo;
			}
			else
			{
				var newCache = new Dictionary<string, VBusinessObject>
				{
					[name] = bizo
				};
				fCache[cacheType] = newCache;
			}
		}

		public VBusinessObject Retrieve(Type type, string name)
		{
			var cacheType = GetStorageType(type);
			if (fCache.TryGetValue(cacheType, out var cache) && cache.TryGetValue(name, out var bizo))
			{
				return bizo;
			}
			return null;
		}

		Type GetStorageType(Type type)
		{
			if (typeof(VBusinessObject).IsAssignableFrom(type) && type != typeof(VBusinessObject))
			{
				while (type.BaseType != typeof(VBusinessObject))
				{
					type = type.BaseType;
				}
				return type;
			}
#if DEBUG
			else
			{
				throw new DeveloperException($"Why are you trying to cache a {type.FullName}?");
			}
#else
			return null;
#endif
		}
	}
}
