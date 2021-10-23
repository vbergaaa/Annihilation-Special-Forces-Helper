using System;
using System.Collections.Generic;
using VEntityFramework;
using VEntityFramework.Model;
using VUserInterface.CommonControls;

namespace VUserInterface
{
	public class UnitSelectList : VSelectList
	{
		public UnitSelectList()
		{
			InitializeComponents();
		}

		void InitializeComponents()
		{
			OpenButton.Visible = false;
		}

		public IList<VUnit> List
		{
			get => fList;
			set
			{
				if (value != null && ShouldRefreshList)
				{
					fList = value;
					RefreshCollection(SelectedIndex);
				}
			}
		}
		IList<VUnit> fList;

		public VUnit CurrentUnit
		{
			get => fCurrentUnit;
			set
			{
				fCurrentUnit = value;
				if (value != null && Loadout != null)
				{
					var index = Loadout.Units.IndexOf(CurrentUnit);
					SelectedIndex = index;
				}
			}
		}
		VUnit fCurrentUnit;

		public VLoadout Loadout { get; set; }

		void RefreshCollection(int indexToSelect)
		{
			Collection.Clear();
			foreach (var item in List)
			{
				Collection.Add(item);
			}
			SelectedIndex = indexToSelect;
		}

		protected override void OnNewClicked()
		{
			if (Loadout != null)
			{
				SelectedIndex = -1;
				VUnit.New(UnitType.None, Loadout);
			}
		}

		protected override void OnDeleteClicked()
		{
			if (Loadout != null && SelectedIndex > -1)
			{
				var index = SelectedIndex;
				Loadout.Units.RemoveAt(index);

				var newIndex = Loadout.Units.Count > SelectedIndex ? index : index - 1;
				RefreshCollection(newIndex);
			}
		}

		protected override void OnSelectedIndex_Changed()
		{
			if (Loadout != null && SelectedIndex > -1)
			{
				using (SuspendRefreshingList())
				{
					Loadout.SetCurrentUnit(Loadout.Units[SelectedIndex]);
				}
			}
		}

		protected bool ShouldRefreshList => suspendRefreshingListIncrementor == 0;
		int suspendRefreshingListIncrementor;

		IDisposable SuspendRefreshingList()
		{
			suspendRefreshingListIncrementor++;
			return new DisposableAction(() => { suspendRefreshingListIncrementor--; });
		}
	}
}
