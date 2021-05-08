using System;
using VEntityFramework.Data;

namespace VEntityFramework.Model
{
	public class VUpgradeManager : BusinessObject
	{
		#region Constructor

		public VUpgradeManager(BusinessObject parent) : base(parent)
		{
		}

		#endregion

		#region Stats

		[VXML(false)]
		public VStats Stats => ((VLoadout)Parent)?.Stats;

		#endregion

		#region Properties

		#region AttackUpgrade

		[VXML(true)]
		public virtual int AttackUpgrade
		{
			get => fAttackUpgrade;
			set
			{
				if (fAttackUpgrade != value)
				{
					fAttackUpgrade = value;
					HasChanges = true;
					OnPropertyChanged(nameof(AttackUpgrade));
				}
			}
		}
		int fAttackUpgrade;

		#endregion

		#region AttackSpeedUpgrade

		[VXML(true)]
		public virtual int AttackSpeedUpgrade
		{
			get => fAttackSpeedUpgrade;
			set
			{
				if (fAttackSpeedUpgrade != value)
				{
					fAttackSpeedUpgrade = value;
					HasChanges = true;
					OnPropertyChanged(nameof(AttackSpeedUpgrade));
				}
			}
		}

		int fAttackSpeedUpgrade;

		#endregion

		#region HealthUpgrade

		[VXML(true)]
		public virtual int HealthUpgrade
		{
			get => fHealthUpgrade;
			set
			{
				if (fHealthUpgrade != value)
				{
					fHealthUpgrade = value;
					HasChanges = true;
					OnPropertyChanged(nameof(HealthUpgrade));
				}
			}
		}
		int fHealthUpgrade;

		#endregion

		#region HealthArmorUpgrade

		[VXML(true)]
		public virtual int HealthArmorUpgrade
		{
			get => fHealthArmorUpgrade;
			set
			{
				if (fHealthArmorUpgrade != value)
				{
					fHealthArmorUpgrade = value;
					HasChanges = true;
					OnPropertyChanged(nameof(HealthArmorUpgrade));
				}
			}
		}
		int fHealthArmorUpgrade;

		#endregion

		#region ShieldsUpgrade

		[VXML(true)]
		public virtual int ShieldsUpgrade
		{
			get => fShieldsUpgrade;
			set
			{
				if (fShieldsUpgrade != value)
				{
					fShieldsUpgrade = value;
					HasChanges = true;
					OnPropertyChanged(nameof(ShieldsUpgrade));
				}
			}
		}
		int fShieldsUpgrade;

		#endregion

		#region ShieldsArmorUpgrade

		[VXML(true)]
		public virtual int ShieldsArmorUpgrade
		{
			get => fShieldsArmorUpgrade;
			set
			{
				if (fShieldsArmorUpgrade != value)
				{
					fShieldsArmorUpgrade = value;
					HasChanges = true;
					OnPropertyChanged(nameof(ShieldsArmorUpgrade));
				}
			}
		}
		int fShieldsArmorUpgrade;

		#endregion

		#region MaxValues

		public int MaxAttack => 100;
		public int MaxAttackSpeed => 15;
		public int MaxHealth => 100;
		public int MaxHealthArmor => 100;
		public int MaxShields => 100;
		public int MaxShieldsArmor => 100;

		#endregion

		#endregion

		#region Implementation

		public override string BizoName => "Upgrades";

		#endregion

#if DEBUG
		internal void MaxAll()
		{
			AttackUpgrade = MaxAttack;
			AttackSpeedUpgrade = MaxAttackSpeed;
			HealthArmorUpgrade = MaxHealthArmor;
			HealthUpgrade = MaxHealth;
			ShieldsArmorUpgrade = MaxShieldsArmor;
			ShieldsUpgrade = MaxShields;
		}
#endif
	}
}
