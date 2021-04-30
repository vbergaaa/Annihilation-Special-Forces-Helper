using System;
using System.Collections.Generic;
using System.Text;
using VEntityFramework.Model;

namespace VBusiness.Rooms
{
	public class Room22 : Room
	{
		// Nightmare Room 1
		public override int RoomNumber => 22;

		public override int MineralPatches => 0;

		protected override IEnumerable<(EnemyType, int)> GetBuildings()
		{
			return new List<(EnemyType, int)>()
			{
				(EnemyType.Spire, 2),
				(EnemyType.Lair, 1),
				(EnemyType.HydraliskDen, 4),
				(EnemyType.SporeCannon, 8)
			};
		}

		protected override IEnumerable<(EnemyType, int)> GetEnemies()
		{
			return new List<(EnemyType, int)>()
			{
				(EnemyType.Hydralisk, 20),
				(EnemyType.GiantAbberation, 4),
			};
		}
	}
}
