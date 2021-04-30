using System;
using System.Collections.Generic;
using System.Text;
using VEntityFramework.Model;

namespace VBusiness.Rooms
{
	public class Room29 : Room
	{
		// Divine Room 2
		
		public override int RoomNumber => 29;

		public override int MineralPatches => 0;

		protected override IEnumerable<(EnemyType, int)> GetBuildings()
		{
			return new List<(EnemyType, int)>()
			{
				(EnemyType.Spire, 2),
				(EnemyType.SporeCannon, 8),
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
