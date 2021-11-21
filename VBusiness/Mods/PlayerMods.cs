using VEntityFramework;
using VEntityFramework.Model;

namespace VBusiness.Mods
{
	public class PlayerMods : VPlayerMods
	{
		public const int MaxModScore = 2000;

		public PlayerMods(VProfile profile) : base(profile)
		{
		}

		public override int VeryEasy
		{
			get => base.VeryEasy;
			set {
				if (value >= 0 && value <= MaxModScore)
				{
					base.VeryEasy = value;
				}
			}
		}

		public override int Easy
		{
			get => base.Easy;
			set {
				if (value >= 0 && value <= MaxModScore)
				{
					base.Easy = value;
				}
			}
		}

		public override int Normal
		{
			get => base.Normal;
			set {
				if (value >= 0 && value <= MaxModScore)
				{
					base.Normal = value;
				}
			}
		}

		public override int Hard
		{
			get => base.Hard;
			set {
				if (value >= 0 && value <= MaxModScore)
				{
					base.Hard = value;
				}
			}
		}

		public override int VeryHard
		{
			get => base.VeryHard;
			set {
				if (value >= 0 && value <= MaxModScore)
				{
					base.VeryHard = value;
				}
			}
		}

		public override int Insane
		{
			get => base.Insane;
			set {
				if (value >= 0 && value <= MaxModScore)
				{
					base.Insane = value;
				}
			}
		}

		public override int Brutal
		{
			get => base.Brutal;
			set {
				if (value >= 0 && value <= MaxModScore)
				{
					base.Brutal = value;
				}
			}
		}

		public override int Nightmare
		{
			get => base.Nightmare;
			set {
				if (value >= 0 && value <= MaxModScore)
				{
					base.Nightmare = value;
				}
			}
		}

		public override int Torment
		{
			get => base.Torment;
			set {
				if (value >= 0 && value <= MaxModScore)
				{
					base.Torment = value;
				}
			}
		}

		public override int Hell
		{
			get => base.Hell;
			set {
				if (value >= 0 && value <= MaxModScore)
				{
					base.Hell = value;
				}
			}
		}

		public override int Titanic
		{
			get => base.Titanic;
			set {
				if (value >= 0 && value <= MaxModScore)
				{
					base.Titanic = value;
				}
			}
		}

		public override int Mythic
		{
			get => base.Mythic;
			set {
				if (value >= 0 && value <= MaxModScore)
				{
					base.Mythic = value;
				}
			}
		}

		public override int Divine
		{
			get => base.Divine;
			set {
				if (value >= 0 && value <= MaxModScore)
				{
					base.Divine = value;
				}
			}
		}

		public override int Impossible
		{
			get => base.Impossible;
			set {
				if (value >= 0 && value <= MaxModScore)
				{
					base.Impossible = value;
				}
			}
		}

		public override int ZeroV
		{
			get => base.ZeroV;
			set {
				if (value >= 0 && value <= MaxModScore)
				{
					base.ZeroV = value;
				}
			}
		}

		public override int ZeroX
		{
			get => base.ZeroX;
			set {
				if (value >= 0 && value <= MaxModScore)
				{
					base.ZeroX = value;
				}
			}
		}

		public override int PureBlack
		{
			get => base.PureBlack;
			set {
				if (value >= 0 && value <= MaxModScore)
				{
					base.PureBlack = value;
				}
			}
		}

		public override int Annihilation
		{
			get => base.Annihilation;
			set {
				if (value >= 0 && value <= MaxModScore)
				{
					base.Annihilation = value;
				}
			}
		}

		public override int TotalScore => VeryEasy
			+ Easy
			+ Normal
			+ Hard
			+ VeryHard
			+ Insane
			+ Brutal
			+ Nightmare
			+ Torment
			+ Hell
			+ Titanic
			+ Mythic
			+ Divine
			+ Impossible
			+ ZeroV
			+ ZeroX
			+ PureBlack
			+ Annihilation;
	}
}
