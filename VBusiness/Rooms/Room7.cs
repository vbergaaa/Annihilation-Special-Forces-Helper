using System;
using System.Collections.Generic;
using System.Text;
using VEntityFramework.Model;

namespace VBusiness.Rooms
{
	public class Room7 : Room
	{
		public override int RoomNumber => 7;

		public override int MineralPatches => 0;

		protected override IEnumerable<(EnemyType, int)> GetBuildings()
		{
			return new List<(EnemyType, int)>()
			{
				(EnemyType.SpineCrawler, 9),
				(EnemyType.SpawningPool, 2),
				(EnemyType.SporeCrawler, 3),
			};
		}

		protected override IEnumerable<(EnemyType, int)> GetEnemies()
		{
			return new List<(EnemyType, int)>()
			{
				(EnemyType.Zergling, 40),
			};
		}
	}
}
