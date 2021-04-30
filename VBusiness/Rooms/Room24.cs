using System;
using System.Collections.Generic;
using System.Text;
using VEntityFramework.Model;

namespace VBusiness.Rooms
{
	public class Room24 : Room
	{
		// Titanic room 1
		public override int RoomNumber => 24;

		public override int MineralPatches => 0;

		protected override IEnumerable<(EnemyType, int)> GetBuildings()
		{
			return new List<(EnemyType, int)>()
			{
				(EnemyType.Spire, 2),
				(EnemyType.HydraliskDen, 2),
				(EnemyType.SporeCannon, 17),
				(EnemyType.Hive, 1),
			};
		}

		protected override IEnumerable<(EnemyType, int)> GetEnemies()
		{
			return new List<(EnemyType, int)>()
			{
				(EnemyType.Hydralisk, 10),
				(EnemyType.Infestor, 4),
			};
		}
	}
}
