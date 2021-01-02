﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace VUserInterface.CommonControls
{
	public partial class VLabel : VUserControl
	{
		public VLabel() : base()
		{
			InitializeComponent();
		}

		public ContentAlignment TextAlign
		{
			get => Label.TextAlign;
			set
			{
				Label.TextAlign = value;
			}
		}

		public override string Text { get => Label.Text; set => Label.Text = value; }
	}
}
