using System;
using VBusiness.Souls;
using VEntityFramework.Model;

namespace VBusiness.Profile
{
	public class Profile : VProfile
	{
		#region Properties

		#region Perk Points

		public override long PerkPoints
		{
			get
			{
				var roundedRp = Math.Floor(RankPoints / 1000m) * 1000;
				var roundedModScore = Math.Floor(ModScore / 100m) * 100;
				var modBonus = (long)(roundedRp * roundedModScore * 0.00005m);
				return RankPoints + modBonus;
			}
		}

		#endregion

		#region SoulCollection

		public override VSoulCollection SoulCollection => fSoulCollection ??= new SoulCollection();
		VSoulCollection fSoulCollection;

		#endregion

		#endregion

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
