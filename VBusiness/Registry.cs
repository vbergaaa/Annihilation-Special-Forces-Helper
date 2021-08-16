using VEntityFramework.Data;
using VEntityFramework.Model;

namespace VBusiness
{
	public class Registry : VRegistry
	{
		#region Instance

		[VXML(false)]
		public static new Registry Instance => (Registry)VRegistry.Instance;

		#endregion

		protected override void SetDefaultValuesCore()
		{
			base.SetDefaultValuesCore();
			SyncProfileWithBank = true;
			SyncLoadoutsWithBank = true;
			SyncSoulsWithBank = true;
			LogVerbosity = LogState.Warning;
		}
	}
}
