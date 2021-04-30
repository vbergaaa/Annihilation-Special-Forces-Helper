using System;
using System.Collections.Generic;
using System.Text;
using VEntityFramework.Model;

namespace VBusiness.Rooms
{
	public class Room27 : Room
	{
		// Mythic Room 2
		public override int RoomNumber => 27;

		public override int MineralPatches => 0;

		protected override IEnumerable<(EnemyType, int)> GetBuildings()
		{
			return new List<(EnemyType, int)>()
			{
				(EnemyType.Spire, 3),
				(EnemyType.SporeCannon, 9),
				(EnemyType.Hive, 4),
			};
		}

		protected override IEnumerable<(EnemyType, int)> GetEnemies()
		{
			return new List<(EnemyType, int)>()
			{
				(EnemyType.Infestor, 16),
			};
		}
	}
}
