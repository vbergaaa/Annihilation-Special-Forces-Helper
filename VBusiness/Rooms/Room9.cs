using System;
using System.Collections.Generic;
using System.Text;
using VEntityFramework.Model;

namespace VBusiness.Rooms
{
	public class Room9 : Room
	{
		public override int RoomNumber => 9;

		public override int MineralPatches => 6;

		protected override IEnumerable<(EnemyType, int)> GetBuildings()
		{
			return new List<(EnemyType, int)>()
			{
				(EnemyType.SpineCrawler, 19),
				(EnemyType.SpawningPool, 4),
				(EnemyType.Hatchery, 1),
				(EnemyType.SporeCrawler, 3),
			};
		}

		protected override IEnumerable<(EnemyType, int)> GetEnemies()
		{
			return new List<(EnemyType, int)>()
			{
				(EnemyType.Abberation, 8),
				(EnemyType.Zergling, 48),
			};
		}
	}
}
