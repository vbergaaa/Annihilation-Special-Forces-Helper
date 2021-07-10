using System;
using System.Collections.Generic;
using VBusiness.ChallengePoints;
using VBusiness.Gems;
using VBusiness.Perks;
using VBusiness.Souls;
using VBusiness.Units;
using VEntityFramework;
using VEntityFramework.Data;
using VEntityFramework.Model;

namespace VBusiness.Loadouts
{
	public class Loadout : VLoadout
	{
		#region Constructor

		public Loadout()
		{
		}

		#endregion

		#region Properties

		#region Profile

		public override VProfile Profile { get => fProfile ??= VDataContext.Instance.Get<VBusiness.Profile.Profile>(); }
		VProfile fProfile;

		#endregion

		#region Gems

		public override VGemCollection Gems
		{
			get => base.Gems ??= new GemCollection(this);
			set => base.Gems = value;
		}

		#endregion

		#region Perks

		public override VPerkCollection Perks
		{
			get => base.Perks ??= new PerkCollection(this);
			set => base.Perks = value;
		}

		#endregion

		#region Souls

		public override VLoadoutSouls Souls
		{
			get => base.Souls ??= new LoadoutSouls(this);
			set => base.Souls = value;
		}

		#endregion

		#region ChallengePoints

		public override VChallengePointCollection ChallengePoints
		{
			get => base.ChallengePoints ??= new ChallengePointCollection(this);
			set => base.ChallengePoints = value;
		}

		#endregion

		#region UnitConfiguration

		public override VUnitConfiguration UnitConfiguration
		{
			get => base.UnitConfiguration ??= new UnitConfiguration(this);
			set => base.UnitConfiguration = value;
		}

		#endregion

		#region Upgrades

		public override VUpgradeManager Upgrades => fUpgrades ??= new UpgradeManager(this);
		VUpgradeManager fUpgrades;

		#endregion

		#region Income

		public override VIncomeManager IncomeManager => fIncomeManager ??= new IncomeManager(this);
		VIncomeManager fIncomeManager;

		#endregion

		#region Units

		[VXML(true)]
		public override BusinessObjectList<VUnit> Units => fUnits ??= new BusinessObjectList<VUnit>(this);
		BusinessObjectList<VUnit> fUnits;

		#endregion

		#region CurrentUnit

		public override VUnit CurrentUnit 
		{
			get
			{
				if (base.CurrentUnit == null)
				{
					if (Units.Count > 0)
					{
						return Units[0];
					}
					else
					{
						return VUnit.New(UnitType.None, this);
					}
				}
				return base.CurrentUnit;
			}
			set
			{
				if (base.CurrentUnit != value)
				{
					using (Stats.SuspendRefreshingStatBindings())
					{
						RemoveStats(base.CurrentUnit);
						base.CurrentUnit = value;
						AddStats(base.CurrentUnit);
					}
				}
			}
		}

		void RemoveStats(VUnit currentUnit)
		{
			if (currentUnit is Unit unit)
			{
				unit.Rank?.DeactivateRank();
				unit.UpdateStatsFromInfuse(-unit.CurrentInfusion);
				unit.UpdateStatsFromEssence(-unit.EssenceStacks);
				unit.RemoveStatsFromSpec(unit.HasUnitSpec);
			}
		}

		void AddStats(VUnit currentUnit)
		{
			if (currentUnit is Unit unit)
			{
				unit.Rank?.ActivateRank();
				unit.UpdateStatsFromInfuse(unit.CurrentInfusion);
				unit.UpdateStatsFromEssence(unit.EssenceStacks);
				unit.AddStatsFromSpec();
			}
		}

		#endregion

		#region UnitSpec

		public override UnitType UnitSpec
		{
			get => base.UnitSpec;
			set
			{
				var unitHadSpec = CurrentUnit.HasUnitSpec;
				base.UnitSpec = value;
				if (unitHadSpec != CurrentUnit.HasUnitSpec)
				{
					if (CurrentUnit.HasUnitSpec)
					{
						((Unit)CurrentUnit).AddStatsFromSpec();
					}
					else
					{
						((Unit)CurrentUnit).RemoveStatsFromSpec(true);
					}
				}

				IncomeManager.RefreshPropertyBinding(nameof(IncomeManager.LoadoutMineralCost));
			}
		}

		#endregion

		#region PerkPointsCost

		public override long PerkPointsCost
		{
			get => Perks.TotalCost + Souls.SoulCosts;
		}

		#endregion

		#region RemainingPerkPoints

		public override long RemainingPerkPoints => Profile.PerkPoints - PerkPointsCost;

		public override bool CanAffordCurrentLoadout
		{
			get
			{
				return RemainingPerkPoints >= 0 && Gems.RemainingGems >= 0 && ChallengePoints.RemainingCP >= 0;
			}
		}

		#endregion

		#endregion

		#region Validation

		protected override void RunPreSaveValidationCore()
		{
			base.RunPreSaveValidationCore();

			CheckLoadoutName();
			CheckSlotNumber();
			CheckCanAfford();
		}

		void CheckCanAfford()
		{
			if (ShouldRestrict && !CanAffordCurrentLoadout)
			{
				Notifications.AddError("Cannot save this loadout as you cannot afford it with your current profile limits. Please turn off profile limits or reduce the cost of the loadout.");
			}
		}

		void CheckSlotNumber()
		{
			if (Slot <= 0)
			{
				Notifications.AddError("Please enter a Save slot that is greater than 0.");
			}
		}

		void CheckLoadoutName()
		{
			if (Name == "")
			{
				Notifications.AddError("Please enter a name for this loadout.");
			}
		}

		#endregion

		#region Implementation

		protected override void SetDefaultValuesCore()
		{
			Stats = new Stats(this);
			//ShouldRestrict = false;
			UseUnitStats = true;
		}

		#endregion
	}
}
