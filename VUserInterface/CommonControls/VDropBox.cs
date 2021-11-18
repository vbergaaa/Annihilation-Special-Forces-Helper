using EnumsNET;
using System;
using System.Collections.Generic;
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
					var selectedItem = ComboBox.SelectedItem;
					isResettingList = true;
					fList = value;
					ComboBox.DataSource = value;

					isResettingList = false;

					if (selectedItem != null && value.Contains(ComboBox.SelectedItem))
					{
						SelectedIndex = value.IndexOf(selectedItem);
					}

					// I don't understand why this is needed, but it appears there is some 
					// cases where ComboBox.Items doesn't update to the datasource, and this
					// is the only way I can make this happen on demand.
					ComboBox.CreateControl();
				}
			}
		}
		List<object> fList;
		bool isResettingList;

		public int SelectedIndex
		{
			get => ComboBox.SelectedIndex;
			set
			{
				if (!isSettingIndexOnBaseComboBox)
				{
					isSettingIndexOnBaseComboBox = true;
					ComboBox.SelectedIndex = value;
					isSettingIndexOnBaseComboBox = false;
				}
			}
		}
		bool isSettingIndexOnBaseComboBox;

		public object SelectedValue
		{
			get => ComboBox.SelectedValue;
			set {
				if (value != null && ComboBox.Items.Contains(value) && !isSettingIndexOnBaseComboBox)
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
			if (!isResettingList)
			{
				if (!AllowSelectionOfStrings && ComboBox.SelectedItem is string)
				{
					if (oldIndex <= ComboBox.SelectedIndex)
					{
						ComboBox.SelectedIndex++;
					}
					else
					{
						ComboBox.SelectedIndex--;
					}
				}
				else
				{
					oldIndex = ComboBox.SelectedIndex;
					SelectedValueChanged?.Invoke(sender, e);
				}
			}
		}
		int oldIndex;

		void ComboBox_Format(object sender, ListControlConvertEventArgs e)
		{
			e.Value = e.ListItem is Enum value
				? Enums.AsString(value.GetType(), value, EnumFormat.Description, EnumFormat.Name)
				: e.ListItem.ToString();
		}

		#endregion

		public bool AllowSelectionOfStrings { get; set; }
	}
}
