using System;
using System.Collections.Generic;
using System.Text;
using VEntityFramework.Model;

namespace VBusiness.Rooms
{
	public class Room14 : Room
	{
		// Hard Room 2
		public override int RoomNumber => 14;

		public override int MineralPatches => 0;
		
		protected override IEnumerable<(EnemyType, int)> GetBuildings()
		{
			return new List<(EnemyType, int)>()
			{
				(EnemyType.RoachWarren, 3),
				(EnemyType.SporeCrawler, 6),
				(EnemyType.Spire, 1),
			};
		}

		protected override IEnumerable<(EnemyType, int)> GetEnemies()
		{
			return new List<(EnemyType, int)>()
			{
				(EnemyType.Roach, 18),
			};
		}
	}
}
