using System;
using System.Collections.Generic;
using System.Text;
using VEntityFramework.Model;

namespace VBusiness.Rooms
{
	public class Room11 : Room
	{
		// Normal Room 2
		public override int RoomNumber => 11;

		public override int MineralPatches => 0;

		protected override IEnumerable<(EnemyType, int)> GetBuildings()
		{
			return new List<(EnemyType, int)>()
			{
				(EnemyType.SpawningPool, 1),
				(EnemyType.RoachWarren, 2),
				(EnemyType.SporeCrawler, 8),
			};
		}

		protected override IEnumerable<(EnemyType, int)> GetEnemies()
		{
			return new List<(EnemyType, int)>()
			{
				(EnemyType.Zergling, 12),
				(EnemyType.Roach, 12),
			};
		}
	}
}
