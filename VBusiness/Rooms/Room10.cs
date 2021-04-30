using System;
using System.Collections.Generic;
using System.Text;
using VEntityFramework.Model;

namespace VBusiness.Rooms
{
	public class Room10 : Room
	{
		// Normal Room 1
		public override int RoomNumber => 10;

		public override int MineralPatches => 0;

		protected override IEnumerable<(EnemyType, int)> GetBuildings()
		{
			return new List<(EnemyType, int)>()
			{
				(EnemyType.SpawningPool, 2),
				(EnemyType.RoachWarren, 1),
				(EnemyType.SporeCrawler, 8),
			};
		}

		protected override IEnumerable<(EnemyType, int)> GetEnemies()
		{
			return new List<(EnemyType, int)>()
			{
				(EnemyType.Zergling, 24),
				(EnemyType.Roach, 6),
			};
		}
	}
}
