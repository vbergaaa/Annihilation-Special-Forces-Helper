using System;
using System.Collections.Generic;
using System.Text;
using VEntityFramework.Data;

namespace VEntityFramework.Model
{
	public interface IUnitData : IXmlObject
	{
		[VXML(true, "Key")]
		UnitType Type { get; }
		double AttackCount { get; }
		double BaseAttack { get; }
		double BaseAttackSpeed { get; }
		double BaseHealth { get; }
		double BaseHealthArmor { get; }
		double BaseHealthRegen { get; }
		double BaseShields { get; }
		double BaseShieldsArmor { get; }
		double BaseShieldsRegen { get; }
		double AttackIncrement { get; }
		double HealthIncrement { get; }
		double HealthRegenIncrement { get; }
		double HealthArmorIncrement { get; }
		double ShieldIncrement { get; }
		double ShieldRegenIncrement { get; }
		double ShieldArmorIncrement { get; }
		UnitType[] SpecTypes { get; }
	}
}
