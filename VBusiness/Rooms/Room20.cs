using System;
using System.Collections.Generic;
using System.Text;
using VEntityFramework.Model;

namespace VBusiness.Rooms
{
	public class Room20 : Room
	{
		// nightmare room 1
		public override int RoomNumber => 20;

		public override int MineralPatches => 0;

		protected override IEnumerable<(EnemyType, int)> GetBuildings()
		{
			return new List<(EnemyType, int)>()
			{
				(EnemyType.Spire, 2),
				(EnemyType.Lair, 1),
				(EnemyType.HydraliskDen, 3),
				(EnemyType.SporeCannon, 11)
			};
		}

		protected override IEnumerable<(EnemyType, int)> GetEnemies()
		{
			return new List<(EnemyType, int)>()
			{
				(EnemyType.Hydralisk, 15),
				(EnemyType.GiantAbberation, 4),
			};
		}
	}
}
