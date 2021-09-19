using System;
using VEntityFramework;
using VEntityFramework.Model;

namespace VBusiness.Weapons
{
	public class GalaxianOrbiterGalaxyEmpowerment : BaseTemporaryBuff
	{
		//cd:30
		//dur:10
		//Increase Crit D by 70% and gain 10% damage increase
		public override int Duratation => 30;

		public override int Cooldown => 10;

		public override IDisposable ApplyTemporaryBuff(VLoadout loadout)
		{
			loadout.Stats.CriticalDamage += 70;
			loadout.Stats.UpdateDamageIncrease("GalaxyEmpowerment", 10);

			return new DisposableAction(() =>
			{
				loadout.Stats.CriticalDamage -= 70;
				loadout.Stats.UpdateDamageIncrease("GalaxyEmpowerment", -10);
			});
		}
	}
}
