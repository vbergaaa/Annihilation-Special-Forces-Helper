using System;
using VEntityFramework;
using VEntityFramework.Model;

namespace VBusiness.Weapons
{
	public class DuplicatorAdeptPrecisionTargetting : BaseTemporaryBuff
	{
		public override int Duratation => 15;

		public override int Cooldown => 30;

		public override IDisposable ApplyTemporaryBuff(VLoadout loadout)
		{
			loadout.Stats.CriticalChance += 20;
			return new DisposableAction(() => { loadout.Stats.CriticalChance -= 20; });
		}
	}
}
