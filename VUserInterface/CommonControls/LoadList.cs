using System;
using VBusiness.HelperClasses;
using VEntityFramework.Data;
using VEntityFramework.DataContext;

namespace VUserInterface.CommonControls
{
	public class LoadList : VSelectList
	{
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

		protected override void OnDeleteClicked()
		{
			var name = (string)ListBox.SelectedItem;
			if (name != null)
			{
				VDataContext.Instance.Delete(BizoType, name);
				RefreshList();
			}
		}

		protected override void OnOpenClicked()
		{
			var context = VDataContext.Instance;
			var name = (string)ListBox.SelectedItem;
			if (name != null)
			{
				var method = typeof(VDataContext).GetMethod(nameof(VDataContext.ReadFromXML), new Type[] { typeof(string) });
				var generic = method.MakeGenericMethod(BizoType);
				var bizo = (BusinessObject)generic.Invoke(context, new object[] { name });

				if (bizo != null)
				{
					var form = VForm.Create(bizo);
					form.OnSaved += FormSaved;
					form.Show();
				}
			}
		}

		protected override void OnNewClicked()
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
	}
}
