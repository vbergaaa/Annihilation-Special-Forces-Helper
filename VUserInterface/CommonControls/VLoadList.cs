using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using VEntityFramework.Data;
using VBusiness.HelperClasses;
using VEntityFramework.DataContext;

namespace VUserInterface.CommonControls
{
	public partial class VLoadList : UserControl
	{
		public VLoadList()
		{
			InitializeComponent();
		}

		#region Properties

		public Type BizoType
		{
			get => fBizoType;
			set
			{
				fBizoType = value;
				RefreshList();
			}
		}
		Type fBizoType;

		public override string Text 
		{ 
			get => base.Text;
			set
			{
				base.Text = value;
				Label.Text = value;
			} 
		}

		#endregion

		#region Events

		void Delete_Click(object sender, EventArgs e)
		{
			var name = (string)ListBox.SelectedItem;
			if (name != null)
			{
				VDataContext.Instance.Delete(BizoType, name);
				RefreshList();
			}
		}

		void Open_Click(object sender, EventArgs e)
		{
			var context = VDataContext.Instance;
			var name = (string)ListBox.SelectedItem;
			if (name != null)
			{
				var method = typeof(VDataContext).GetMethod(nameof(VDataContext.ReadFromXML), new Type[] { typeof(string) });
				var generic = method.MakeGenericMethod(BizoType);
				var bizo = (VBusinessObject)generic.Invoke(context, new object[]{ name });

				if (bizo != null)
				{
					var form = VForm.Create(bizo);
					form.OnSaved += FormSaved;
					form.Show();
				}
			}
		}

		void New_Click(object sender, EventArgs e)
		{
			var bizo = BizoCreator.Create(BizoType);
			var form = VForm.Create(bizo);
			form.OnSaved += FormSaved;
			form.Show();
		}

		void FormSaved(object sender, EventArgs e)
		{
			RefreshList();
		}

		void RefreshList()
		{
			Collection.Clear();
			var list = VDataContext.Instance.GetAllFileNames(BizoType);
			var orderedList = OrderHelper.OrderNamesByKey(list);
			foreach (var entry in orderedList)
			{
				Collection.Add(entry);
			}
		}

		public BindingList<string> Collection => fCollection ??= new BindingList<string>();
		BindingList<string> fCollection;

		#endregion
	}
}
