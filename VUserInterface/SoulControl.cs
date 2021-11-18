using System;
using System.Collections.Generic;
using VBusiness.Souls;
using VEntityFramework.Data;
using VEntityFramework;
using VBusiness.HelperClasses;
using VUserInterface.CommonControls;
using VEntityFramework.DataContext;
using VEntityFramework.Model;

namespace VUserInterface
{
	public partial class SoulControl : DPIGroupBox
	{
		public SoulControl()
		{
			InitializeComponent();
		}

		public VLoadoutSouls SoulCollection { get; set; }

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
			if (Soul != null && Soul != BindingSource.DataSource)
			{
				BindingSource.DataSource = Soul;
				BindingSource.ResetBindings(true);
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
					souls.AddRange(OrderHelper.OrderNamesByKey(VDataContext.GetAllFileNames<Soul>()));
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

		void AddNewSoulButton_Click(object sender, EventArgs e)
		{
			var oldSoul = Soul;
			var soul = BizoCreator.Create(typeof(Soul), Array.Empty<object>());
			var soulForm = new SoulForm(soul);
			soulForm.SoulCollection = SoulCollection;
			soulForm.ShowDialog();

			if (!(soulForm.Parent is EmptySoul) && soulForm.Parent.ExistsInXML)
			{
				var bindingField = DataBindings.GetBindingField("Soul");
				fSoulList = null;
				hasSoulBeenSet = false;
				SoulComboBox.DataSource = SoulList;
				SoulCollection.GetType().GetProperty(bindingField).SetValue(SoulCollection, soulForm.Parent);
			}
		}

		public event EventHandler<SoulChangedEventArgs> OnSoulChanged;
	}
}
