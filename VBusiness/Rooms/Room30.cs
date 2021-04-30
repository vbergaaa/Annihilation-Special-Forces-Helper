using System;
using System.Collections.Generic;
using System.Text;
using VEntityFramework.Model;

namespace VBusiness.Rooms
{
	// Divine Room 3
	public class Room30 : Room
	{
		public override int RoomNumber => 30;

		public override int MineralPatches => 0;

		protected override IEnumerable<(EnemyType, int)> GetBuildings()
		{
			return new List<(EnemyType, int)>()
			{
				(EnemyType.Spire, 2),
				(EnemyType.SporeCannon, 6),
				(EnemyType.Hive, 2),
				(EnemyType.PygaliskCavern, 2),
			};
		}

		protected override IEnumerable<(EnemyType, int)> GetEnemies()
		{
			return new List<(EnemyType, int)>()
			{
				(EnemyType.Pygalisk, 16),
				(EnemyType.Infestor, 8),
			};
		}
	}
}
