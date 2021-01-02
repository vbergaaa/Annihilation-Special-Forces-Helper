using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using VBusiness.HelperClasses;
using VBusiness.Souls;
using VEntityFramework.Data;
using VEntityFramework.Model;

namespace VUserInterface
{
	public partial class SoulForm : VForm
	{
		public SoulForm(VBusinessObject bizo) : base(bizo)
		{
			if (bizo != null && !(bizo is Soul))
			{
				throw new InvalidOperationException("Soul form must only accept a soul bizo");
			}
			else
			{
				InitializeComponent();
				InitializeParent(bizo);
			}
		}

		private void InitializeParent(VBusinessObject bizo)
		{
			Parent = (Soul)bizo ?? new EmptySoul();
			RefreshSoulTypeList();
		}

		private void RefreshSoulTypeList()
		{
		//	if (Parent != null)
		//	{
		//		TypeDropBox.SelectedValueChanged -= TypeComboBox_SelectionChanged;
		//		var items = TypeDropBox.Items;
		//		TypeDropBox.SelectedIndex = (int)Parent.Type;
		//		TypeDropBox.SelectedValueChanged += TypeComboBox_SelectionChanged;
		//		isParentInitialised = true;
		//	}
		}
		bool isParentInitialised;

		public new Soul Parent
		{
			get => (Soul)base.Parent;
			set
			{
				int oldSaveSlot = GetSaveSlotFromTextBoxSafe();
				base.Parent = value;
				if (base.Parent != null && isParentInitialised)
				{
					((Soul)base.Parent).SaveSlot = oldSaveSlot;
				}
				UpdatingBindingSource();
			}
		}

		private int GetSaveSlotFromTextBoxSafe()
		{
			return int.TryParse(SaveSlotTextBox.Text, out var saveSlot)
				? saveSlot
				: 0;
		}

		private void UpdatingBindingSource()
		{
			if (Parent != null)
			{
				this.BindingSource.DataSource = Parent;
				this.BindingSource.ResetBindings(false);
			}
		}

		#region Soul Type

		List<object> SoulTypesList
		{
			get => fSoulTypesList ?? (fSoulTypesList = BindingHelper<SoulType>.ConvertForBinding(new SoulLookup().GetSouls()));
		}
		List<object> fSoulTypesList;

		#endregion

		#region Event Handlers

		void TypeComboBox_SelectionChanged(object sender, EventArgs e)
		{
			var value = TypeDropBox.SelectedValue;

			if (value is SoulType type && (Parent == null || Parent.Type != type))
			{
				Parent = Soul.New(type, null);
			}
		}

		#endregion
	}
}
