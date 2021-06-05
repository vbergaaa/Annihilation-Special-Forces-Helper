
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

		public double GetKillsPerWave()
		{
			return GetIncomePerWave().Kills;
		}

		public double GetMineralsPerWave()
		{
			return GetIncomePerWave().Minerals;
		}

		Resources GetIncomePerWave()
		{
			var units = Room.New(loadout.IncomeManager.FarmRoom).EnemiesPerWave.TierUp(loadout.UnitConfiguration.Difficulty.UnitTierIncrease).ToList();
			units.AddRange(units.SelectRecursive(e => e.Type.GetAdditionalSpawns(loadout.UnitConfiguration.Difficulty.UnitTierIncrease, loadout.IncomeManager.FarmRoom).Multiply(e.Quantity)));

			var totalKills = 0.0;
			var totalMinerals = 0.0;

			foreach (var unit in units)
			{
				var enemy = EnemyUnit.New(unit.Type);
				totalKills += enemy.KillBounty * unit.Quantity;
				totalMinerals += enemy.MineralBounty * unit.Quantity;
			}

			return new Resources(totalMinerals, totalKills);
		}

		struct Resources
		{
			public Resources(double mins, double kills)
			{
				Kills = kills;
				Minerals = mins;
			}
			public double Kills { get; set; }
			public double Minerals { get; set; }
		}
	}
}
