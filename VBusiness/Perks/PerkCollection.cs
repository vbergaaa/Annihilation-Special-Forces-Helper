using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using VBusiness.Loadouts;
using VEntityFramework.Model;

namespace VBusiness.Perks
{
	public class PerkCollection : VPerkCollection
	{
		#region Constructor

		public PerkCollection(VLoadout loadout) : base(loadout)
		{
			PopulateAllPerks();
			Page = 1;
		}

		#endregion

		#region Properties

		#region Loadouts



		#endregion

		#region Perks

		#region Attack

		public VPerk Attack
		{
			get
			{
				if (fAttack == null)
				{
					fAttack = new AttackPerk(this);
				}
				return fAttack;
			}
		}
		VPerk fAttack;

		#endregion

		#region AttackSpeed

		public VPerk AttackSpeed
		{
			get
			{
				if (fAttackSpeed == null)
				{
					fAttackSpeed = new AttackSpeedPerk(this);
				}
				return fAttackSpeed;
			}
		}
		VPerk fAttackSpeed;

		#endregion

		#region Health

		public VPerk Health
		{
			get
			{
				if (fHealth == null)
				{
					fHealth = new HealthPerk(this);
				}
				return fHealth;
			}
		}
		VPerk fHealth;

		#endregion

		#region HealthArmor

		public VPerk HealthArmor
		{
			get
			{
				if (fHealthArmor == null)
				{
					fHealthArmor = new HealthArmorPerk(this);
				}
				return fHealthArmor;
			}
		}
		VPerk fHealthArmor;

		#endregion

		#region Shields

		public VPerk Shields
		{
			get
			{
				if (fShields == null)
				{
					fShields = new ShieldsPerk(this);
				}
				return fShields;
			}
		}
		VPerk fShields;

		#endregion

		#region ShieldsArmor

		public VPerk ShieldsArmor
		{
			get
			{
				if (fShieldsArmor == null)
				{
					fShieldsArmor = new ShieldsArmorPerk(this);
				}
				return fShieldsArmor;
			}
		}
		VPerk fShieldsArmor;

		#endregion

		#region KillEfficiency

		public VPerk KillEfficiency
		{
			get
			{
				if (fKillEfficiency == null)
				{
					fKillEfficiency = new KillEfficiencyPerk(this);
				}
				return fKillEfficiency;
			}
		}
		VPerk fKillEfficiency;

		#endregion

		#region KillRecycle

		public VPerk KillRecycle
		{
			get
			{
				if (fKillRecycle == null)
				{
					fKillRecycle = new KillRecyclePerk(this);
				}
				return fKillRecycle;
			}
		}
		VPerk fKillRecycle;

		#endregion

		#region MaximumPotiential

		public VPerk MaximumPotiential
		{
			get
			{
				if (fMaximumPotiential == null)
				{
					fMaximumPotiential = new MaximumPotientialPerk(this);
				}
				return fMaximumPotiential;
			}
		}
		VPerk fMaximumPotiential;

		#endregion

		#region Veterancy

		public VPerk Veterancy
		{
			get
			{
				if (fVeterancy == null)
				{
					fVeterancy = new VeterancyPerk(this);
				}
				return fVeterancy;
			}
		}
		VPerk fVeterancy;

		#endregion

		#region Rank

		public VPerk Rank
		{
			get
			{
				if (fRank == null)
				{
					fRank = new RankPerk(this);
				}
				return fRank;
			}
		}
		VPerk fRank;

		#endregion

		#region InfusionRecycle

		public VPerk InfusionRecycle
		{
			get
			{
				if (fInfusionRecycle == null)
				{
					fInfusionRecycle = new InfusionRecyclePerk(this);
				}
				return fInfusionRecycle;
			}
		}
		VPerk fInfusionRecycle;

		#endregion

		#region DoubleWarp

		public VPerk DoubleWarp
		{
			get
			{
				if (fDoubleWarp == null)
				{
					fDoubleWarp = new DoubleWarpPerk(this);
				}
				return fDoubleWarp;
			}
		}
		VPerk fDoubleWarp;

		#endregion

