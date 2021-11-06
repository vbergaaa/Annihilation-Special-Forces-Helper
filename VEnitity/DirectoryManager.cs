using System;
using System.IO;
using System.Linq;
using System.Reflection;
using VEntityFramework.Attributes;
using VEntityFramework.Data;

namespace VEntityFramework
{
	public static class DirectoryManager
	{
		public const string ApplicationName = "AnnihilationSpecialForcesHelper";

		internal static string GetFullPathWithExtension<T>(string fileName)
		{
			var path = GetFullPath<T>(fileName);
			if (string.IsNullOrEmpty(Path.GetExtension(path)))
			{
				path += ".xml";
			}
			return path;
		}

		internal static string GetFullPath<T>(string fileName)
		{
			return GetFullDirectory<T>() + fileName;
		}

		internal static string GetFullDirectory<T>()
		{
			return GetFullDirectory(typeof(T));
		}

		internal static string GetFullDirectory(Type bizoType)
		{
			var atr = (TopLevelBusinessObjectAttribute)bizoType.GetCustomAttribute(typeof(TopLevelBusinessObjectAttribute));
			if (atr != null)
			{
				var pathHint = atr.PathHint;
				var rootDirectory = $"{Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData)}\\{ApplicationName}";
#if DEBUG
				rootDirectory = Directory.GetCurrentDirectory();
#endif
				var fullDirectory = $"{rootDirectory}\\{pathHint}\\";
				EnsureDirectoryExists(fullDirectory);
				return fullDirectory;
			}

			throw new DeveloperException("We shouldn't be trying to retrieve objects that aren't TopLevelBusinessObjects. Please implement the attribute to define the storage location");
		}

		internal static string GetShortName(string xmlLocation)
		{
			var path = Path.GetFileNameWithoutExtension(xmlLocation);
			var fileName = path.Split(new char[] { '/', '\\' }).Last();
			return fileName;
		}

		static internal bool CheckFileExists<T>(string fileName)
		{
			return File.Exists(GetFullPathWithExtension<T>(fileName));
		}

		public static void EnsureDirectoryExists(string desiredPath)
		{
			if (!Directory.Exists(desiredPath))
			{
				try
				{
					Directory.CreateDirectory(desiredPath);
				}
				catch
				{
					throw new IOException($"An error occured while attempting to create the file path {desiredPath}\r\nPlease create manually and try again.");
				}
			}
		}
	}
}
