using System;

namespace VEntityFramework
{
	public class OnLoadedEventArgs : EventArgs
	{
		public OnLoadedEventArgs(string fileName)
		{
			FileName = fileName;
		}

		public string FileName { get; set; }
	}
}
