using VBusiness.HelperClasses;
using VEntityFramework.Data;
using VEntityFramework.Model;

namespace VBusiness
{
	public class UpgradeManager : VUpgradeManager
	{
		public UpgradeManager(BusinessObject parent) : base(parent)
		{
		}

		#region Properties

		#region AttackUpgrade

		public override int AttackUpgrade
		{
			get => base.AttackUpgrade;
			set
			{
				var correctedValue = value < 0
					? 0
					: value > MaxAttack
						? MaxAttack
						: value;

				base.AttackUpgrade = correctedValue;

				Stats.RefreshPropertyBinding("Attack");
				Stats.RefreshPropertyBinding("Damage");
				Stats.RefreshPropertyBinding("CriticalDamage");
			}
		}

		#endregion

		#region AttackSpeedUpgrade

		public override int AttackSpeedUpgrade
		{
			get => base.AttackSpeedUpgrade;
			set
			{
				var correctedValue = value < 0
					? 0
					: value > MaxAttackSpeed
						? MaxAttackSpeed
						: value;

				base.AttackSpeedUpgrade = correctedValue;

				Stats.RefreshPropertyBinding("AttackSpeed");
				Stats.RefreshPropertyBinding("CriticalDamage");
			}
		}

		#endregion

		#region HealthUpgrade

		public override int HealthUpgrade
		{
			get => base.HealthUpgrade;
			set
			{
				var correctedValue = value < 0
					? 0
					: value > MaxHealth
						? MaxHealth
						: value;

				base.HealthUpgrade = correctedValue;

				Stats.RefreshPropertyBinding("Toughness");
				Stats.RefreshPropertyBinding("Recovery");
				Stats.RefreshPropertyBinding("Health");
				Stats.RefreshPropertyBinding("HealthRegen");
			}
		}

		#endregion

		#region HealthArmorUpgrade

		public override int HealthArmorUpgrade
		{
			get => base.HealthArmorUpgrade;
			set
			{
				var correctedValue = value < 0
					? 0
					: value > MaxHealthArmor
						? MaxHealthArmor
						: value;

				base.HealthArmorUpgrade = correctedValue;

				Stats.RefreshPropertyBinding("Toughness");
				Stats.RefreshPropertyBinding("Recovery");
				Stats.RefreshPropertyBinding("HealthArmor");
			}
		}

		#endregion

		#region ShieldsUpgrade

		public override int ShieldsUpgrade
		{
			get => base.ShieldsUpgrade;
			set
			{
				var correctedValue = value < 0
					? 0
					: value > MaxShields
						? MaxShields
						: value;

				base.ShieldsUpgrade = correctedValue;

				Stats.RefreshPropertyBinding("Toughness");
				Stats.RefreshPropertyBinding("Recovery");
				Stats.RefreshPropertyBinding("Shields");
				Stats.RefreshPropertyBinding("ShieldsRegen");
			}
		}

		#endregion

		#region ShieldsArmorUpgrade

		public override int ShieldsArmorUpgrade
		{
			get => base.ShieldsArmorUpgrade;
			set
			{
				var correctedValue = value < 0
					? 0
					: value > MaxShieldsArmor
						? MaxShieldsArmor
						: value;

				base.ShieldsArmorUpgrade = correctedValue;

				Stats.RefreshPropertyBinding("Toughness");
				Stats.RefreshPropertyBinding("Recovery");
				Stats.RefreshPropertyBinding("ShieldsArmor");
			}
		}

		#endregion

		#region Cost

		public override double UpgradesCost
		{
			get
			{
				var baseModifier = Loadout.UnitConfiguration.Difficulty.BaseUpgradeCost;
				var modifier = baseModifier > 0 ? baseModifier / 100 : 1;
				var cost = VCalculator.Calculate(500 * modifier, 100, 0, AttackUpgrade);
				cost += VCalculator.Calculate(1000 * modifier, 1500, 0, AttackSpeedUpgrade);
				cost += VCalculator.Calculate(400 * modifier, 50, 0, HealthUpgrade);
				cost += VCalculator.Calculate(400 * modifier, 70, 0, HealthArmorUpgrade);
				cost += VCalculator.Calculate(400 * modifier, 50, 0, ShieldsUpgrade);
				cost += VCalculator.Calculate(400 * modifier, 70, 0, ShieldsArmorUpgrade);
				return cost;
			}
		}

		#endregion

		#endregion
	}
}
