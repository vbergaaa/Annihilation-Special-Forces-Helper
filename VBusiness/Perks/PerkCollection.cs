using System.Collections.Generic;
using System.Linq;
using VEntityFramework.Model;

namespace VBusiness.Perks
{
	public class PerkCollection : VPerkCollection
	{
		#region Constructor

		public PerkCollection()
		{
			PopulateAllPerks();
			Page = 1;
		}

		#endregion

		#region Properties

		#region Perks

		#region Attack

		public override VPerk Attack
		{
			get => attack ?? (attack = new AttackPerk());
		}
		VPerk attack;

		#endregion

		#region AttackSpeed

		public override VPerk AttackSpeed
		{
			get => attackSpeed ?? (attackSpeed = new AttackSpeedPerk());
		}
		VPerk attackSpeed;

		#endregion

		#region Health

		public override VPerk Health
		{
			get => health ?? (health = new HealthPerk());
		}
		VPerk health;

		#endregion

		#region HealthArmor

		public override VPerk HealthArmor
		{
			get => healthArmor ?? (healthArmor = new HealthArmorPerk());
		}
		VPerk healthArmor;

		#endregion

		#region Shields

		public override VPerk Shields
		{
			get => shields ?? (shields = new ShieldsPerk());
		}
		VPerk shields;

		#endregion

		#region ShieldsArmor

		public override VPerk ShieldsArmor
		{
			get => shieldsArmor ?? (shieldsArmor = new ShieldsArmorPerk());
		}
		VPerk shieldsArmor;

		#endregion

		#region KillEfficiency

		public override VPerk KillEfficiency
		{
			get => killEfficiency ?? (killEfficiency = new KillEfficiencyPerk());
		}
		VPerk killEfficiency;

		#endregion

		#region KillRecycle

		public override VPerk KillRecycle
		{
			get => killRecycle ?? (killRecycle = new KillRecyclePerk());
		}
		VPerk killRecycle;

		#endregion

		#region MaximumPotiential

		public override VPerk MaximumPotiential
		{
			get => maximumPotiential ?? (maximumPotiential = new MaximumPotientialPerk());
		}
		VPerk maximumPotiential;

		#endregion

		#region Veterancy

		public override VPerk Veterancy
		{
			get => veterancy ?? (veterancy = new VeterancyPerk());
		}
		VPerk veterancy;

		#endregion

		#region Rank

		public override VPerk Rank
		{
			get => rank ?? (rank = new RankPerk());
		}
		VPerk rank;

		#endregion

		#region InfusionRecycle

		public override VPerk InfusionRecycle
		{
			get => infusionRecycle ?? (infusionRecycle = new BaseInfusionRecyclePerk());
		}
		VPerk infusionRecycle;

		#endregion

		#region DoubleWarp

		public override VPerk DoubleWarp
		{
			get => doubleWarp ?? (doubleWarp = new BaseDoubleWarpPerk());
		}
		VPerk doubleWarp;

		#endregion

		#region StartingMinerals

		public override VPerk StartingMinerals
		{
			get => startingMinerals ?? (startingMinerals = new StartingMineralsPerk());
		}
		VPerk startingMinerals;

		#endregion

		#region MasterTrainer

		public override VPerk MasterTrainer
		{
			get => masterTrainer ?? (masterTrainer = new MasterTrainerPerk());
		}
		VPerk masterTrainer;

		#endregion

		#region ExtraSupply

		public override VPerk ExtraSupply
		{
			get => extraSupply ?? (extraSupply = new ExtraSupplyPerk());
		}
		VPerk extraSupply;

		#endregion

		#region MineralJackpot

		public override VPerk MineralJackpot
		{
			get => mineralJackpot ?? (mineralJackpot = new MineralJackpotPerk());
		}
		VPerk mineralJackpot;

		#endregion

		#region AutomaticRefinery

		public override VPerk AutomaticRefinery
		{
			get => automaticRefinery ?? (automaticRefinery = new AutomaticRefineryPerk());
		}
		VPerk automaticRefinery;

		#endregion

		#region AdrenalineRush

		public override VPerk AdrenalineRush
		{
			get => adrenalineRush ?? (adrenalineRush = new AdrenalineRushPerk());
		}
		VPerk adrenalineRush;

		#endregion

		#region CriticalChance

		public override VPerk CriticalChance
		{
			get => criticalChance ?? (criticalChance = new CriticalChancePerk());
		}
		VPerk criticalChance;

