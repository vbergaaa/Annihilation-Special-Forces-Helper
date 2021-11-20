using VEntityFramework;
using VEntityFramework.Model;

namespace VBusiness.Mods
{
	public class PlayerMods : VPlayerMods
	{
		public PlayerMods(VProfile profile) : base(profile)
		{
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
