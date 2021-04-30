using System;
using System.Collections.Generic;
using System.Text;
using VEntityFramework.Model;

namespace VBusiness.Rooms
{
	public class Room13 : Room
	{
		// Hard Room 1
		public override int RoomNumber => 13;

		public override int MineralPatches => 9;

		protected override IEnumerable<(EnemyType, int)> GetBuildings()
		{
			return new List<(EnemyType, int)>()
			{
				(EnemyType.RoachWarren, 2),
				(EnemyType.SporeCrawler, 10),
				(EnemyType.Spire, 1),
			};
		}

		protected override IEnumerable<(EnemyType, int)> GetEnemies()
		{
			return new List<(EnemyType, int)>()
			{
				(EnemyType.Roach, 12),
			};
		}
	}
}
