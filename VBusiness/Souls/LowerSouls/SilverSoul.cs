using VEntityFramework.Model;

namespace VBusiness.Souls
{
	public sealed class SilverSoul : LowerSoul
	{
		public SilverSoul(VLoadoutSouls collection) : base(collection)
		{
		}

		public override VEntityFramework.Model.SoulType Type => VEntityFramework.Model.SoulType.Silver;
	}
}
