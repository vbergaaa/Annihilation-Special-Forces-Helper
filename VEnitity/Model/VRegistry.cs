using VEntityFramework.Attributes;
using VEntityFramework.Data;

namespace VEntityFramework.Model
{
	[TopLevelBusinessObject("Registry")]
	public class VRegistry : BusinessObject
	{
		#region Property

		#region SyncWithBank

		[VXML(true)]
		public bool SyncProfileWithBank
		{
			get => fSyncWithBank;
			set
			{
				if (fSyncWithBank != value)
				{
					fSyncWithBank = value;
					HasChanges = true;
					OnPropertyChanged(nameof(SyncProfileWithBank));
				}
			}
		}
		bool fSyncWithBank;

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
