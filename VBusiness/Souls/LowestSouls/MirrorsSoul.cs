using VEntityFramework.Model;

namespace VBusiness.Souls
{
	public sealed class MirrorsSoul : LowestSoul
	{
		public MirrorsSoul(VSoulCollection collection) : base(collection)
		{
		}

		public override VEntityFramework.Model.SoulType Type => VEntityFramework.Model.SoulType.Mirrors;
	}
}
