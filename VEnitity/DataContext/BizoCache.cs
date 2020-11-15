using System;
using System.Collections.Generic;
using System.Linq;
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

		#region Exists

		public bool Exists(VBusinessObject bizo)
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

		#region Retrieve

		public VBusinessObject Retrieve(Type type, string name)
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
