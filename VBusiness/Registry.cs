using System;
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

		public override int BackupFrequency
		{
			get => BackupFrequency_Editable ? base.BackupFrequency : 0;
			set
			{
				if (value <= 0)
				{
					base.BackupFrequency = 0;
				}
				else if (value < 1000)
				{
					base.BackupFrequency = 1000;
				}
				else
				{
					base.BackupFrequency = (int)Math.Floor((value / 1000.0)) * 1000;
				}
			}
		}

		public bool BackupFrequency_Editable => SyncProfileWithBank;
	}
}
