using VEntityFramework.Model;

namespace VBusiness.Souls
{
	public sealed class AlacritySoul : DemonicSoul
	{
		public AlacritySoul(VLoadoutSouls collection) : base(collection)
		{
		}

		public override VEntityFramework.Model.SoulType Type => VEntityFramework.Model.SoulType.Alacrity;
	}
}
