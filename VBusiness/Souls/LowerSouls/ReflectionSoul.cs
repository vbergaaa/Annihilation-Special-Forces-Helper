using VEntityFramework.Model;

namespace VBusiness.Souls
{
	public sealed class ReflectionSoul : LowerSoul
	{
		public ReflectionSoul(VLoadoutSouls collection) : base(collection)
		{
		}

		public override VEntityFramework.Model.SoulType Type => VEntityFramework.Model.SoulType.Reflection;
	}
}
