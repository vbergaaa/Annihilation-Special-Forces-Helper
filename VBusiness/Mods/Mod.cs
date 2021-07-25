using VEntityFramework.Model;

namespace VBusiness.Mods
{
	public abstract class Mod : VMod
	{
		protected Mod(VModsCollection collection) : base(collection)
		{
		}
	}
}
