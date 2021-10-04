using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace VUserInterface.CommonControls
{
	public partial class VSelectList : DPIUserControl
	{
		public VSelectList()
		{
			InitializeComponent();
		}

		public override string Text
		{
			get => base.Text;
			set
			{
				base.Text = value;
				Label.Text = value;
			}
		}

		void Delete_Click(object sender, EventArgs e)
		{
			OnDeleteClicked();
		}

		void Open_Click(object sender, EventArgs e)
		{
			OnOpenClicked();
		}

		void New_Click(object sender, EventArgs e)
		{
			OnNewClicked();
		}

		void SelectedIndex_Changed(object sender, EventArgs e)
		{
			OnSelectedIndex_Changed();
		}

		protected virtual void OnDeleteClicked() { }
		protected virtual void OnOpenClicked() { }
		protected virtual void OnNewClicked() { }
		protected virtual void OnSelectedIndex_Changed() { }

		protected BindingList<object> Collection => fCollection ??= new BindingList<object>();
		BindingList<object> fCollection;

		public int SelectedIndex
		{
			get => ListBox?.SelectedIndex ?? -1;
			set
			{
				if (ListBox != null)
				{
					ListBox.SelectedIndex = value;
				}
			}
		}
	}
}
