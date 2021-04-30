using System;
using System.Collections.Generic;
using System.Text;
using VEntityFramework.Model;

namespace VBusiness.Rooms
{
	public class Room31 : Room
	{
		// Impossible Room 1
		public override int RoomNumber => 31;

		public override int MineralPatches => 0;

		protected override IEnumerable<(EnemyType, int)> GetBuildings()
		{
			return new List<(EnemyType, int)>()
			{
				(EnemyType.Spire, 1),
				(EnemyType.Hive, 3),
				(EnemyType.PygaliskCavern, 1),
			};
		}

		protected override IEnumerable<(EnemyType, int)> GetEnemies()
		{
			return new List<(EnemyType, int)>()
			{
				(EnemyType.Pygalisk, 8),
				(EnemyType.Infestor, 12),
			};
		}
	}
}
