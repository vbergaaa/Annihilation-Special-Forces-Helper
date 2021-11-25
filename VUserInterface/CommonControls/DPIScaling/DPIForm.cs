using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VUserInterface.CommonControls
{
	public partial class DPIForm : Form
	{
		public DPIForm()
		{
			InitializeComponent();
		}

		protected override void ScaleControl(SizeF factor, BoundsSpecified specified)
		{
		}
	}
}