		#region StartingMinerals

		public VPerk StartingMinerals
		{
			get
			{
				if (fStartingMinerals == null)
				{
					fStartingMinerals = new StartingMineralsPerk(this);
				}
				return fStartingMinerals;
			}
		}
		VPerk fStartingMinerals;

		#endregion

		#region MasterTrainer

		public VPerk MasterTrainer
		{
			get
			{
				if (fMasterTrainer == null)
				{
					fMasterTrainer = new MasterTrainerPerk(this);
				}
				return fMasterTrainer;
			}
		}
		VPerk fMasterTrainer;

		#endregion

		#region ExtraSupply

		public VPerk ExtraSupply
		{
			get
			{
				if (fExtraSupply == null)
				{
					fExtraSupply = new ExtraSupplyPerk(this);
				}
				return fExtraSupply;
			}
		}
		VPerk fExtraSupply;

		#endregion

		#region MineralJackpot

		public VPerk MineralJackpot
		{
			get
			{
				if (fMineralJackpot == null)
				{
					fMineralJackpot = new MineralJackpotPerk(this);
				}
				return fMineralJackpot;
			}
		}
		VPerk fMineralJackpot;

		#endregion

		#region AutomaticRefinery

		public VPerk AutomaticRefinery
		{
			get
			{
				if (fAutomaticRefinery == null)
				{
					fAutomaticRefinery = new AutomaticRefineryPerk(this);
				}
				return fAutomaticRefinery;
			}
		}
		VPerk fAutomaticRefinery;

		#endregion

		#region AdrenalineRush

		public VPerk AdrenalineRush
		{
			get
			{
				if (fAdrenalineRush == null)
				{
					fAdrenalineRush = new AdrenalineRushPerk(this);
				}
				return fAdrenalineRush;
			}
		}
		VPerk fAdrenalineRush;

		#endregion

		#region CriticalChance

		public VPerk CriticalChance
		{
			get
			{
				if (fCriticalChance == null)
				{
					fCriticalChance = new CriticalChancePerk(this);
				}
				return fCriticalChance;
			}
		}
		VPerk fCriticalChance;

		#endregion

		#region CriticalDamage

		public VPerk CriticalDamage
		{
			get
			{
				if (fCriticalDamage == null)
				{
					fCriticalDamage = new CriticalDamagePerk(this);
				}
				return fCriticalDamage;
			}
		}
		VPerk fCriticalDamage;

		#endregion

		#region DamageReduction

		public VPerk DamageReduction
		{
			get
			{
				if (fDamageReduction == null)
				{
					fDamageReduction = new DamageReductionPerk(this);
				}
				return fDamageReduction;
			}
		}
		VPerk fDamageReduction;

		#endregion

		#region OverSpeed

		public VPerk OverSpeed
		{
			get
			{
				if (fOverSpeed == null)
				{
					fOverSpeed = new OverSpeedPerk(this);
				}
				return fOverSpeed;
			}
		}
		VPerk fOverSpeed;

		#endregion

		#region UnitSpecialization

		public VPerk UnitSpecialization
		{
			get
			{
				if (fUnitSpecialization == null)
				{
					fUnitSpecialization = new UnitSpecializationPerk(this);
				}
				return fUnitSpecialization;
			}
		}
		VPerk fUnitSpecialization;

		#endregion

		#region KillEfficiency2

		public VPerk KillEfficiency2
		{
			get
			{
				if (fKillEfficiency2 == null)
				{
					fKillEfficiency2 = new KillEfficiency2Perk(this);
				}
				return fKillEfficiency2;
			}
		}
		VPerk fKillEfficiency2;

		#endregion

		#region MaximumGather

		public VPerk MaximumGather
		{
			get
			{
				if (fMaximumGather == null)
				{
					fMaximumGather = new MaximumGatherPerk(this);
				}
				return fMaximumGather;
			}
		}
		VPerk fMaximumGather;

		#endregion

		#region MaximumPotiential2

		public VPerk MaximumPotiential2
		{
			get
			{
				if (fMaximumPotiential2 == null)
				{
					fMaximumPotiential2 = new MaximumPotiential2Perk(this);
				}
				return fMaximumPotiential2;
			}
		}
		VPerk fMaximumPotiential2;

