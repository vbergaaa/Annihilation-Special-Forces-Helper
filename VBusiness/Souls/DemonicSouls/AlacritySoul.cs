using VEntityFramework.Model;

namespace VBusiness.Souls
{
	public sealed class AlacritySoul : DemonicSoul
	{
		public AlacritySoul(VSoulCollection collection) : base(collection)
		{
		}

		public override VEntityFramework.Model.SoulType Type => VEntityFramework.Model.SoulType.Alacrity;
	}
}
