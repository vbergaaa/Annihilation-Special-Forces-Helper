using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using VBusiness.HelperClasses;
using VBusiness.Loadouts;
using VBusiness.Souls;
using VEntityFramework.Data;

namespace VUserInterface
{
	public partial class MainForm : Form
	{
		public MainForm()
		{
			InitializeComponent();
		}

		void ChangeMainPanel(object sender, EventArgs e)
		{
			if (sender is Button button)
			{
				ProfilePanel.Visible = button.Name == ProfileButton.Name;
				LoadoutsPanel.Visible = button.Name == LoadoutsButton.Name;
				SoulsPanel.Visible = button.Name == SoulsButton.Name;
			}
		}

		void LoadoutsButton_Click(object sender, EventArgs e)
		{
			ChangeMainPanel(sender, e);
		}

		void SoulsButton_Click(object sender, EventArgs e)
		{
			ChangeMainPanel(sender, e);
		}

		void ProfileButton_Click(object sender, EventArgs e)
		{
			ChangeMainPanel(sender, e);
		}

		protected override void ScaleControl(SizeF factor, BoundsSpecified specified)
		{
		}
	}
}