		#endregion

		#region QuickStart

		public VPerk QuickStart
		{
			get
			{
				if (fQuickStart == null)
				{
					fQuickStart = new QuickStartPerk(this);
				}
				return fQuickStart;
			}
		}
		VPerk fQuickStart;

		#endregion

		#region RankRevision

		public VPerk RankRevision
		{
			get
			{
				if (fRankRevision == null)
				{
					fRankRevision = new RankRevisionPerk(this);
				}
				return fRankRevision;
			}
		}
		VPerk fRankRevision;

		#endregion

		#region Veterancy2

		public VPerk Veterancy2
		{
			get
			{
				if (fVeterancy2 == null)
				{
					fVeterancy2 = new Veterancy2Perk(this);
				}
				return fVeterancy2;
			}
		}
		VPerk fVeterancy2;

		#endregion

		#region BuildingRecycle

		public VPerk BuildingRecycle
		{
			get
			{
				if (fBuildingRecycle == null)
				{
					fBuildingRecycle = new BuildingRecyclePerk(this);
				}
				return fBuildingRecycle;
			}
		}
		VPerk fBuildingRecycle;

		#endregion

		#region CriticalCollection

		public VPerk CriticalCollection
		{
			get
			{
				if (fCriticalCollection == null)
				{
					fCriticalCollection = new CriticalCollectionPerk(this);
				}
				return fCriticalCollection;
			}
		}
		VPerk fCriticalCollection;

		#endregion

		#region CriticalHarvest

		public VPerk CriticalHarvest
		{
			get
			{
				if (fCriticalHarvest == null)
				{
					fCriticalHarvest = new CriticalHarvestPerk(this);
					
				}
				return fCriticalHarvest;
			}
		}
		VPerk fCriticalHarvest;

		#endregion

		#region DoubleWarp2

		public VPerk DoubleWarp2
		{
			get
			{
				if (fDoubleWarp2 == null)
				{
					fDoubleWarp2 = new DoubleWarp2Perk(this);
				}
				return fDoubleWarp2;
			}
		}
		VPerk fDoubleWarp2;

		#endregion

		#region ExpertMiner

		public VPerk ExpertMiner
		{
			get
			{
				if (fExpertMiner == null)
				{
					fExpertMiner = new ExpertMinerPerk(this);
				}
				return fExpertMiner;
			}
		}
		VPerk fExpertMiner;

		#endregion

		#region MineralJackpot2

		public VPerk MineralJackpot2
		{
			get
			{
				if (fMineralJackpot2 == null)
				{
					fMineralJackpot2 = new MineralJackpot2Perk(this);
				}
				return fMineralJackpot2;
			}
		}
		VPerk fMineralJackpot2;

		#endregion

		#region AcceleratedFusion

		public VPerk AcceleratedFusion
		{
			get
			{
				if (fAcceleratedFusion == null)
				{
					fAcceleratedFusion = new AcceleratedFusionPerk(this);
				}
				return fAcceleratedFusion;
			}
		}
		VPerk fAcceleratedFusion;

		#endregion

		#region FastLearner

		public VPerk FastLearner
		{
			get
			{
				if (fFastLearner == null)
				{
					fFastLearner = new FastLearnerPerk(this);
				}
				return fFastLearner;
			}
		}
		VPerk fFastLearner;

		#endregion

		#region MiningExpertise

		public VPerk MiningExpertise
		{
			get
			{
				if (fMiningExpertise == null)
				{
					fMiningExpertise = new MiningExpertisePerk(this);
				}
				return fMiningExpertise;
			}
		}
		VPerk fMiningExpertise;

		#endregion

		#region TrainingCenter

		public VPerk TrainingCenter
		{
			get
			{
				if (fTrainingCenter == null)
				{
					fTrainingCenter = new TrainingCenterPerk(this);
				}
				return fTrainingCenter;
			}
		}
		VPerk fTrainingCenter;

		#endregion

		#region TrifectaPower

