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

		#region Stats

		[VXML(false)]
		public VLoadout Loadout => Parent as VLoadout;

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
					Loadout.IncomeManager.RefreshPropertyBinding(nameof(Loadout.IncomeManager.LoadoutMineralCost));
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
					Loadout.IncomeManager.RefreshPropertyBinding(nameof(Loadout.IncomeManager.LoadoutMineralCost));
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
					Loadout.IncomeManager.RefreshPropertyBinding(nameof(Loadout.IncomeManager.LoadoutMineralCost));
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
					Loadout.IncomeManager.RefreshPropertyBinding(nameof(Loadout.IncomeManager.LoadoutMineralCost));
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
					Loadout.IncomeManager.RefreshPropertyBinding(nameof(Loadout.IncomeManager.LoadoutMineralCost));
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
					Loadout.IncomeManager.RefreshPropertyBinding(nameof(Loadout.IncomeManager.LoadoutMineralCost));
				}
			}
		}
		int fShieldsArmorUpgrade;

		#endregion

		#region MaxValues

		public static int MaxAttack => 100;
		public static int MaxAttackSpeed => 15;
		public static int MaxHealth => 100;
		public static int MaxHealthArmor => 100;
		public static int MaxShields => 100;
		public static int MaxShieldsArmor => 100;

		#endregion

		public virtual double UpgradesCost { get; }

		[VXML(true)]
		public bool IncludeUpgradesInLoadoutCost
		{
			get => fIncludeUpgradesInLoadoutCost;
			set
			{
				if (value != fIncludeUpgradesInLoadoutCost)
				{
					fIncludeUpgradesInLoadoutCost = value;
					HasChanges = true;
					OnPropertyChanged(nameof(IncludeUpgradesInLoadoutCost));
					Loadout.IncomeManager.RefreshPropertyBinding(nameof(Loadout.IncomeManager.LoadoutMineralCost));
				}
			}
		}
		bool fIncludeUpgradesInLoadoutCost;

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
