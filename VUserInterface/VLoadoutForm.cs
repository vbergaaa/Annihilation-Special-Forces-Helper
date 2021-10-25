using System;
using System.Collections.Generic;
using System.Linq;
using VBusiness.Loadouts;
using VEntityFramework.Model;

namespace VUserInterface
{
	public partial class VLoadoutForm : VForm
	{
		public VLoadoutForm(Loadout loadout) : base(loadout)
		{
			InitializeComponent();
			Loadout = loadout;
			AddNewBindings();
			UpdateFormTitle();
		}

		void UpdateFormTitle()
		{
			if (Loadout.ExistsInXML)
			{
				this.Text = $"Edit Loadout: {Loadout.Name}";
			}
			else
			{
				this.Text = "Create new loadout";
			}
		}

		void AddNewBindings()
		{
			this.bindingSource.DataSource = Loadout;
		}

		public Loadout Loadout
		{
			get => fLoadout;
			set
			{
				fLoadout = value;
				fLoadout.ShouldRestrictChanged += RefreshPageLimits;
				fLoadout.BizoSaved += Loadout_BizoSaved;
				fLoadout.UnitsUpdated += Loadout_UnitsUpdated;
				RefreshUnitDropdowns();
			}
		}

		void Loadout_UnitsUpdated(object sender, EventArgs e)
		{
			RefreshUnitDropdowns();
		}

		void RefreshUnitDropdowns()
		{
			suspendUpdatingCurrentUnit = true;
			var newStatsList = GetNewUnitStatsList();
			var newIncomeList = GetNewUnitIncomeList();
			UnitForStatsDisplayDropBox.List = newStatsList.Cast<object>().ToList();
			UnitForIncomeDisplayDropBox.List = newIncomeList.Cast<object>().ToList();
			var newIndex = Loadout.Units.IndexOf(Loadout.CurrentUnit) + 1;
			UnitForStatsDisplayDropBox.SelectedIndex = newIndex;
			UnitForIncomeDisplayDropBox.SelectedIndex = newIndex;
			suspendUpdatingCurrentUnit = false;
		}

		List<string> GetNewUnitStatsList()
		{
			var list = new List<string>() { "Player Stats" };
			list.AddRange(Loadout.Units.Select(x => x.ToString()));
			return list;
		}

		List<string> GetNewUnitIncomeList()
		{
			var list = new List<string>() { "All Units" };
			list.AddRange(Loadout.Units.Select(x => x.ToString()));
			return list;
		}

		void UnitForStatsDisplayDropBox_SelectedValueChanged(object sender, EventArgs e)
		{
			if (!suspendUpdatingCurrentUnit)
			{
				var index = UnitForIncomeDisplayDropBox.SelectedIndex;

				if (index <= 0)
				{
					// this is currently used to set the current unit on the loadout to be blank
					VUnit.New(UnitType.None, Loadout);
				}
				else
				{
					Loadout.SetCurrentUnit(Loadout.Units[index - 1]);
				}
			}
		}

		void UnitForIncomeDisplayDropBox_SelectedValueChanged(object sender, EventArgs e)
		{
			if (!suspendUpdatingCurrentUnit)
			{
				var index = UnitForStatsDisplayDropBox.SelectedIndex;

				if (index <= 0)
				{
					// this is currently used to set the current unit on the loadout to be blank
					VUnit.New(UnitType.None, Loadout);
				}
				else
				{
					Loadout.SetCurrentUnit(Loadout.Units[index - 1]);
				}
			}
		}
		bool suspendUpdatingCurrentUnit;

		Loadout fLoadout;

		void Loadout_BizoSaved(object sender, EventArgs e)
		{
			UpdateFormTitle();
		}

		void RefreshPageLimits(object sender, EventArgs e)
		{
			var perksControl = this.Controls.Find("PerkPageControl", true)[0];
			if (perksControl is VPerkCollectionControl control)
			{
				control.RestrictPerkPageButtons();
			}
		}
	}
}
