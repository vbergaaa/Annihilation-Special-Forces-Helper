using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using VEntityFramework.Model;
using VEntityFramework;

namespace VUserInterface
{
	public partial class VSoulCollectionControl : UserControl
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
			this.bindingSource.DataSource = Souls;
			//this.bindingSource.ResetBindings(true);
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
