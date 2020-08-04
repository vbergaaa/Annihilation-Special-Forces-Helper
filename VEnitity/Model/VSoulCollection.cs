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
			set
			{
				fSoul1 = value;
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
			set
			{
				fSoul2 = value;
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
			set
			{
				fSoul3 = value;
				OnPropertyChanged(new System.ComponentModel.PropertyChangedEventArgs(nameof(Soul3)));
			}
		}
		VSoul fSoul3;

		#endregion

		public override string BizoName => "SoulCollection";
	}
}
