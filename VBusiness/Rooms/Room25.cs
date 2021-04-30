using System;
using System.Collections.Generic;
using System.Text;
using VEntityFramework.Model;

namespace VBusiness.Rooms
{
	public class Room25 : Room
	{
		// Titanic Room 2
		public override int RoomNumber => 25;

		public override int MineralPatches => 0;

		protected override IEnumerable<(EnemyType, int)> GetBuildings()
		{
			return new List<(EnemyType, int)>()
			{
				(EnemyType.Spire, 2),
				(EnemyType.HydraliskDen, 3),
				(EnemyType.SporeCannon, 8),
				(EnemyType.Hive, 1),
			};
		}

		protected override IEnumerable<(EnemyType, int)> GetEnemies()
		{
			return new List<(EnemyType, int)>()
			{
				(EnemyType.Hydralisk, 15),
				(EnemyType.Infestor, 4),
			};
		}
	}
}
