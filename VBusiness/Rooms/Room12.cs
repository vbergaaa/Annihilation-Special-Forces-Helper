using System;
using System.Collections.Generic;
using System.Text;
using VEntityFramework.Model;

namespace VBusiness.Rooms
{
	public class Room12 : Room
	{
		// Normal Room 3
		public override int RoomNumber => 12;

		public override int MineralPatches => 8;

		protected override IEnumerable<(EnemyType, int)> GetBuildings()
		{
			return new List<(EnemyType, int)>()
			{
				(EnemyType.Hatchery, 1),
				(EnemyType.RoachWarren, 3),
				(EnemyType.SporeCrawler, 23), // maybe 22?
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
