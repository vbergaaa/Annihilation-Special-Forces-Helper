using VEntityFramework.Data;
using VEntityFramework.Model;

namespace VBusiness
{
	public class Registry : VRegistry
	{
		#region Instance

		[VXML(false)]
		public static Registry Instance => fRegistry ??= VDataContext.Instance.Get<Registry>();

		static Registry fRegistry;

		#endregion

		protected override void SetDefaultValuesCore()
		{
			base.SetDefaultValuesCore();
			SyncProfileWithBank = true;
			SyncLoadoutsWithBank = true;
			SyncSoulsWithBank = true;
		}
	}
}
