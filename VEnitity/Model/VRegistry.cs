using VEntityFramework.Attributes;
using VEntityFramework.Data;

namespace VEntityFramework.Model
{
	[TopLevelBusinessObject("Registry")]
	public class VRegistry : BusinessObject
	{
		#region Property

		#region SyncProfileWithBank

		[VXML(true)]
		public bool SyncProfileWithBank
		{
			get => fSyncProfileWithBank;
			set
			{
				if (fSyncProfileWithBank != value)
				{
					fSyncProfileWithBank = value;
					HasChanges = true;
					OnPropertyChanged(nameof(SyncProfileWithBank));
				}
			}
		}
		bool fSyncProfileWithBank;

		#endregion

		#region SyncLoadoutsWithBank

		[VXML(true)]
		public bool SyncLoadoutsWithBank
		{
			get => fSyncLoadoutsWithBank;
			set
			{
				if (fSyncLoadoutsWithBank != value)
				{
					fSyncLoadoutsWithBank = value;
					HasChanges = true;
					OnPropertyChanged(nameof(SyncLoadoutsWithBank));
				}
			}
		}
		bool fSyncLoadoutsWithBank;

		#endregion

		#region BankFileOverride

		[VXML(true)]
		public string BankFileOverride
		{
			get => fBankFileOverride;
			set
			{
				if (fBankFileOverride != value)
				{
					fBankFileOverride = value;
					HasChanges = true;
					OnPropertyChanged(nameof(BankFileOverride));
				}
			}
		}
		string fBankFileOverride;

		#endregion

		#endregion

		public override string BizoName => "Registry";
	}
}
