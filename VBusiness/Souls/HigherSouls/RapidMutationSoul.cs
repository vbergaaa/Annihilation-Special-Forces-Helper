using VEntityFramework.Model;

namespace VBusiness.Souls
{
	public sealed class RapidMutationSoul : HigherSoul
	{
		public RapidMutationSoul(VLoadoutSouls collection) : base(collection)
		{
		}

		public override VEntityFramework.Model.SoulType Type => VEntityFramework.Model.SoulType.RapidMutation;
	}
}
