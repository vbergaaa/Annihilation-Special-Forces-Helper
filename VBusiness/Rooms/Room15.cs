using System;
using System.Collections.Generic;
using System.Text;
using VEntityFramework.Model;

namespace VBusiness.Rooms
{
	public class Room15 : Room
	{
		// Hard Room 3
		public override int RoomNumber => 15;

		public override int MineralPatches => 8;

		protected override IEnumerable<(EnemyType, int)> GetBuildings()
		{
			return new List<(EnemyType, int)>()
			{
				(EnemyType.RoachWarren, 3),
				(EnemyType.SporeCrawler, 9),
				(EnemyType.Spire, 1),
				(EnemyType.Lair, 1),
			};
		}

		protected override IEnumerable<(EnemyType, int)> GetEnemies()
		{
			return new List<(EnemyType, int)>()
			{
				(EnemyType.Roach, 18),
				(EnemyType.GiantAbberation, 4),
			};
		}
	}
}
