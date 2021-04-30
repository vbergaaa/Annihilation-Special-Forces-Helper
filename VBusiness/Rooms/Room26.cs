using System;
using System.Collections.Generic;
using System.Text;
using VEntityFramework.Model;

namespace VBusiness.Rooms
{
	public class Room26 : Room
	{
		// Mythic Room 1
		public override int RoomNumber => 26;

		public override int MineralPatches => 0;

		protected override IEnumerable<(EnemyType, int)> GetBuildings()
		{
			return new List<(EnemyType, int)>()
			{
				(EnemyType.Spire, 3),
				(EnemyType.HydraliskDen, 2),
				(EnemyType.SporeCannon, 15),
				(EnemyType.Hive, 2),
			};
		}

		protected override IEnumerable<(EnemyType, int)> GetEnemies()
		{
			return new List<(EnemyType, int)>()
			{
				(EnemyType.Hydralisk, 10),
				(EnemyType.Infestor, 8),
			};
		}
	}
}
