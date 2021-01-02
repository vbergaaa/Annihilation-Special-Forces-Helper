using System;
using VEntityFramework.Model;
using VEntityFramework;
using VUserInterface.CommonControls;

namespace VUserInterface
{
	public partial class VSoulCollectionControl : DPIUserControl
	{
		public VSoulCollectionControl()
		{
			InitializeComponent();
		}

		public VSoulCollection Souls
		{
			get;
			set;
		}

		protected override void OnBindingContextChanged(EventArgs e)
		{
			base.OnBindingContextChanged(e);
			if (Souls != null)
			{
				this.bindingSource.DataSource = Souls;
				this.bindingSource.ResetBindings(true);
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
	}
}
