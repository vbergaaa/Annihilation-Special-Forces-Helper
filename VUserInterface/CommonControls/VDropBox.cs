using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace VUserInterface.CommonControls
{
	public partial class VDropBox : VUserControl
	{
		public VDropBox()
		{
			InitializeComponent();
		}

		public List<object> List
		{
			get => fList;
			set
			{
				if (fList != value)
				{
					fList = value;
					this.ComboBox.DataSource = value;
				}
			}
		}
		List<object> fList;

		public int SelectedIndex
		{
			get => ComboBox.SelectedIndex;
			set => ComboBox.SelectedIndex = value;
		}

		public object SelectedValue
		{
			get => ComboBox.SelectedValue;
		}

		#region Events

		public event EventHandler SelectedValueChanged;

		void ComboBox_SelectedValueChanged(object sender, EventArgs e)
		{
			SelectedValueChanged?.Invoke(this, e);
		}

		#endregion
	}
}
