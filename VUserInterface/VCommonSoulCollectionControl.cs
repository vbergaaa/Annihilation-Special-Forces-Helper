using EnumsNET;
using System;
using System.Linq;
using System.Windows.Forms;
using VBusiness.Profile;
using VEntityFramework.Model;

namespace VUserInterface
{
	public partial class VCommonSoulCollectionControl : UserControl
	{
		public VCommonSoulCollectionControl()
		{
			InitializeComponent();
			SetBindingSource();
			UpdateSoulTextsAndVisiblity();
			UpdateDataBindings();
		}

		void SetBindingSource()
		{
			BindingSource.DataSource = Souls;
		}

		public VSoulCollection Souls
		{
			get => Profile.GetProfile().SoulCollection;
		}

		public int Page
		{
			get => fPage == 0 ? 1 : fPage;
			set
			{
				fPage = value;
				UpdateDataBindings();
				UpdateSoulTextsAndVisiblity();
			}
		}

		void UpdateSoulTextsAndVisiblity()
		{
			UpdateTextAndVisiblity(SoulControl1, GetSoulTypeFromPosition(Page, 1));
			UpdateTextAndVisiblity(SoulControl2, GetSoulTypeFromPosition(Page, 2));
			UpdateTextAndVisiblity(SoulControl3, GetSoulTypeFromPosition(Page, 3));
			UpdateTextAndVisiblity(SoulControl4, GetSoulTypeFromPosition(Page, 4));
			UpdateTextAndVisiblity(SoulControl5, GetSoulTypeFromPosition(Page, 5));
			UpdateTextAndVisiblity(SoulControl6, GetSoulTypeFromPosition(Page, 6));
			UpdateTextAndVisiblity(SoulControl7, GetSoulTypeFromPosition(Page, 7));
			UpdateTextAndVisiblity(SoulControl8, GetSoulTypeFromPosition(Page, 8));
			UpdateTextAndVisiblity(SoulControl9, GetSoulTypeFromPosition(Page, 9));
			UpdateTextAndVisiblity(SoulControl10, GetSoulTypeFromPosition(Page, 10));
			UpdateTextAndVisiblity(SoulControl11, GetSoulTypeFromPosition(Page, 11));
			UpdateTextAndVisiblity(SoulControl12, GetSoulTypeFromPosition(Page, 12));
			UpdateTextAndVisiblity(SoulControl13, GetSoulTypeFromPosition(Page, 13));
			UpdateTextAndVisiblity(SoulControl14, GetSoulTypeFromPosition(Page, 14));
			UpdateTextAndVisiblity(SoulControl15, GetSoulTypeFromPosition(Page, 15));
		}

		void UpdateTextAndVisiblity(SingleSoulControl soulControl, SoulType soulType)
		{
			soulControl.Visible = soulType != SoulType.None;
			
			if (soulControl.Visible)
			{
				soulControl.Text = soulType.AsString(EnumFormat.Description, EnumFormat.Name);
			}
		}

		int fPage;

		void UpdateDataBindings()
		{
			ClearExistingBindings();
			AddNewBindings();
		}

		void ClearExistingBindings()
		{
			SoulControl1.DataBindings.Clear();
			SoulControl2.DataBindings.Clear();
			SoulControl3.DataBindings.Clear();
			SoulControl4.DataBindings.Clear();
			SoulControl5.DataBindings.Clear();
			SoulControl6.DataBindings.Clear();
			SoulControl7.DataBindings.Clear();
			SoulControl8.DataBindings.Clear();
			SoulControl9.DataBindings.Clear();
			SoulControl10.DataBindings.Clear();
			SoulControl11.DataBindings.Clear();
			SoulControl12.DataBindings.Clear();
			SoulControl13.DataBindings.Clear();
			SoulControl14.DataBindings.Clear();
			SoulControl15.DataBindings.Clear();
		}

		void AddNewBindings()
		{
			SoulControl1.DataBindings.AddIfValid("Selected", BindingSource, GetSoulBindingString(Page, 1));
			SoulControl2.DataBindings.AddIfValid("Selected", BindingSource, GetSoulBindingString(Page, 2));
			SoulControl3.DataBindings.AddIfValid("Selected", BindingSource, GetSoulBindingString(Page, 3));
			SoulControl4.DataBindings.AddIfValid("Selected", BindingSource, GetSoulBindingString(Page, 4));
			SoulControl5.DataBindings.AddIfValid("Selected", BindingSource, GetSoulBindingString(Page, 5));
			SoulControl6.DataBindings.AddIfValid("Selected", BindingSource, GetSoulBindingString(Page, 6));
			SoulControl7.DataBindings.AddIfValid("Selected", BindingSource, GetSoulBindingString(Page, 7));
			SoulControl8.DataBindings.AddIfValid("Selected", BindingSource, GetSoulBindingString(Page, 8));
			SoulControl9.DataBindings.AddIfValid("Selected", BindingSource, GetSoulBindingString(Page, 9));
			SoulControl10.DataBindings.AddIfValid("Selected", BindingSource, GetSoulBindingString(Page, 10));
			SoulControl11.DataBindings.AddIfValid("Selected", BindingSource, GetSoulBindingString(Page, 11));
			SoulControl12.DataBindings.AddIfValid("Selected", BindingSource, GetSoulBindingString(Page, 12));
			SoulControl13.DataBindings.AddIfValid("Selected", BindingSource, GetSoulBindingString(Page, 13));
			SoulControl14.DataBindings.AddIfValid("Selected", BindingSource, GetSoulBindingString(Page, 14));
			SoulControl15.DataBindings.AddIfValid("Selected", BindingSource, GetSoulBindingString(Page, 15));
			this.Refresh();
		}

		string GetSoulBindingString(int page, int position)
		{
			var type = GetSoulTypeFromPosition(page, position);
			return type != SoulType.None ? GetSoulBindingStringCore(type) : null;
		}

		protected virtual string GetSoulBindingStringCore(SoulType type)
		{
			return string.Empty;
		}

		SoulType GetSoulTypeFromPosition(int page, int position)
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
	}
}
