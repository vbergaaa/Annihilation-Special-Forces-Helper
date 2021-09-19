using System;
using VEntityFramework;
using VEntityFramework.Model;

namespace VBusiness.Weapons
{
	public class SplitterAdeptPrecisionTargetting : BaseTemporaryBuff
	{
		public override int Duratation => 10;

		public override int Cooldown => 30;

		public override IDisposable ApplyTemporaryBuff(VLoadout loadout)
		{
			loadout.Stats.CriticalChance += 10;
			return new DisposableAction(() => { loadout.Stats.CriticalChance -= 10; });
		}
	}
}
