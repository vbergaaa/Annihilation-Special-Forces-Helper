using EnumsNET;
using System;
using System.Linq;
using System.Windows.Forms;
using VEntityFramework.Interfaces;
using VEntityFramework.Model;
using VUserInterface.CommonControls;

namespace VUserInterface
{
	public partial class SoulCollectionControl : DPIUserControl
	{
		public SoulCollectionControl()
		{
			InitializeComponent();
		}

		public ISoulCollectable Souls
		{
			get => fSouls;
			set
			{
				if (fSouls != value && value != null)
				{
					fSouls = value;
					BindingSource.DataSource = Souls;
					UpdateSoulControls();
				}
			}
		}
		ISoulCollectable fSouls;

		public int Page
		{
			get => fPage == 0 ? 1 : fPage;
			set
			{
				fPage = value;
				UpdateSoulControls();
			}
		}
		int fPage;

		void UpdateSoulControls(SoulType toggleSoul = SoulType.None)
		{
			if (!isUpdatingControls)
			{
				isUpdatingControls = true;

				ToggleSoul(toggleSoul);

				foreach (var control in AllSoulControls)
				{
					var index = Array.IndexOf(AllSoulControls, control);
					var soulType = GetSoulTypeFromPosition(Page, index + 1);
					control.SoulType = soulType;
					control.Visible = Souls.GetBindingVisibility(soulType);
					control.Text = soulType.AsString(EnumFormat.Description, EnumFormat.Name);
					control.Selected = Souls.GetBindingValue(soulType);
				}
				isUpdatingControls = false;
			}
		}

		void ToggleSoul(SoulType soulType)
		{
			if (soulType != SoulType.None)
			{
				Souls.ToggleSoul(soulType);
			}
		}

		bool isUpdatingControls;

        static SoulType GetSoulTypeFromPosition(int page, int position)
		{
			var highestNonUnique = (int)VSoul.HighestNonUniqueSoul;
			var highestUnique = (int)Enums.GetValues<SoulType>().Last();
			var selectedSoul = highestNonUnique + 15 * (page - 1) + position;

			return selectedSoul > highestUnique ? SoulType.None : (SoulType)highestNonUnique + 15 * (page - 1) + position;
		}

		public void OnPageButtonClick(object sender, EventArgs e)
		{
			if (sender is Button button && int.TryParse(button.Text, out var page))
			{
				Page = page;
			}
		}

		#region SoulControl_SelectedChanged

		void SoulControl_SelectedChanged(object sender, System.EventArgs e)
		{
			var soulType = ((SoulTypeEventArgs)e).SoulType;
			UpdateSoulControls(soulType);
		}

		#endregion

		#region AllSoulControls

		SingleSoulControl[] AllSoulControls => fAllSoulControls ??= new SingleSoulControl[]
		{
			SoulControl1,
			SoulControl2,
			SoulControl3,
			SoulControl4,
			SoulControl5,
			SoulControl6,
			SoulControl7,
			SoulControl8,
			SoulControl9,
			SoulControl10,
			SoulControl11,
			SoulControl12,
			SoulControl13,
			SoulControl14,
			SoulControl15
		};
		SingleSoulControl[] fAllSoulControls;

		#endregion
	}
}