		public VPerk TrifectaPower
		{
			get
			{
				if (fTrifectaPower == null)
				{
					fTrifectaPower = new TrifectaPowerPerk(this);
				}
				return fTrifectaPower;
			}
		}
		VPerk fTrifectaPower;

		#endregion

		#region UnitStorage

		public VPerk UnitStorage
		{
			get
			{
				if (fUnitStorage == null)
				{
					fUnitStorage = new UnitStoragePerk(this);
				}
				return fUnitStorage;
			}
		}
		VPerk fUnitStorage;

		#endregion

		#region Alacrity

		public VPerk Alacrity
		{
			get
			{
				if (fAlacrity == null)
				{
					fAlacrity = new AlacrityPerk(this);
				}
				return fAlacrity;
			}
		}
		VPerk fAlacrity;

		#endregion

		#region BalancedTraining

		public VPerk BalancedTraining
		{
			get
			{
				if (fBalancedTraining == null)
				{
					fBalancedTraining = new BalancedTrainingPerk(this);
				}
				return fBalancedTraining;
			}
		}
		VPerk fBalancedTraining;

		#endregion

		#region CooldownSpeed

		public VPerk CooldownSpeed
		{
			get
			{
				if (fCooldownSpeed == null)
				{
					fCooldownSpeed = new CooldownSpeedPerk(this);
				}
				return fCooldownSpeed;
			}
		}
		VPerk fCooldownSpeed;

		#endregion

		#region CriticalChance2

		public VPerk CriticalChance2
		{
			get
			{
				if (fCriticalChance2 == null)
				{
					fCriticalChance2 = new CriticalChance2Perk(this);
				}
				return fCriticalChance2;
			}
		}
		VPerk fCriticalChance2;

		#endregion

		#region CriticalDamage2

		public VPerk CriticalDamage2
		{
			get
			{
				if (fCriticalDamage2 == null)
				{
					fCriticalDamage2 = new CriticalDamage2Perk(this);
				}
				return fCriticalDamage2;
			}
		}
		VPerk fCriticalDamage2;

		#endregion

		#region RedCrits

		public VPerk RedCrits
		{
			get
			{
				if (fRedCrits == null)
				{
					fRedCrits = new RedCritsPerk(this);
				}
				return fRedCrits;
			}
		}
		VPerk fRedCrits;

		#endregion

		#region InfusionRecycle2

		public VPerk InfusionRecycle2
		{
			get
			{
				if (fInfusionRecycle2 == null)
				{
					fInfusionRecycle2 = new InfusionRecycle2Perk(this);
				}
				return fInfusionRecycle2;
			}
		}
		VPerk fInfusionRecycle2;

		#endregion

		#region KillHarvest

		public VPerk KillHarvest
		{
			get
			{
				if (fKillHarvest == null)
				{
					fKillHarvest = new KillHarvestPerk(this);
				}
				return fKillHarvest;
			}
		}
		VPerk fKillHarvest;

		#endregion

		#region MaximumGather2

		public VPerk MaximumGather2
		{
			get
			{
				if (fMaximumGather2 == null)
				{
					fMaximumGather2 = new MaximumGather2Perk(this);
				}
				return fMaximumGather2;
			}
		}
		VPerk fMaximumGather2;

		#endregion

		#region MaximumPotiental3

		public VPerk MaximumPotiental3
		{
			get
			{
				if (fMaximumPotiental3 == null)
				{
					fMaximumPotiental3 = new MaximumPotiental3Perk(this);
				}
				return fMaximumPotiental3;
			}
		}
		VPerk fMaximumPotiental3;

		#endregion

		#region RankRevision2

		public VPerk RankRevision2
		{
			get
			{
				if (fRankRevision2 == null)
				{
					fRankRevision2 = new RankRevision2Perk(this);
				}
				return fRankRevision2;
			}
		}
		VPerk fRankRevision2;

		#endregion

		#region Veterancy3

		public VPerk Veterancy3
		{
			get
			{
				if (fVeterancy3 == null)
				{
					fVeterancy3 = new Veterancy3Perk(this);
				}
				return fVeterancy3;
			}
		}
		VPerk fVeterancy3;

