using System;
using System.Collections.Generic;
using System.Text;
using VEntityFramework.Model;

namespace VBusiness.Rooms
{
	public class Room19 : Room
	{
		// Insane room 3
		public override int RoomNumber => 19;

		public override int MineralPatches => 0;

		protected override IEnumerable<(EnemyType, int)> GetBuildings()
		{
			return new List<(EnemyType, int)>()
			{
				(EnemyType.Spire, 3),
				(EnemyType.Lair, 2),
				(EnemyType.HydraliskDen, 3),
				(EnemyType.SporeCannon, 10)
			};
		}

		protected override IEnumerable<(EnemyType, int)> GetEnemies()
		{
			return new List<(EnemyType, int)>()
			{
				(EnemyType.GiantAbberation, 8),
				(EnemyType.Hydralisk, 15),
			};
		}
	}
}
