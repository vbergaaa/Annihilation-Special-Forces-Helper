using System.Collections.Generic;
using System.Linq;
using VBusiness.ChallengePoints;
using VBusiness.Gems;
using VBusiness.HelperClasses;
using VBusiness.Mods;
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

		public override VProfile Profile => VBusiness.Profile.Profile.GetProfile();

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

		#region Mods

		public override VModsCollection Mods => fMods ??= new ModsCollection(this);
		VModsCollection fMods;

		#endregion

		[VXML(true)]
		public override BusinessObjectList<VUnit> Units => fUnits ??= new UnitsCollection(this);
		BusinessObjectList<VUnit> fUnits;

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

        static void RemoveStats(VUnit currentUnit)
		{
			if (currentUnit is Unit unit)
			{
				unit.Rank?.DeactivateRank();
				unit.UpdateStatsFromInfuse(-unit.CurrentInfusion);
				unit.UpdateStatsFromEssence(-unit.EssenceStacks);
				unit.RemoveStatsFromSpec(unit.HasUnitSpec);
				unit.RemoveStatsFromAdrenalineRush();
				if (unit.IsLimitBroken)
				{
					unit.UpdateStatsFromEssence(-unit.LimitlessEssenceStacks);
				}
			}
		}

        static void AddStats(VUnit currentUnit)
		{
			if (currentUnit is Unit unit)
			{
				unit.Rank?.ActivateRank();
				unit.UpdateStatsFromInfuse(unit.CurrentInfusion);
				unit.UpdateStatsFromEssence(unit.EssenceStacks);
				unit.AddStatsFromSpec();
				unit.AddStatsFromAdrenalineRush();
				if (unit.IsLimitBroken)
				{
					unit.UpdateStatsFromEssence(unit.LimitlessEssenceStacks);
				}
			}
		}

		public override UnitType UnitSpec
		{
			get
			{
				if (Perks.UnitSpecialization.DesiredLevel > 0 && !(Perks.UnitSpecialization.DesiredLevel == Perks.UnitSpecialization.MaxLevel && Perks.UpgradeCache.DesiredLevel > 0))
				{
					// if these are true, then we have either no spec, or all specs. We will display no spec
					// TODO: add unit spec type 'All'
					return base.UnitSpec;
				}
				return UnitType.None;
			}
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

		public override bool UnitSpec_Readonly => !(Perks.UnitSpecialization.DesiredLevel == Perks.UnitSpecialization.MaxLevel && Perks.UpgradeCache.DesiredLevel > 0);

		#endregion

		#region Optimising Loadout

		public void OptimiseGemsForDamage()
		{
			var unMaxedGems = Gems.Gems.Where(g => g.CurrentLevel < g.MaxValue);
			using (Stats.SuspendRefreshingStatBindings())
			using (BeginOptimisingStatistics())
			{
				while (unMaxedGems.Any())
				{
					var bestValueGem = unMaxedGems.OrderByDescending(g => g.GetProposedDamageIncrease(1) / g.GetCostOfNextLevel()).First();
					if (bestValueGem.GetProposedDamageIncrease(1) == 0)
					{
						break;
					}
					bestValueGem.CurrentLevel += 1;
					unMaxedGems = Gems.Gems.Where(g => g.CurrentLevel < g.MaxValue);
				}
			}
		}

		public void OptimiseGemsForToughness()
		{
			var unMaxedGems = Gems.Gems.Where(g => g.CurrentLevel < g.MaxValue);
			using (Stats.SuspendRefreshingStatBindings())
			using (BeginOptimisingStatistics())
			{
				while (unMaxedGems.Any())
				{
					var bestValueGem = unMaxedGems.OrderByDescending(g => g.GetProposedToughnessIncrease(1) / g.GetCostOfNextLevel()).First();
					if (bestValueGem.GetProposedToughnessIncrease(1) == 0)
					{
						break;
					}
					bestValueGem.CurrentLevel += 1;
					unMaxedGems = Gems.Gems.Where(g => g.CurrentLevel < g.MaxValue);
				}
			}
		}

		public void OptimiseCPForDamage()
		{
			var unMaxedCP = GetUnmaxedCP();
			using (Stats.SuspendRefreshingStatBindings())
			using (BeginOptimisingStatistics())
			{
				while (unMaxedCP.Any())
				{
					var bestValueCP = unMaxedCP.OrderByDescending(cp => cp.GetProposedDamageIncrease(1) / cp.NextLevelCost).First();
					if (bestValueCP.GetProposedDamageIncrease(1) == 0)
					{
						break;
					}
					bestValueCP.CurrentLevel += 1;
					unMaxedCP = GetUnmaxedCP();
				}
			}
		}

		public void OptimiseCPForToughness()
		{
			var unMaxedCP = GetUnmaxedCP();
			using (Stats.SuspendRefreshingStatBindings())
			using (BeginOptimisingStatistics())
			{
				while (unMaxedCP.Any())
				{
					var bestValueCP = unMaxedCP.OrderByDescending(cp => cp.GetProposedToughnessIncrease(1) / cp.NextLevelCost).First();
					if (bestValueCP.GetProposedToughnessIncrease(1) == 0)
					{
						break;
					}
					bestValueCP.CurrentLevel += 1;
					unMaxedCP = GetUnmaxedCP();
				}
			}
		}

		public IEnumerable<VChallengePoint> GetUnmaxedCP()
		{
			var challengePoints = ChallengePoints as ChallengePointCollection;
			return challengePoints.AllCP.Where(cp => cp.CurrentLevel < cp.MaxValue);
		}

		public void OptimisePerksForDamage()
		{
			var unMaxedPerks = GetUnmaxedPerks();
			using (Stats.SuspendRefreshingStatBindings())
			using (BeginOptimisingStatistics())
			{
				while (unMaxedPerks.Any())
				{
					var bestValuePerk = unMaxedPerks.OrderByDescending(p => p.GetProposedDamageIncrease(p.MinimumIncreaseForOptimise) / p.GetCostOfNextLevels(p.MinimumIncreaseForOptimise)).First();
					if (bestValuePerk.GetProposedDamageIncrease(bestValuePerk.MinimumIncreaseForOptimise) == 0)
					{
						break;
					}
					bestValuePerk.DesiredLevel += (short)bestValuePerk.MinimumIncreaseForOptimise;
					unMaxedPerks = GetUnmaxedPerks();
				}
			}
		}

		private IEnumerable<VPerk> GetUnmaxedPerks()
		{
			return ((PerkCollection)Perks).AllPerks.Where(p => p.DesiredLevel < p.MaxLevel && p.Page <= Perks.MaxPage);
		}

		public void OptimisePerksForToughness()
		{
			var unMaxedPerks = GetUnmaxedPerks();
			using (Stats.SuspendRefreshingStatBindings())
			using (BeginOptimisingStatistics())
			{
				while (unMaxedPerks.Any())
				{
					var bestValuePerk = unMaxedPerks.OrderByDescending(p => p.GetProposedToughnessIncrease(p.MinimumIncreaseForOptimise) / p.GetCostOfNextLevels(p.MinimumIncreaseForOptimise)).First();
					if (bestValuePerk.GetProposedToughnessIncrease(bestValuePerk.MinimumIncreaseForOptimise) == 0)
					{
						break;
					}
					bestValuePerk.DesiredLevel += (short)bestValuePerk.MinimumIncreaseForOptimise;
					unMaxedPerks = GetUnmaxedPerks();
				}
			}
		}

		#endregion

		#region PerkPointsCost

		public override long PerkPointsCost => Perks.TotalCost + Souls.SoulCosts;

		#endregion

		#region RemainingPerkPoints

		public override long RemainingPerkPoints
		{
			get
			{
				var availablePP = Profile.PerkPoints;

				if (Mods.Taxes.CurrentLevel > 0)
				{
					availablePP = availablePP / 100 * 100;
					var penalty = availablePP * (Mods.Taxes.CurrentLevel * 0.06);
					availablePP -= (int)penalty;
				}

				return (int)availablePP - PerkPointsCost;
			}
		}

		public override bool CanAffordCurrentLoadout => RemainingPerkPoints >= 0 && Gems.RemainingGems >= 0 && ChallengePoints.RemainingCP >= 0;

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
			ShouldRestrict = true;
			SyncWithBank = true;
		}

		protected override void OnLoadedFromXML(OnLoadedEventArgs e)
		{
			base.OnLoadedFromXML(e);

			if (SyncWithBank)
			{
				BankFileSyncroniser.UpdateLoadout(this);
			}
		}

		#endregion
	}
}
