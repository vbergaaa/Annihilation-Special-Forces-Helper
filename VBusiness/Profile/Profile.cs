using VEntityFramework.Model;

namespace VBusiness.Profile
{
	public class Profile : VProfile
	{
		#region Implementation

		protected override string GetSaveNameForXML()
		{
			return Name;
		}

		#endregion
	}
}
