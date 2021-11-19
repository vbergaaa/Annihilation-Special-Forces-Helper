using System.Collections.Generic;

namespace VEntityFramework.Data
{
	public class NotificationManager
	{
		public List<string> Errors => fErrors ??= new List<string>();
		List<string> fErrors;

		public List<string> Prompts => fPrompts ??= new List<string>();
		List<string> fPrompts;

		public void AddError(string error)
		{
			Errors.Add(error);
		}

		public void AddPrompt(string prompt)
		{
			Prompts.Add(prompt);
		}

		public bool HasErrors()
		{
			return Errors.Count > 0;
		}

		public bool HasPrompt()
		{
			return Prompts.Count > 0;
		}

		internal void Clear()
		{
			fErrors = null;
			fPrompts = null;
		}
	}
}