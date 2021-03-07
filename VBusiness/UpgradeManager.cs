using System;
using System.Collections.Generic;
using System.Text;
using VEntityFramework.Data;
using VEntityFramework.Model;

namespace VBusiness
{
	public class UpgradeManager : VUpgradeManager
	{
		public UpgradeManager(VBusinessObject parent) : base(parent)
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

		#endregion
	}
}
