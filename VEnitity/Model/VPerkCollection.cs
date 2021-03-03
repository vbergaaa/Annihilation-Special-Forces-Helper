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
					OnPropertyChanged(nameof(Perk1));
					OnPropertyChanged(nameof(Perk2));
					OnPropertyChanged(nameof(Perk3));
					OnPropertyChanged(nameof(Perk4));
					OnPropertyChanged(nameof(Perk5));
					OnPropertyChanged(nameof(Perk6));
					OnPropertyChanged(nameof(PageTitle));
				}
			}
		}

		internal void RefreshMaxLevelBindings()
		{
			Perk1.RefreshPropertyBinding(nameof(Perk1.MaxLevel));
			Perk2.RefreshPropertyBinding(nameof(Perk2.MaxLevel));
			Perk3.RefreshPropertyBinding(nameof(Perk3.MaxLevel));
			Perk4.RefreshPropertyBinding(nameof(Perk4.MaxLevel));
			Perk5.RefreshPropertyBinding(nameof(Perk5.MaxLevel));
			Perk6.RefreshPropertyBinding(nameof(Perk6.MaxLevel));
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
		
	