		#endregion

		#region CriticalDamage

		public override VPerk CriticalDamage
		{
			get => criticalDamage ?? (criticalDamage = new CriticalDamagePerk());
		}
		VPerk criticalDamage;

		#endregion

		#region DamageReduction

		public override VPerk DamageReduction
		{
			get => damageReduction ?? (damageReduction = new DamageReductionPerk());
		}
		VPerk damageReduction;

		#endregion

		#region OverSpeed

		public override VPerk OverSpeed
		{
			get => overSpeed ?? (overSpeed = new OverSpeedPerk());
		}
		VPerk overSpeed;

		#endregion

		#region UnitSpecialization

		public override VPerk UnitSpecialization
		{
			get => unitSpecialization ?? (unitSpecialization = new UnitSpecializationPerk());
		}
		VPerk unitSpecialization;

		#endregion

		#region KillEfficiency2

		public override VPerk KillEfficiency2
		{
			get => killEfficiency2 ?? (killEfficiency2 = new KillEfficiency2Perk());
		}
		VPerk killEfficiency2;

		#endregion

		#region MaximumGather

		public override VPerk MaximumGather
		{
			get => maximumGather ?? (maximumGather = new MaximumGatherPerk());
		}
		VPerk maximumGather;

		#endregion

		#region MaximumPotiential2

		public override VPerk MaximumPotiential2
		{
			get => maximumPotiential2 ?? (maximumPotiential2 = new MaximumPotiential2Perk());
		}
		VPerk maximumPotiential2;

		#endregion

		#region QuickStart

		public override VPerk QuickStart
		{
			get => quickStart ?? (quickStart = new QuickStartPerk());
		}
		VPerk quickStart;

		#endregion

		#region RankRevision

		public override VPerk RankRevision
		{
			get => rankRevision ?? (rankRevision = new RankRevisionPerk());
		}
		VPerk rankRevision;

		#endregion

		#region Veterancy2

		public override VPerk Veterancy2
		{
			get => veterancy2 ?? (veterancy2 = new Veterancy2Perk());
		}
		VPerk veterancy2;

		#endregion

		#region BuildingRecycle

		public override VPerk BuildingRecycle
		{
			get => buildingRecycle ?? (buildingRecycle = new BuildingRecyclePerk());
		}
		VPerk buildingRecycle;

		#endregion

		#region CriticalCollection

		public override VPerk CriticalCollection
		{
			get => criticalCollection ?? (criticalCollection = new CriticalCollectionPerk());
		}
		VPerk criticalCollection;

		#endregion

		#region CriticalHarvest

		public override VPerk CriticalHarvest
		{
			get => crititcalHarvest ?? (crititcalHarvest = new CriticalHarvestPerk());
		}
		VPerk crititcalHarvest;

		#endregion

		#region DoubleWarp2

		public override VPerk DoubleWarp2
		{
			get => doubleWarp2 ?? (doubleWarp2 = new DoubleWarp2Perk());
		}
		VPerk doubleWarp2;

		#endregion

		#region ExpertMiner

		public override VPerk ExpertMiner
		{
			get => expertMiner ?? (expertMiner = new ExpertMinerPerk());
		}
		VPerk expertMiner;

		#endregion

		#region MineralJackpot2

		public override VPerk MineralJackpot2
		{
			get => mineralJackpot2 ?? (mineralJackpot2 = new MineralJackpot2Perk());
		}
		VPerk mineralJackpot2;

		#endregion

		#region AcceleratedFusion

		public override VPerk AcceleratedFusion
		{
			get => acceleratedFusion ?? (acceleratedFusion = new AcceleratedFusionPerk());
		}
		VPerk acceleratedFusion;

		#endregion

		#region FastLearner

		public override VPerk FastLearner
		{
			get => fastLearner ?? (fastLearner = new FastLearnerPerk());
		}
		VPerk fastLearner;

		#endregion

		#region MiningExpertise

		public override VPerk MiningExpertise
		{
			get => miningExpertise ?? (miningExpertise = new MiningExpertisePerk());
		}
		VPerk miningExpertise;

		#endregion

		#region TrainingCenter

		public override VPerk TrainingCenter
		{
			get => trainingCenter ?? (trainingCenter = new TrainingCenterPerk());
		}
		VPerk trainingCenter;

		#endregion

		#region TrifectaPower

