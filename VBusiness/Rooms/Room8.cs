using System;
using System.Collections.Generic;
using System.Text;
using VEntityFramework.Model;

namespace VBusiness.Rooms
{
	public class Room8 : Room
	{
		public override int RoomNumber => 8;

		public override int MineralPatches => 5;

		protected override IEnumerable<(EnemyType, int)> GetBuildings()
		{
			return new List<(EnemyType, int)>()
			{
				(EnemyType.SpawningPool, 3),
				(EnemyType.SporeCrawler, 5),
			};
		}

		protected override IEnumerable<(EnemyType, int)> GetEnemies()
		{
			return new List<(EnemyType, int)>()
			{
				(EnemyType.Zergling, 60),
			};
		}
	}
}
