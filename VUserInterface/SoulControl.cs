using System;
using System.Collections.Generic;
using VBusiness.Souls;
using VEntityFramework.Data;
using VEntityFramework;
using VBusiness.HelperClasses;
using VUserInterface.CommonControls;

namespace VUserInterface
{
	public partial class SoulControl : DPIGroupBox
	{
		public SoulControl()
		{
			InitializeComponent();
		}

		public Soul Soul
		{
			get => fSoul ??= new EmptySoul();
			set
			{
				fSoul = value;
				UpdateBindingIfDataSourceChanged();
				if (SoulComboBox.SelectedItem.ToString() != $"{fSoul.SaveSlot}-{fSoul.UniqueName}")
				{
					SoulComboBox.SelectedItem = $"{fSoul.SaveSlot}-{fSoul.UniqueName}";
				}
				hasSoulBeenSet = true;
			}
		}

		bool hasSoulBeenSet;

		Soul fSoul;

		protected override void OnBindingContextChanged(EventArgs e)
		{
			base.OnBindingContextChanged(e);
			UpdateBindingIfDataSourceChanged();
		}

		protected override void OnParentBindingContextChanged(EventArgs e)
		{
			base.OnParentBindingContextChanged(e);
			UpdateBindingIfDataSourceChanged();
		}

		void UpdateBindingIfDataSourceChanged()
		{
			if (Soul != null && Soul != this.BindingSource.DataSource)
			{
				this.BindingSource.DataSource = Soul;
				this.BindingSource.ResetBindings(true);
			}
		}

		List<string> SoulList
		{
			get
			{
				if (fSoulList == null)
				{
					var souls = new List<string>();
					souls.Add("None");
					souls.AddRange(OrderHelper.OrderNamesByKey(VDataContext.Instance.GetAllFileNames<Soul>()));
					fSoulList = souls;
				}
				return fSoulList;
			}
		}
		List<string> fSoulList;

		void SoulChanged(object sender, EventArgs e)
		{
			if (hasSoulBeenSet)
			{
				var soulName = (string)SoulComboBox.SelectedItem;
				var soulSlot = soulName != "None" ? int.Parse(soulName.Split("-")[0]) : 0;
				var eventArgs = new SoulChangedEventArgs() { SoulSlot = soulSlot };
				OnSoulChanged?.Invoke(this, eventArgs);
			}
		}

		public event EventHandler<SoulChangedEventArgs> OnSoulChanged;
	}
}
