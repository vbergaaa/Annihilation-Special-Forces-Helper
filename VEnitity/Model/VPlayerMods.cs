using VEntityFramework.Data;
using VEntityFramework.Model;

namespace VEntityFramework
{
	public class VPlayerMods : BusinessObject
	{
		public VPlayerMods(VProfile profile) : base(profile)
		{
			Profile = profile;
		}

		[VXML(false)]
		public VProfile Profile { get; }

		public override string BizoName => "PlayerMods";

		public virtual int TotalScore { get; }
		
		[VXML(true)]
		public int VeryEasy
		{
			get => fVeryEasy;
			set {
				if (fVeryEasy != value)
				{
					fVeryEasy = value;
					HasChanges = true;
					OnPropertyChanged(nameof(VeryEasy));
					Profile.RefreshPropertyBinding(nameof(Profile.ModScore));
				}
			}
		}
		int fVeryEasy;

		[VXML(true)]
		public int Easy
		{
			get => fEasy;
			set {
				if (fEasy != value)
				{
					fEasy = value;
					HasChanges = true;
					OnPropertyChanged(nameof(Easy));
					Profile.RefreshPropertyBinding(nameof(Profile.ModScore));
				}
			}
		}
		int fEasy;


		[VXML(true)]
		public int Normal
		{
			get => fNormal;
			set {
				if (fNormal != value)
				{
					fNormal = value;
					HasChanges = true;
					OnPropertyChanged(nameof(Normal));
					Profile.RefreshPropertyBinding(nameof(Profile.ModScore));
				}
			}
		}
		int fNormal;

		[VXML(true)]
		public int Hard
		{
			get => fHard;
			set {
				if (fHard != value)
				{
					fHard = value;
					HasChanges = true;
					OnPropertyChanged(nameof(Hard));
					Profile.RefreshPropertyBinding(nameof(Profile.ModScore));
				}
			}
		}
		int fHard;

		[VXML(true)]
		public int VeryHard
		{
			get => fVeryHard;
			set {
				if (fVeryHard != value)
				{
					fVeryHard = value;
					HasChanges = true;
					OnPropertyChanged(nameof(VeryHard));
					Profile.RefreshPropertyBinding(nameof(Profile.ModScore));
				}
			}
		}
		int fVeryHard;

		[VXML(true)]
		public int Insane
		{
			get => fInsane;
			set {
				if (fInsane != value)
				{
					fInsane = value;
					HasChanges = true;
					OnPropertyChanged(nameof(Insane));
					Profile.RefreshPropertyBinding(nameof(Profile.ModScore));
				}
			}
		}
		int fInsane;

		[VXML(true)]
		public int Brutal
		{
			get => fBrutal;
			set {
				if (fBrutal != value)
				{
					fBrutal = value;
					HasChanges = true;
					OnPropertyChanged(nameof(Brutal));
					Profile.RefreshPropertyBinding(nameof(Profile.ModScore));
				}
			}
		}
		int fBrutal;

		[VXML(true)]
		public int Nightmare
		{
			get => fNightmare;
			set {
				if (fNightmare != value)
				{
					fNightmare = value;
					HasChanges = true;
					OnPropertyChanged(nameof(Nightmare));
					Profile.RefreshPropertyBinding(nameof(Profile.ModScore));
				}
			}
		}
		int fNightmare;

		[VXML(true)]
		public int Torment
		{
			get => fTorment;
			set {
				if (fTorment != value)
				{
					fTorment = value;
					HasChanges = true;
					OnPropertyChanged(nameof(Torment));
					Profile.RefreshPropertyBinding(nameof(Profile.ModScore));
				}
			}
		}
		int fTorment;

		[VXML(true)]
		public int Hell
		{
			get => fHell;
			set {
				if (fHell != value)
				{
					fHell = value;
					HasChanges = true;
					OnPropertyChanged(nameof(Hell));
					Profile.RefreshPropertyBinding(nameof(Profile.ModScore));
				}
			}
		}
		int fHell;

		[VXML(true)]
		public int Titanic
		{
			get => fTitanic;
			set {
				if (fTitanic != value)
				{
					fTitanic = value;
					HasChanges = true;
					OnPropertyChanged(nameof(Titanic));
					Profile.RefreshPropertyBinding(nameof(Profile.ModScore));
				}
			}
		}
		int fTitanic;

		[VXML(true)]
		public int Mythic
		{
			get => fMythic;
			set {
				if (fMythic != value)
				{
					fMythic = value;
					HasChanges = true;
					OnPropertyChanged(nameof(Mythic));
					Profile.RefreshPropertyBinding(nameof(Profile.ModScore));
				}
			}
		}
		int fMythic;

		[VXML(true)]
		public int Divine
		{
			get => fDivine;
			set {
				if (fDivine != value)
				{
					fDivine = value;
					HasChanges = true;
					OnPropertyChanged(nameof(Divine));
					Profile.RefreshPropertyBinding(nameof(Profile.ModScore));
				}
			}
		}
		int fDivine;

		[VXML(true)]
		public int Impossible
		{
			get => fImpossible;
			set {
				if (fImpossible != value)
				{
					fImpossible = value;
					HasChanges = true;
					OnPropertyChanged(nameof(Impossible));
					Profile.RefreshPropertyBinding(nameof(Profile.ModScore));
				}
			}
		}
		int fImpossible;

		[VXML(true)]
		public int ZeroV
		{
			get => fZeroV;
			set {
				if (fZeroV != value)
				{
					fZeroV = value;
					HasChanges = true;
					OnPropertyChanged(nameof(ZeroV));
					Profile.RefreshPropertyBinding(nameof(Profile.ModScore));
				}
			}
		}
		int fZeroV;

		[VXML(true)]
		public int ZeroX
		{
			get => fZeroX;
			set {
				if (fZeroX != value)
				{
					fZeroX = value;
					HasChanges = true;
					OnPropertyChanged(nameof(ZeroX));
					Profile.RefreshPropertyBinding(nameof(Profile.ModScore));
				}
			}
		}
		int fZeroX;

		[VXML(true)]
		public int PureBlack
		{
			get => fPureBlack;
			set {
				if (fPureBlack != value)
				{
					fPureBlack = value;
					HasChanges = true;
					OnPropertyChanged(nameof(PureBlack));
					Profile.RefreshPropertyBinding(nameof(Profile.ModScore));
				}
			}
		}
		int fPureBlack;

		[VXML(true)]
		public int Annihilation
		{
			get => fAnnihilation;
			set {
				if (fAnnihilation != value)
				{
					fAnnihilation = value;
					HasChanges = true;
					OnPropertyChanged(nameof(Annihilation));
					Profile.RefreshPropertyBinding(nameof(Profile.ModScore));
				}
			}
		}
		int fAnnihilation;
	}
}
