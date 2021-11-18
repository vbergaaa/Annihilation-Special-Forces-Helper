
using System;
using System.Collections.Generic;
using System.Linq;
using VBusiness.Enemies;
using VEntityFramework.Model;

namespace VBusiness.HelperClasses
{
	public class IncomeCalculator
	{
		private readonly VLoadout loadout;

		public IncomeCalculator(VLoadout loadout)
		{
			this.loadout = loadout;
		}

		public double GetKillsPerMinute()
		{
			return GetIncomePerMinute().Kills;
		}

		public double GetMineralsPerMinute()
		{
			return GetIncomePerMinute().Minerals;
		}

		Resources GetIncomePerMinute()
		{
			GetLoadoutValues();
			var tierUp = loadout.UnitConfiguration.Difficulty.UnitTierIncrease + loadout.Mods.Tier.CurrentLevel / 10.0;

			var units = Room.New(loadout.IncomeManager.FarmRoom).EnemiesPerWave.TierUp(tierUp).ToList();

			if (loadout.IncomeManager.AdditionalFarmRoom != Rooms.RoomNumber.None)
			{
				units.AddRange(Room.New(loadout.IncomeManager.AdditionalFarmRoom).EnemiesPerWave.TierUp(tierUp).ToList());
			}

			units.AddRange(units.SelectRecursive(e => e.Type.GetAdditionalSpawns(loadout.UnitConfiguration.Difficulty.UnitTierIncrease, loadout.IncomeManager.FarmRoom).Multiply(e.Quantity)));

			IEnumerable<EnemyQuantity> infSpawnerUnits = loadout.IncomeManager.HasInfinitySpawner
				? new[] { new EnemyQuantity(EnemyType.InfestedTerran, 20) }.TierUp(tierUp)
				: Array.Empty<EnemyQuantity>();

			var totalKills = 0.0;
			var totalMinerals = 0.0;
			var spawnsPerMinute = 60.0 / 17.0; // 17 seconds looks like the standard wave period

			foreach (var unit in units)
			{
				var enemy = EnemyUnit.New(unit.Type);
				totalKills += (enemy.KillBounty + killsPerKill) * unit.Quantity * spawnsPerMinute;
				totalMinerals += (enemy.MineralBounty + mineralsPerKill) * unit.Quantity * spawnsPerMinute;
			}

			spawnsPerMinute = 60.0 / 15.0; // 15 secounds looks like the inf spawner wave period

			foreach (var unit in infSpawnerUnits)
			{
				var enemy = EnemyUnit.New(unit.Type);
				totalKills += (enemy.KillBounty + killsPerKill) * unit.Quantity * spawnsPerMinute;
				totalMinerals += (enemy.MineralBounty + mineralsPerKill) * unit.Quantity * spawnsPerMinute;
			}


			spawnsPerMinute = 60.0 / 9.0; // 9 secounds looks like the first bruta wave period

			foreach (var unit in GetBrutaWaves())
			{
				var enemy = EnemyUnit.New(unit.Type);
				totalKills += (enemy.KillBounty + killsPerKill) * unit.Quantity * spawnsPerMinute;
				totalMinerals += (enemy.MineralBounty + mineralsPerKill) * unit.Quantity * spawnsPerMinute;
			}

			if (loadout.IncomeManager.HasUrusy)
			{
				totalMinerals += 600;
			}

			return new Resources(totalMinerals, totalKills);
		}

		IEnumerable<EnemyQuantity> GetBrutaWaves()
		{
			if (loadout.UnitConfiguration.DifficultyLevel >= DifficultyLevel.Brutal)
			{
				if (loadout.IncomeManager.BrutaliskOverride.Bruta1
					&& loadout.IncomeManager.FarmRoom >= EnemyUnit.Bruta1Room)
				{
					yield return EnemyUnit.New(EnemyType.Bruta1).BrutaSpawns;
				}
				if (loadout.IncomeManager.BrutaliskOverride.Bruta2
					&& loadout.IncomeManager.FarmRoom >= EnemyUnit.Bruta2Room)
				{
					yield return EnemyUnit.New(EnemyType.Bruta2).BrutaSpawns;
				}
				if (loadout.IncomeManager.BrutaliskOverride.Bruta3
					&& loadout.IncomeManager.FarmRoom >= EnemyUnit.Bruta3Room)
				{
					yield return EnemyUnit.New(EnemyType.Bruta3).BrutaSpawns;
				}
				if (loadout.IncomeManager.BrutaliskOverride.Bruta4
					&& loadout.IncomeManager.FarmRoom >= EnemyUnit.Bruta4Room)
				{
					yield return EnemyUnit.New(EnemyType.Bruta4).BrutaSpawns;
				}
				if (loadout.IncomeManager.BrutaliskOverride.Bruta5
					&& loadout.IncomeManager.FarmRoom >= EnemyUnit.Bruta5Room)
				{
					yield return EnemyUnit.New(EnemyType.Bruta5).BrutaSpawns;
				}
				if (loadout.IncomeManager.BrutaliskOverride.Bruta6
					&& loadout.IncomeManager.FarmRoom >= EnemyUnit.Bruta6Room)
				{
					yield return EnemyUnit.New(EnemyType.Bruta6).BrutaSpawns;
				}
			}
		}

		void GetLoadoutValues()
		{
			var jackpotChance = loadout.IncomeManager.MineralJackpot / 500.0;
			var sjpPoints = loadout.IncomeManager.SuperJackpot;
			var mineralJackpotAmount = 100 + 10 * sjpPoints;
			var killJackpotAmount = sjpPoints;

			mineralsPerKill = mineralJackpotAmount * jackpotChance;
			killsPerKill = killJackpotAmount * jackpotChance + loadout.IncomeManager.MaximumGather / 100;

			if (loadout.IncomeManager.HasGreed)
			{
				killsPerKill += 0.2;
			}
		}

		double mineralsPerKill;
		double killsPerKill;

		struct Resources
		{
			public Resources(double mins, double kills)
			{
				Kills = kills;
				Minerals = mins;
			}
			public double Kills { get; set; }
			public double Minerals { get; set; }

			public static Resources operator +(Resources a, Resources b) => new(a.Minerals + b.Minerals, a.Kills + b.Kills);
		}
	}
}
