using System;
using VEntityFramework.Data;

namespace VEntityFramework.Model
{
	public abstract class VPerkCollection : VBusinessObject
	{
		#region Constructor

		public VPerkCollection(VLoadout loadout) : base(loadout)
		{
			Loadout = loadout ?? throw new ArgumentException(nameof(loadout));
		}
		
		#endregion

		#region Properties

		#region Loadout

		[VXML(false)]
		public VLoadout Loadout
		{
			get => fLoadout;
			private set
			{
				fLoadout = value;
			}
		}
		VLoadout fLoadout;

		#endregion

		public abstract int MaxPage { get; }
		public abstract int RemainingCost { get; }
		public abstract int CurrentCost { get; }
		public abstract int TotalCost { get; }

		#region Page

		public virtual int Page
		{
			get
			{
				return fPage;
			}
			set
			{
				if (fPage != value)
				{
					fPage = value;
					OnPropertyChanged(new System.ComponentModel.PropertyChangedEventArgs(nameof(Perk1)));
					OnPropertyChanged(new System.ComponentModel.PropertyChangedEventArgs(nameof(Perk2)));
					OnPropertyChanged(new System.ComponentModel.PropertyChangedEventArgs(nameof(Perk3)));
					OnPropertyChanged(new System.ComponentModel.PropertyChangedEventArgs(nameof(Perk4)));
					OnPropertyChanged(new System.ComponentModel.PropertyChangedEventArgs(nameof(Perk5)));
					OnPropertyChanged(new System.ComponentModel.PropertyChangedEventArgs(nameof(Perk6)));
					OnPropertyChanged(new System.ComponentModel.PropertyChangedEventArgs(nameof(PageTitle)));
				}
			}
		}
		int fPage;

		#endregion

		[VXML(false)]
		public abstract VPerk Perk1 { get; }
		[VXML(false)]
		public abstract VPerk Perk2 { get; }
		[VXML(false)]
		public abstract VPerk Perk3 { get; }
		[VXML(false)]
		public abstract VPerk Perk4 { get; }
		[VXML(false)]
		public abstract VPerk Perk5 { get; }
		[VXML(false)]
		public abstract VPerk Perk6 { get; }
		public abstract string PageTitle { get; }

		public override string BizoName => "PerkCollection";

		#endregion

		#region PerkLevelChanged

		protected void OnPerkLevelChanged(object sender, StatsEventArgs e)
		{
			PerkLevelChanged?.Invoke(sender, e);
		}

		public event EventHandler<StatsEventArgs> PerkLevelChanged;

		#endregion
	}
}
		
	

