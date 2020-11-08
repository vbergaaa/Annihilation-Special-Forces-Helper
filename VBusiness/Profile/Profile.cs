using System;
using VEntityFramework.Model;

namespace VBusiness.Profile
{
	public class Profile : VProfile
	{
		#region Validation

		protected override void RunPreSaveValidationCore()
		{
			base.RunPreSaveValidationCore();
			ValidateName();
		}

		void ValidateName()
		{
			if (Name == "")
			{
				Notifications.AddError("Profile Name cannot be left blank.");
			}
		}

		#endregion

		#region Implementation

		protected override string GetSaveNameForXML()
		{
			return Name;
		}

		#endregion
	}
}
