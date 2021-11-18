using System;
using VEntityFramework.Model;
using VEntityFramework;
using VUserInterface.CommonControls;

namespace VUserInterface
{
	public partial class VLoadoutSoulsControl : DPIUserControl
	{
		public VLoadoutSoulsControl()
		{
			InitializeComponent();
		}

		public VLoadoutSouls Souls
		{
			get;
			set;
		}

		protected override void OnBindingContextChanged(EventArgs e)
		{
			base.OnBindingContextChanged(e);
			if (Souls != null)
			{
				bindingSource.DataSource = Souls;
				bindingSource.ResetBindings(true);
			}
		}

		void Soul1Control_OnSoulChanged(object sender, SoulChangedEventArgs e)
		{
			Souls.SoulSlot1 = e.SoulSlot;
		}
		void Soul2Control_OnSoulChanged(object sender, SoulChangedEventArgs e)
		{
			Souls.SoulSlot2 = e.SoulSlot;
		}
		void Soul3Control_OnSoulChanged(object sender, SoulChangedEventArgs e)
		{
			Souls.SoulSlot3 = e.SoulSlot;
		}

		void VLoadoutSoulsControl_Click(object sender, System.EventArgs e)
		{
			var powerSoulForm = new PowerSoulForm();
			powerSoulForm.SoulCollectable = Souls.SoulPowers;
			powerSoulForm.ShowDialog();
		}
	}
}
