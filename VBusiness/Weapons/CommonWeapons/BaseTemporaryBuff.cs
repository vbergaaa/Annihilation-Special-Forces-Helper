using System;
using VEntityFramework.Model;

namespace VBusiness.Weapons
{

	public abstract class BaseTemporaryBuff : ITemporaryBuffAbility
	{
		public abstract int Duratation { get; }
		public abstract int Cooldown { get; }
		public abstract IDisposable ApplyTemporaryBuff(VLoadout loadout);
		public double AbilityUptime => Math.Min(((double)Duratation) / Cooldown, 1);
	}
}
