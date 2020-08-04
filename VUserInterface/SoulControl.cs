using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using VBusiness.Souls;
using VEntityFramework.Data;
using VEntityFramework;

namespace VUserInterface
{
	public partial class SoulControl : GroupBox
	{
		public SoulControl()
		{
			InitializeComponent();
		}

		public Soul Soul
		{
			get => fSoul ?? (fSoul = new EmptySoul());
			set
			{
				fSoul = value;
				UpdateBindings();
			}
		}
		Soul fSoul;

		void UpdateBindings()
		{
			this.BindingSource.DataSource = Soul;
			this.BindingSource.ResetBindings(false);
		}

		protected override void OnBindingContextChanged(EventArgs e)
		{
			base.OnBindingContextChanged(e);
			UpdateBindings();
		}

		List<string> SoulList
		{
			get
			{
				if (fSoulList == null)
				{
					var souls = new List<string>();
					souls.Add("None");
					souls.AddRange(new VDataContext().GetAllSoulNames());
					fSoulList = souls;
				}
				return fSoulList;
			}
		}
		List<string> fSoulList;

		void SoulChanged(object sender, EventArgs e)
		{
			var soulName = (string)SoulComboBox.SelectedItem;
			if (soulName != "None")
			{
				var soulSlot = int.Parse(soulName.Split("-")[0]);
				var eventArgs = new SoulChangedEventArgs() { SoulSlot = soulSlot };
				OnSoulChanged?.Invoke(this, eventArgs);
			}
		}

		public event EventHandler<SoulChangedEventArgs> OnSoulChanged;
	}
}