		public override VPerk TrifectaPower
		{
			get => trifectaPower ?? (trifectaPower = new TrifectaPowerPerk());
		}
		VPerk trifectaPower;

		#endregion

		#region UnitStorage

		public override VPerk UnitStorage
		{
			get => unitStorage ?? (unitStorage = new UnitStoragePerk());
		}
		VPerk unitStorage;

		#endregion

		#region Alacrity

		public override VPerk Alacrity
		{
			get => alacrity ?? (alacrity = new AlacrityPerk());
		}
		VPerk alacrity;

		#endregion

		#region BalancedTraining

		public override VPerk BalancedTraining
		{
			get => balancedTraining ?? (balancedTraining = new BalancedTrainingPerk());
		}
		VPerk balancedTraining;

		#endregion

		#region CooldownSpeed

		public override VPerk CooldownSpeed
		{
			get => cooldownSpeed ?? (cooldownSpeed = new CooldownSpeedPerk());
		}
		VPerk cooldownSpeed;

		#endregion

		#region CriticalChance2

		public override VPerk CriticalChance2
		{
			get => criticalChance2 ?? (criticalChance2 = new CriticalChance2Perk());
		}
		VPerk criticalChance2;

		#endregion

		#region CriticalDamage2

		public override VPerk CriticalDamage2
		{
			get => criticalDamage2 ?? (criticalDamage2 = new CriticalDamage2Perk());
		}
		VPerk criticalDamage2;

		#endregion

		#region RedCrits

		public override VPerk RedCrits
		{
			get => redCrits ?? (redCrits = new RedCritsPerk());
		}
		VPerk redCrits;

		#endregion

		#region InfusionRecycle2

		public override VPerk InfusionRecycle2
		{
			get => infusionRecycle2 ?? (infusionRecycle2 = new InfusionRecycle2Perk());
		}
		VPerk infusionRecycle2;

		#endregion

		#region KillHarvest

		public override VPerk KillHarvest
		{
			get => killHarvest ?? (killHarvest = new KillHarvestPerk());
		}
		VPerk killHarvest;

		#endregion

		#region MaximumGather2

		public override VPerk MaximumGather2
		{
			get => maximumGather2 ?? (maximumGather2 = new MaximumGather2Perk());
		}
		VPerk maximumGather2;

		#endregion

		#region MaximumPotiental3

		public override VPerk MaximumPotiental3
		{
			get => maximumPotiential3 ?? (maximumPotiential3 = new MaximumPotiental3Perk());
		}
		VPerk maximumPotiential3;

		#endregion

		#region RankRevision2

		public override VPerk RankRevision2
		{
			get => rankRevision2 ?? (rankRevision2 = new RankRevision2Perk());
		}
		VPerk rankRevision2;

		#endregion

		#region Veterancy3

		public override VPerk Veterancy3
		{
			get => veterancy3 ?? (veterancy3 = new Veterancy3Perk());
		}
		VPerk veterancy3;

		#endregion

		#region AutomaticRefinery2

		public override VPerk AutomaticRefinery2
		{
			get => automaticRefinery2 ?? (automaticRefinery2 = new AutomaticRefinery2Perk());
		}
		VPerk automaticRefinery2;

		#endregion

		#region CriticalHarvest2

		public override VPerk CriticalHarvest2
		{
			get => criticalHarvest2 ?? (criticalHarvest2 = new CriticalHarvest2Perk());
		}
		VPerk criticalHarvest2;

		#endregion

		#region DoubleWarp3

		public override VPerk DoubleWarp3
		{
			get => doubleWarp3 ?? (doubleWarp3 = new DoubleWarp3Perk());
		}
		VPerk doubleWarp3;

		#endregion

		#region MineralJackpot3

		public override VPerk MineralJackpot3
		{
			get => mineralJackpot3 ?? (mineralJackpot3 = new MineralJackpot3Perk());
		}
		VPerk mineralJackpot3;

		#endregion

		#region SuperJackpot

		public override VPerk SuperJackpot
		{
			get => superJackpot ?? (superJackpot = new SuperJackpotPerk());
		}
		VPerk superJackpot;

		#endregion

		#region TripleWarp

		public override VPerk TripleWarp
		{
			get => tripleWarp ?? (tripleWarp = new TripleWarpPerk());
		}
		VPerk tripleWarp;

		#endregion

		#region Alacrity2

