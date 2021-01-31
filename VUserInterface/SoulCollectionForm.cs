using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using VEntityFramework.Data;

namespace VUserInterface
{
	public partial class SoulCollectionForm : VForm
	{
		public SoulCollectionForm(VBusinessObject bizo) : base(bizo)
		{
			InitializeComponent();
		}
	}
}
