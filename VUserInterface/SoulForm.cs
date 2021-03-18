using EnumsNET;
using System;
using System.Collections.Generic;
using System.Linq;
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

		void InitializeParent(VBusinessObject bizo)
		{
			Parent = (Soul)bizo ?? new EmptySoul();
			RefreshSoulTypeList();
		}

		void RefreshSoulTypeList()
		{
			if (Parent != null)
			{
				TypeDropBox.SelectedValueChanged -= TypeComboBox_SelectionChanged;
				var items = TypeDropBox.List;
				TypeDropBox.SelectedIndex = (int)Parent.Type;
				TypeDropBox.SelectedValueChanged += TypeComboBox_SelectionChanged;
				isParentInitialised = true;
			}
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

		public VLoadoutSouls SoulCollection { get; set; }

		int GetSaveSlotFromTextBoxSafe()
		{
			return int.TryParse(SaveSlotTextBox.Text, out var saveSlot)
				? saveSlot
				: 0;
		}

		void UpdatingBindingSource()
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
			get => fSoulTypesList ??= GetOrderedSoulsList();
		}

		List<object> fSoulTypesList;

		List<object> GetOrderedSoulsList()
		{
			var list = new List<object>();
			list.Add(SoulType.None);
			for (var i = 1; i <= (int)VSoul.HighestNonUniqueSoul; i++)
			{
				list.Add("");
				list.Add((SoulType)i);
				list.Add((SoulType)((i * 3) + (int)VSoul.HighestNonUniqueSoul - 2));
				list.Add((SoulType)((i * 3) + (int)VSoul.HighestNonUniqueSoul - 1));
				list.Add((SoulType)((i * 3) + (int)VSoul.HighestNonUniqueSoul - 0));
			}
			return list;
		}

		#endregion

		#region Event Handlers

		void TypeComboBox_SelectionChanged(object sender, EventArgs e)
		{
			var value = TypeDropBox.SelectedValue;

			if (value is SoulType type && (Parent == null || Parent.Type != type))
			{
				Parent = Soul.New(type, SoulCollection);
			}
		}

		#endregion
	}
}
