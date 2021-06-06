using VEntityFramework.Data;

namespace VEntityFramework.Model
{
	public class VBrutaliskOverride : BusinessObject
	{
		public VBrutaliskOverride(VIncomeManager manager) : base(manager)
		{
			IncomeManager = manager;
		}

		#region Brutas

		public virtual bool Bruta1
		{
			get => fBruta1;
			set
			{
				if (value != fBruta1)
				{
					fBruta1 = value;
					OnPropertyChanged(nameof(Bruta1));
				}
			}
		}
		bool fBruta1;

		public virtual bool Bruta2
		{
			get => fBruta2;
			set
			{
				if (value != fBruta2)
				{
					fBruta2 = value;
					OnPropertyChanged(nameof(Bruta2));
				}
			}
		}
		bool fBruta2;

		public virtual bool Bruta3
		{
			get => fBruta3;
			set
			{
				if (value != fBruta3)
				{
					fBruta3 = value;
					OnPropertyChanged(nameof(Bruta3));
				}
			}
		}
		bool fBruta3;

		public virtual bool Bruta4
		{
			get => fBruta4;
			set
			{
				if (value != fBruta4)
				{
					fBruta4 = value;
					OnPropertyChanged(nameof(Bruta4));
				}
			}
		}
		bool fBruta4;

		public virtual bool Bruta5
		{
			get => fBruta5;
			set
			{
				if (value != fBruta5)
				{
					fBruta5 = value;
					OnPropertyChanged(nameof(Bruta5));
				}
			}
		}
		bool fBruta5;

		public virtual bool Bruta6
		{
			get => fBruta6;
			set
			{
				if (value != fBruta6)
				{
					fBruta6 = value;
					OnPropertyChanged(nameof(Bruta6));
				}
			}
		}
		bool fBruta6;

		#endregion

		#region Overrides

		[VXML(true)]
		public bool ShouldOverrideBrutalisks
		{
			get => fShouldOverrideBrutalisks;
			set
			{
				if (fShouldOverrideBrutalisks != value)
				{
					fShouldOverrideBrutalisks = value;
					HasChanges = true;
					OnPropertyChanged(nameof(ShouldOverrideBrutalisks));
				}
			}
		}
		bool fShouldOverrideBrutalisks;

		[VXML(true)]
		public bool BrutaOverride1
		{
			get => fBrutaOverride1;
			set
			{
				if (fBrutaOverride1 != value)
				{
					fBrutaOverride1 = value;
					HasChanges = true;
					OnPropertyChanged(nameof(BrutaOverride1));
				}
			}
		}
		bool fBrutaOverride1;

		[VXML(true)]
		public bool BrutaOverride2
		{
			get => fBrutaOverride2;
			set
			{
				if (fBrutaOverride2 != value)
				{
					fBrutaOverride2 = value;
					HasChanges = true;
					OnPropertyChanged(nameof(BrutaOverride2));
				}
			}
		}
		bool fBrutaOverride2;

		[VXML(true)]
		public bool BrutaOverride3
		{
			get => fBrutaOverride3;
			set
			{
				if (fBrutaOverride3 != value)
				{
					fBrutaOverride3 = value;
					HasChanges = true;
					OnPropertyChanged(nameof(BrutaOverride3));
				}
			}
		}
		bool fBrutaOverride3;

		[VXML(true)]
		public bool BrutaOverride4
		{
			get => fBrutaOverride4;
			set
			{
				if (fBrutaOverride4 != value)
				{
					fBrutaOverride4 = value;
					HasChanges = true;
					OnPropertyChanged(nameof(BrutaOverride4));
				}
			}
		}
		bool fBrutaOverride4;

		[VXML(true)]
		public bool BrutaOverride5
		{
			get => fBrutaOverride5;
			set
			{
				if (fBrutaOverride5 != value)
				{
					fBrutaOverride5 = value;
					HasChanges = true;
					OnPropertyChanged(nameof(BrutaOverride5));
				}
			}
		}
		bool fBrutaOverride5;

		[VXML(true)]
		public bool BrutaOverride6
		{
			get => fBrutaOverride6;
			set
			{
				if (fBrutaOverride6 != value)
				{
					fBrutaOverride6 = value;
					HasChanges = true;
					OnPropertyChanged(nameof(BrutaOverride6));
				}
			}
		}
		bool fBrutaOverride6;

		#endregion

		public override string BizoName => "BrutaliskOverride";

		[VXML(false)]
		public VIncomeManager IncomeManager { get; }

		public void RefreshAllBrutas()
		{
			if (!ShouldOverrideBrutalisks)
			{
				OnPropertyChanged(nameof(Bruta1));
				OnPropertyChanged(nameof(Bruta2));
				OnPropertyChanged(nameof(Bruta3));
				OnPropertyChanged(nameof(Bruta4));
				OnPropertyChanged(nameof(Bruta5));
				OnPropertyChanged(nameof(Bruta6));
			}
		}
	}
}
