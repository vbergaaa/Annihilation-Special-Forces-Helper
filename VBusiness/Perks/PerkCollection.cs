using EnumsNET;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using VBusiness.PlayerRanks;
using VEntityFramework.Model;

[assembly: InternalsVisibleTo("Tests")]
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

		#region MaxPage

		public override int MaxPage
		{
			get
			{
				if (Loadout.ShouldRestrict)
				{
					return Loadout.Profile.Rank.GetMaxPerkPage();
				}

				var lastRank = Enums.GetValues<PlayerRank>().Last();
				return lastRank.GetMaxPerkPage();
			}
		}

		#endregion

		#region Perks

		#region Attack

		public override VPerk Attack
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

		public override VPerk AttackSpeed
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

		public override VPerk Health
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

		public override VPerk HealthArmor
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

		public override VPerk Shields
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

		public override VPerk ShieldsArmor
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

		public override VPerk KillEfficiency
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

		public override VPerk KillRecycle
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

		public override VPerk MaximumPotiential
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

		public override VPerk Veterancy
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

		public override VPerk Rank
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

		public override VPerk InfusionRecycle
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

		public override VPerk DoubleWarp
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

		public override VPerk StartingMinerals
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

		public override VPerk MasterTrainer
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

		public override VPerk ExtraSupply
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

		public override VPerk MineralJackpot
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

		public override VPerk AutomaticRefinery
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

		public override VPerk AdrenalineRush
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

		public override VPerk CriticalChance
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

		public override VPerk CriticalDamage
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

		public override VPerk DamageReduction
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

		public override VPerk OverSpeed
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

		public override VPerk UnitSpecialization
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

		public override VPerk KillEfficiency2
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

		public override VPerk MaximumGather
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

		public override VPerk MaximumPotiential2
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

		public override VPerk QuickStart
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

		public override VPerk RankRevision
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

		public override VPerk Veterancy2
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

		public override VPerk BuildingRecycle
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

		public override VPerk CriticalCollection
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

		public override VPerk CriticalHarvest
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

		public override VPerk DoubleWarp2
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

		public override VPerk ExpertMiner
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

		public override VPerk MineralJackpot2
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

		public override VPerk AcceleratedFusion
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

		public override VPerk FastLearner
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

		public override VPerk MiningExpertise
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

		public override VPerk TrainingCenter
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

		public override VPerk TrifectaPower
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

		public override VPerk UnitStorage
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

		public override VPerk Alacrity
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

		public override VPerk BalancedTraining
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

		public override VPerk CooldownSpeed
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

		public override VPerk CriticalChance2
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

		public override VPerk CriticalDamage2
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

		public override VPerk RedCrits
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

		public override VPerk InfusionRecycle2
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

		public override VPerk KillHarvest
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

		public override VPerk MaximumGather2
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

		public override VPerk MaximumPotiental3
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

		public override VPerk RankRevision2
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

		public override VPerk Veterancy3
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

		public override VPerk AutomaticRefinery2
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

		public override VPerk CriticalHarvest2
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

		public override VPerk DoubleWarp3
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

		public override VPerk MineralJackpot3
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

		public override VPerk SuperJackpot
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

		public override VPerk TripleWarp
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

		public override VPerk Alacrity2
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

		public override VPerk BalancedTraining2
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

		public override VPerk CriticalChance3
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

		public override VPerk CriticalDamage3
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

		public override VPerk DamageReduction2
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

		public override VPerk SuperRush
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

		#region InfusionRecycle3

		public override VPerk InfusionRecycle3
		{
			get
			{
				if (fInfusionRecycle3 == null)
				{
					fInfusionRecycle3 = new InfusionRecycle3Perk(this);
				}
				return fInfusionRecycle3;
			}
		}
		VPerk fInfusionRecycle3;

		#endregion

		#region MaximumPotential4

		public override VPerk MaximumPotential4
		{
			get
			{
				if (fMaximumPotential4 == null)
				{
					fMaximumPotential4 = new MaximumPotential4Perk(this);
				}
				return fMaximumPotential4;
			}
		}
		VPerk fMaximumPotential4;

		#endregion

		#region Veterancy4

		public override VPerk Veterancy4
		{
			get
			{
				if (fVeterancy4 == null)
				{
					fVeterancy4 = new Veterancy4Perk(this);
				}
				return fVeterancy4;
			}
		}
		VPerk fVeterancy4;

		#endregion

		#region KillRecycle2

		public override VPerk KillRecycle2
		{
			get
			{
				if (fKillRecycle2 == null)
				{
					fKillRecycle2 = new KillRecycle2Perk(this);
				}
				return fKillRecycle2;
			}
		}
		VPerk fKillRecycle2;

		#endregion

		#region DNAStart

		public override VPerk DNAStart
		{
			get
			{
				if (fDNAStart == null)
				{
					fDNAStart = new DNAStartPerk(this);
				}
				return fDNAStart;
			}
		}
		VPerk fDNAStart;

		#endregion

		#region RankRevision3

		public override VPerk RankRevision3
		{
			get
			{
				if (fRankRevision3 == null)
				{
					fRankRevision3 = new RankRevision3Perk(this);
				}
				return fRankRevision3;
			}
		}
		VPerk fRankRevision3;

		#endregion

		#region DoubleWarp4

		public override VPerk DoubleWarp4
		{
			get
			{
				if (fDoubleWarp4 == null)
				{
					fDoubleWarp4 = new DoubleWarp4Perk(this);
				}
				return fDoubleWarp4;
			}
		}
		VPerk fDoubleWarp4;

		#endregion

		#region TripleWarp2

		public override VPerk TripleWarp2
		{
			get
			{
				if (fTripleWarp2 == null)
				{
					fTripleWarp2 = new TripleWarp2Perk(this);
				}
				return fTripleWarp2;
			}
		}
		VPerk fTripleWarp2;

		#endregion

		#region SuperJackpot2

		public override VPerk SuperJackpot2
		{
			get
			{
				if (fSuperJackpot2 == null)
				{
					fSuperJackpot2 = new SuperJackpot2Perk(this);
				}
				return fSuperJackpot2;
			}
		}
		VPerk fSuperJackpot2;

		#endregion

		#region StartingMinerals2

		public override VPerk StartingMinerals2
		{
			get
			{
				if (fStartingMinerals2 == null)
				{
					fStartingMinerals2 = new StartingMinerals2Perk(this);
				}
				return fStartingMinerals2;
			}
		}
		VPerk fStartingMinerals2;

		#endregion

		#region MasterTrainer2

		public override VPerk MasterTrainer2
		{
			get
			{
				if (fMasterTrainer2 == null)
				{
					fMasterTrainer2 = new MasterTrainer2Perk(this);
				}
				return fMasterTrainer2;
			}
		}
		VPerk fMasterTrainer2;

		#endregion

		#region ExtraSupply2

		public override VPerk ExtraSupply2
		{
			get
			{
				if (fExtraSupply2 == null)
				{
					fExtraSupply2 = new ExtraSupply2Perk(this);
				}
				return fExtraSupply2;
			}
		}
		VPerk fExtraSupply2;

		#endregion

		#region BlackCrits

		public override VPerk BlackCrits
		{
			get
			{
				if (fBlackCrits == null)
				{
					fBlackCrits = new BlackCritsPerk(this);
				}
				return fBlackCrits;
			}
		}
		VPerk fBlackCrits;

		#endregion

		#region BlackMarket

		public override VPerk BlackMarket
		{
			get
			{
				if (fBlackMarket == null)
				{
					fBlackMarket = new BlackMarketPerk(this);
				}
				return fBlackMarket;
			}
		}
		VPerk fBlackMarket;

		#endregion

		#region DominatorDamage

		public override VPerk DominatorDamage
		{
			get
			{
				if (fDominatorDamage == null)
				{
					fDominatorDamage = new DominatorDamagePerk(this);
				}
				return fDominatorDamage;
			}
		}
		VPerk fDominatorDamage;

		#endregion

		#region DominatorSpeed

		public override VPerk DominatorSpeed
		{
			get
			{
				if (fDominatorSpeed == null)
				{
					fDominatorSpeed = new DominatorSpeedPerk(this);
				}
				return fDominatorSpeed;
			}
		}
		VPerk fDominatorSpeed;

		#endregion

		#region Fearless

		public override VPerk Fearless
		{
			get
			{
				if (fFearless == null)
				{
					fFearless = new FearlessPerk(this);
				}
				return fFearless;
			}
		}
		VPerk fFearless;

		#endregion

		#region UpgradeCache

		public override VPerk UpgradeCache
		{
			get
			{
				if (fUpgradeCache == null)
				{
					fUpgradeCache = new UpgradeCachePerk(this);
				}
				return fUpgradeCache;
			}
		}
		VPerk fUpgradeCache;

		#endregion

		#region DestroyerVitals

		public override VPerk DestroyerVitals
		{
			get
			{
				if (fDestroyerVitals == null)
				{
					fDestroyerVitals = new DestroyerVitalsPerk(this);
				}
				return fDestroyerVitals;
			}
		}
		VPerk fDestroyerVitals;

		#endregion

		#region DestroyerArmor

		public override VPerk DestroyerArmor
		{
			get
			{
				if (fDestroyerArmor == null)
				{
					fDestroyerArmor = new DestroyerArmorPerk(this);
				}
				return fDestroyerArmor;
			}
		}
		VPerk fDestroyerArmor;

		#endregion

		#region LimitlessEssence

		public override VPerk LimitlessEssence
		{
			get
			{
				if (fLimitlessEssence == null)
				{
					fLimitlessEssence = new LimitlessEssencePerk(this);
				}
				return fLimitlessEssence;
			}
		}
		VPerk fLimitlessEssence;

		#endregion

		#region OverInfuse

		public override VPerk OverInfuse
		{
			get
			{
				if (fOverInfuse == null)
				{
					fOverInfuse = new OverInfusePerk(this);
				}
				return fOverInfuse;
			}
		}
		VPerk fOverInfuse;

		#endregion

		#region DestroyerWarp

		public override VPerk DestroyerWarp
		{
			get
			{
				if (fDestroyerWarp == null)
				{
					fDestroyerWarp = new DestroyerWarpPerk(this);
				}
				return fDestroyerWarp;
			}
		}
		VPerk fDestroyerWarp;

		#endregion

		#region DestroyerRankRevision

		public override VPerk DestroyerRankRevision
		{
			get
			{
				if (fDestroyerRankRevision == null)
				{
					fDestroyerRankRevision = new DestroyerRankRevisionPerk(this);
				}
				return fDestroyerRankRevision;
			}
		}
		VPerk fDestroyerRankRevision;

		#endregion

		#endregion

		#region AllPerks
		internal IEnumerable<VPerk> AllPerks => allPerks;
		protected IEnumerable<VPerk> allPerks;

		void PopulateAllPerks()
		{
			var type = GetType();
			var properties = type.GetProperties();
			var perkProperties = properties.Where(p => p.PropertyType.IsAssignableTo(typeof(VPerk)) && !p.Name.StartsWith("Perk"));

			var perks = new List<VPerk>();
			foreach(var propertyInfo in perkProperties)
			{
				perks.Add(propertyInfo.GetValue(this) as VPerk);
			}

			allPerks = perks
				.OrderBy(x => x.Page)
				.ThenBy(x => x.Position);
		}

		#endregion

		#region Pages For Binding

		public override int Page
		{
			get => base.Page;
			set
			{
				if (value > 0 && value <= MaxPage)
				{
					base.Page = value;
				}
			}
		}

		public override VPerk  Perk1 => allPerks.Where(p => p.Page == Page && p.Position == 1).FirstOrDefault();

		public override VPerk  Perk2 => allPerks.Where(p => p.Page == Page && p.Position == 2).FirstOrDefault();

		public override VPerk  Perk3 => allPerks.Where(p => p.Page == Page && p.Position == 3).FirstOrDefault();

		public override VPerk  Perk4 => allPerks.Where(p => p.Page == Page && p.Position == 4).FirstOrDefault();

		public override VPerk  Perk5 => allPerks.Where(p => p.Page == Page && p.Position == 5).FirstOrDefault();

		public override VPerk  Perk6 => allPerks.Where(p => p.Page == Page && p.Position == 6).FirstOrDefault();

		public VPerk[] OrderedPerksForDebug => allPerks.OrderBy(p => p.Page).ThenBy(p => p.Position).ToArray();

		#endregion

		#region Cost

		public override long RemainingCost => Loadout?.RemainingPerkPoints ?? 0;

		public override long TotalCost => allPerks.Sum(p => p.TotalCost);

		public override int PageCost => allPerks.Where(p => p.Page == Page).Sum(p => p.TotalCost);

		#endregion

		#region PageTitle

		public override string PageTitle => $"Page {Page}";

		#endregion

		#endregion
	}
}
