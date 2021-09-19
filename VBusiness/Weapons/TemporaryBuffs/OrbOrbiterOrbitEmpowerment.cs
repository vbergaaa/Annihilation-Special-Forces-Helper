using System;
using VEntityFramework;
using VEntityFramework.Model;

namespace VBusiness.Weapons
{
	class OrbOrbiterOrbitEmpowerment : BaseTemporaryBuff
	{
		// dur:10
		// cd:30
		// increase crit d by 50%
		public override int Duratation => 30;

		public override int Cooldown => 10;

		public override IDisposable ApplyTemporaryBuff(VLoadout loadout)
		{
			loadout.Stats.CriticalDamage += 50;

			return new DisposableAction(() =>
			{
				loadout.Stats.CriticalDamage -= 50;
			});
		}
	}
}
