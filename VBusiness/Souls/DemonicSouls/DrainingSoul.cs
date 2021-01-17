using VEntityFramework.Model;

namespace VBusiness.Souls
{
	public sealed class DrainingSoul : DemonicSoul
	{
		public DrainingSoul(VSoulCollection collection) : base(collection)
		{
		}

		public override VEntityFramework.Model.SoulType Type => VEntityFramework.Model.SoulType.Draining;
	}
}
