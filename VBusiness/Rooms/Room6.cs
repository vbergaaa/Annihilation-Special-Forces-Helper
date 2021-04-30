using System;
using System.Collections.Generic;
using System.Text;
using VEntityFramework.Model;

namespace VBusiness.Rooms
{
	class Room6 : Room
	{
		public override int RoomNumber => 6;

		public override int MineralPatches => 0;

		protected override IEnumerable<(EnemyType, int)> GetBuildings()
		{
			return new List<(EnemyType, int)>()
			{
				(EnemyType.SpineCrawler, 13),
				(EnemyType.SpawningPool, 4),
				(EnemyType.Hatchery, 1),
				(EnemyType.SporeCrawler, 1),
			};
		}

		protected override IEnumerable<(EnemyType, int)> GetEnemies()
		{
			return new List<(EnemyType, int)>()
			{
				(EnemyType.Abberation, 6),
				(EnemyType.Zergling, 36),
			};
		}

		public override EnemyType GetBoss => EnemyType.SergeantRamone;
	}
}
