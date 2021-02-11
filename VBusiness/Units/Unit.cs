using VEntityFramework.Model;

namespace VBusiness.Loadouts
{
	public abstract class Unit : VUnit
	{
		public Unit(VLoadout loadout) : base(loadout)
		{
		}
	}
}