using EnumsNET;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using VEntityFramework.Model;

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
			set
			{
				ComboBox.SelectedIndex = value;
			}
		}

		public object SelectedValue
		{
			get
			{
				return ComboBox.SelectedValue;
			}
			set
			{
				if (ComboBox.Items.Contains(value))
				{
					var index = ComboBox.Items.IndexOf(value);
					SelectedIndex = index;
				}
			}
		}

		protected override void OnSizeChanged(EventArgs e)
		{
			base.OnSizeChanged(e);
		}

		#region Events

		public event EventHandler SelectedValueChanged;

		void ComboBox_SelectedValueChanged(object sender, EventArgs e)
		{
			SelectedValueChanged?.Invoke(this, e);
		}

		void ComboBox_Format(object sender, ListControlConvertEventArgs e)
		{
			e.Value = e.ListItem switch
			{
				SoulType value => value.AsString(EnumFormat.Description, EnumFormat.Name),
				PlayerRank value => value.AsString(EnumFormat.Description, EnumFormat.Name),
				DifficultyLevel value => value.AsString(EnumFormat.Description, EnumFormat.Name),
				_ => e.ListItem.ToString()
			};
		}

		#endregion
	}
}
