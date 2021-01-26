using VEntityFramework.Model;

namespace VBusiness.Souls
{
	public sealed class UnboundReflectionSoul : TitanSoul
	{
		public UnboundReflectionSoul(VLoadoutSouls collection) : base(collection)
		{
		}

		public override VEntityFramework.Model.SoulType Type => VEntityFramework.Model.SoulType.UnboundReflection;
	}
}
