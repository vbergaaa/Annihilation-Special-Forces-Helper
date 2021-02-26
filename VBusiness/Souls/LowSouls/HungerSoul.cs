using VEntityFramework.Model;

namespace VBusiness.Souls
{
	public sealed class HungerSoul : LowSoul
	{
		public HungerSoul(VLoadoutSouls collection) : base(collection)
		{
		}

		public override VEntityFramework.Model.SoulType Type => VEntityFramework.Model.SoulType.Hunger;
	}
}
