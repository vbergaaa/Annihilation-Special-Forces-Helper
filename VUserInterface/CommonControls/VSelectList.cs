using System;
using System.Collections;
using System.Linq;

namespace VUserInterface.CommonControls
{
	public class VSelectList : VLoadList
	{
		public VSelectList()
		{
			InitializeComponent();
		}

		void InitializeComponent()
		{
			this.OpenButton.Visible = false;
			this.NewButton.Click += NewButton_Click;
			this.DeleteButton.Click += DeleteButton_Click;
		}

		public IList List
		{
			get => fList;
			set
			{
				if (value != null)
				{
					var existingIndex = value.Count == CurrentIndex ? value.Count - 1 : CurrentIndex;
					fList = value;
					RefreshList(existingIndex);
				}
			}
		}
		IList fList;

		public void RefreshList(int existingIndex)
		{
			Collection.Clear();
			var list = (List?.Cast<object>().Select(l => l.ToString()) ?? new string[0]).ToArray();
			foreach (var entry in list)
			{
				Collection.Add(entry);
			}
			CurrentIndex = existingIndex;
		}



		void NewButton_Click(object sender, EventArgs e)
		{
			NewButtonClicked?.Invoke(sender, e);
		}
		public event EventHandler NewButtonClicked;

		void DeleteButton_Click(object sender, EventArgs e)
		{
			DeleteButtonClicked?.Invoke(sender, e);
		}
		public event EventHandler DeleteButtonClicked;
	}
}
