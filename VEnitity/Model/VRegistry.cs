using VEntityFramework.Attributes;
using VEntityFramework.Data;

namespace VEntityFramework.Model
{
	[TopLevelBusinessObject("Registry")]
	public class VRegistry : BusinessObject
	{
		public static VRegistry Instance
		{
			get
			{
				if (fInstance == null)
				{
					fInstance = VDataContext.Instance.Get<VRegistry>();
				}
				return fInstance;
			}
		}
		[VXML(false)]
		static VRegistry fInstance;

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

		[VXML(true)]
		public bool SyncSoulsWithBank
		{
			get => fSyncSoulsWithBank;
			set
			{
				if (fSyncSoulsWithBank != value)
				{
					fSyncSoulsWithBank = value;
					HasChanges = true;
					OnPropertyChanged(nameof(SyncSoulsWithBank));
				}
			}
		}
		bool fSyncSoulsWithBank;

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

		public override string BizoName => "Registry";

		[VXML(true)]
		public LogState LogVerbosity { get; set; }
	}
}
