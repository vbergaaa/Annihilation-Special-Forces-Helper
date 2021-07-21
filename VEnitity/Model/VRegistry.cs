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

		#endregion

		public override string BizoName => "Registry";
	}
}
