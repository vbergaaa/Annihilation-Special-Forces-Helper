using System;
using VEntityFramework.Model;

namespace VBusiness.Weapons
{
	public interface ITemporaryBuffAbility
	{
		double AbilityUptime { get; }
		IDisposable ApplyTemporaryBuff(VLoadout loadout);
	}
}