		public override VPerk Alacrity2
		{
			get => alacrity2 ?? (alacrity2 = new Alacrity2Perk());
		}
		VPerk alacrity2;

		#endregion

		#region BalancedTraining2

		public override VPerk BalancedTraining2
		{
			get => balancedTraining2 ?? (balancedTraining2 = new BalancedTraining2Perk());
		}
		VPerk balancedTraining2;

		#endregion

		#region CriticalChance3

		public override VPerk CriticalChance3
		{
			get => criticalChance3 ?? (criticalChance3 = new CriticalChance3Perk());
		}
		VPerk criticalChance3;

		#endregion

		#region CriticalDamage3

		public override VPerk CriticalDamage3
		{
			get => criticalDamage3 ?? (criticalDamage3 = new CriticalDamage3Perk());
		}
		VPerk criticalDamage3;

		#endregion

		#region DamageReduction2

		public override VPerk DamageReduction2
		{
			get => damageReduction2 ?? (damageReduction2 = new DamageReduction2Perk());
		}
		VPerk damageReduction2;

		#endregion

		#region SuperRush

		public override VPerk SuperRush
		{
			get => superRush ?? (superRush = new SuperRushPerk());
		}
		VPerk superRush;

		#endregion

		#endregion

		#region AllPerks

		IEnumerable<VPerk> allPerks;

		void PopulateAllPerks()
		{
			var perks = new List<VPerk>
			{
				Attack,
				AttackSpeed,
				Health,
				HealthArmor,
				Shields,
				ShieldsArmor,
				KillEfficiency,
				KillRecycle,
				MaximumPotiential,
				Veterancy,
				Rank,
				InfusionRecycle,
				DoubleWarp,
				StartingMinerals,
				MasterTrainer,
				ExtraSupply,
				MineralJackpot,
				AutomaticRefinery,
				AdrenalineRush,
				CriticalChance,
				CriticalDamage,
				DamageReduction,
				OverSpeed,
				UnitSpecialization,
				KillEfficiency2,
				MaximumGather,
				MaximumPotiential2,
				QuickStart,
				RankRevision,
				Veterancy2,
				BuildingRecycle,
				CriticalCollection,
				CriticalHarvest,
				DoubleWarp2,
				ExpertMiner,
				MineralJackpot2,
				AcceleratedFusion,
				FastLearner,
				MiningExpertise,
				TrainingCenter,
				TrifectaPower,
				UnitStorage,
				Alacrity,
				BalancedTraining,
				CooldownSpeed,
				CriticalChance2,
				CriticalDamage2,
				RedCrits,
				InfusionRecycle2,
				KillHarvest,
				MaximumPotiental3,
				MaximumGather2,
				RankRevision2,
				Veterancy3,
				AutomaticRefinery2,
				CriticalHarvest2,
				DoubleWarp3,
				MineralJackpot3,
				SuperJackpot,
				TripleWarp,
				BalancedTraining2,
				CriticalChance3,
				CriticalDamage3,
				DamageReduction2,
				SuperRush,
				Alacrity2
			};

			allPerks = perks;
		}

		#endregion

		#region Pages For Binding

		public override int Page
		{
			get => base.Page;
			set => base.Page = value;
		}

		public override VPerk Perk1 => allPerks.Where(p => p.Page == Page && p.Position == 1).FirstOrDefault();

		public override VPerk Perk2 => allPerks.Where(p => p.Page == Page && p.Position == 2).FirstOrDefault();

		public override VPerk Perk3 => allPerks.Where(p => p.Page == Page && p.Position == 3).FirstOrDefault();

		public override VPerk Perk4 => allPerks.Where(p => p.Page == Page && p.Position == 4).FirstOrDefault();

		public override VPerk Perk5 => allPerks.Where(p => p.Page == Page && p.Position == 5).FirstOrDefault();

		public override VPerk Perk6 => allPerks.Where(p => p.Page == Page && p.Position == 6).FirstOrDefault();

		public VPerk[] OrderedPerksForDebug => allPerks.OrderBy(p => p.Page).ThenBy(p => p.Position).ToArray();
		#endregion

		#region Cost

		public override int Cost => allPerks.Sum(p => p.Cost);

		public override int CostForPage => allPerks.Where(p => p.Page == Page).Sum(p => p.Cost);

		#endregion

		#region PageTitle

		public override string PageTitle => $"Page {Page}";

		#endregion

		#endregion
	}
}
