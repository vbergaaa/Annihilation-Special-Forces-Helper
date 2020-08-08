using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using VEntityFramework.Data;

namespace VEntityFramework.Model
{
	public abstract class VSoulCollection : VBusinessObject
	{
		#region Souls

		public virtual Dictionary<int, string> Souls { get; }

		#endregion

		#region Soul 1

		[VXML(true)]
		public virtual int SoulSlot1
		{
			get => fSoulSlot1;
			set
			{
				if (fSoulSlot1 != value)
				{
					fSoulSlot1 = value;
					HasChanges = true;
				}
			}
		}
		int fSoulSlot1;

		[VXML(false)]
		public virtual VSoul Soul1
		{
			get => fSoul1;
			protected set
			{
				OnSoulDeactivated(fSoul1?.DeactivateStats);
				fSoul1 = value;
				OnSoulActivated(fSoul1?.ActivateStats);
				OnPropertyChanged(new System.ComponentModel.PropertyChangedEventArgs(nameof(Soul1)));
			}
		}
		VSoul fSoul1;

		#endregion

		#region Soul 2

		[VXML(true)]
		public virtual int SoulSlot2
		{
			get => fSoulSlot2;
			set
			{
				if (fSoulSlot2 != value)
				{
					fSoulSlot2 = value;
					HasChanges = true;
				}
			}
		}
		int fSoulSlot2;

		[VXML(false)]
		public virtual VSoul Soul2
		{
			get => fSoul2;
			protected set
			{
				OnSoulDeactivated(fSoul2?.DeactivateStats);
				fSoul2 = value;
				OnSoulActivated(fSoul2?.ActivateStats);
				OnPropertyChanged(new System.ComponentModel.PropertyChangedEventArgs(nameof(Soul2)));
			}
		}
		VSoul fSoul2;

		#endregion

		#region Soul 3

		[VXML(true)]
		public virtual int SoulSlot3
		{
			get => fSoulSlot3;
			set
			{
				if (fSoulSlot3 != value)
				{
					fSoulSlot3 = value;
					HasChanges = true;
				}
			}
		}
		int fSoulSlot3;

		[VXML(false)]
		public virtual VSoul Soul3
		{
			get => fSoul3;
			protected set
			{
				OnSoulDeactivated(fSoul3?.DeactivateStats);
				fSoul3 = value;
				OnSoulActivated(fSoul3?.ActivateStats);
				OnPropertyChanged(new System.ComponentModel.PropertyChangedEventArgs(nameof(Soul3)));
			}
		}
		VSoul fSoul3;

		#endregion

		#region Events

		void OnSoulActivated(Action<VStats> modification)
		{
			if (modification != null)
			{
				var e = new StatsEventArgs() { Modification = modification };
				SoulActivated?.Invoke(this, e); 
			}
		}

		void OnSoulDeactivated(Action<VStats> modification)
		{
			if (modification != null)
			{
				var e = new StatsEventArgs() { Modification = modification };
				SoulDeactivated?.Invoke(this, e); 
			}
		}

		public event EventHandler<StatsEventArgs> SoulActivated;

		public event EventHandler<StatsEventArgs> SoulDeactivated;

		#endregion

		public override string BizoName => "SoulCollection";
	}
}