		#endregion

		#region AutomaticRefinery2

		public VPerk AutomaticRefinery2
		{
			get
			{
				if (fAutomaticRefinery2 == null)
				{
					fAutomaticRefinery2 = new AutomaticRefinery2Perk(this);
				}
				return fAutomaticRefinery2;
			}
		}
		VPerk fAutomaticRefinery2;

		#endregion

		#region CriticalHarvest2

		public VPerk CriticalHarvest2
		{
			get
			{
				if (fCriticalHarvest2 == null)
				{
					fCriticalHarvest2 = new CriticalHarvest2Perk(this);
				}
				return fCriticalHarvest2;
			}
		}
		VPerk fCriticalHarvest2;

		#endregion

		#region DoubleWarp3

		public VPerk DoubleWarp3
		{
			get
			{
				if (fDoubleWarp3 == null)
				{
					fDoubleWarp3 = new DoubleWarp3Perk(this);
				}
				return fDoubleWarp3;
			}
		}
		VPerk fDoubleWarp3;

		#endregion

		#region MineralJackpot3

		public VPerk MineralJackpot3
		{
			get
			{
				if (fMineralJackpot3 == null)
				{
					fMineralJackpot3 = new MineralJackpot3Perk(this);
				}
				return fMineralJackpot3;
			}
		}
		VPerk fMineralJackpot3;

		#endregion

		#region SuperJackpot

		public VPerk SuperJackpot
		{
			get
			{
				if (fSuperJackpot == null)
				{
					fSuperJackpot = new SuperJackpotPerk(this);
				}
				return fSuperJackpot;
			}
		}
		VPerk fSuperJackpot;

		#endregion

		#region TripleWarp

		public VPerk TripleWarp
		{
			get
			{
				if (fTripleWarp == null)
				{
					fTripleWarp = new TripleWarpPerk(this);
				}
				return fTripleWarp;
			}
		}
		VPerk fTripleWarp;

		#endregion

		#region Alacrity2

		public VPerk Alacrity2
		{
			get
			{
				if (fAlacrity2 == null)
				{
					fAlacrity2 = new Alacrity2Perk(this);
				}
				return fAlacrity2;
			}
		}
		VPerk fAlacrity2;

		#endregion

		#region BalancedTraining2

		public VPerk BalancedTraining2
		{
			get
			{
				if (fBalancedTraining2 == null)
				{
					fBalancedTraining2 = new BalancedTraining2Perk(this);
				}
				return fBalancedTraining2;
			}
		}
		VPerk fBalancedTraining2;

		#endregion

		#region CriticalChance3

		public VPerk CriticalChance3
		{
			get
			{
				if (fCriticalChance3 == null)
				{
					fCriticalChance3 = new CriticalChance3Perk(this);
				}
				return fCriticalChance3;
			}
		}
		VPerk fCriticalChance3;

		#endregion

		#region CriticalDamage3

		public VPerk CriticalDamage3
		{
			get
			{
				if (fCriticalDamage3 == null)
				{
					fCriticalDamage3 = new CriticalDamage3Perk(this);
				}
				return fCriticalDamage3;
			}
		}
		VPerk fCriticalDamage3;

		#endregion

		#region DamageReduction2

		public VPerk DamageReduction2
		{
			get
			{
				if (fDamageReduction2 == null)
				{
					fDamageReduction2 = new DamageReduction2Perk(this);
				}
				return fDamageReduction2;
			}
		}
		VPerk fDamageReduction2;

		#endregion

		#region SuperRush

		public VPerk SuperRush
		{
			get
			{
				if (fSuperRush == null)
				{
					fSuperRush = new SuperRushPerk(this);
				}
				return fSuperRush;
			}
		}
		VPerk fSuperRush;

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

		public override int RemainingCost => allPerks.Sum(p => p.RemainingCost);

		public override int TotalCost => allPerks.Sum(p => p.TotalCost);

		public override int CurrentCost => allPerks.Sum(p => p.CurrentCost);

		#endregion

		#region PageTitle

		public override string PageTitle => $"Page {Page}";

		#endregion

		#endregion
	}
}
