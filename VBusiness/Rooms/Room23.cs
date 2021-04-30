using System;
using System.Collections.Generic;
using System.Text;
using VEntityFramework.Model;

namespace VBusiness.Rooms
{
	public class Room23 : Room
	{
		// Torment Room 1
		public override int RoomNumber => 23;

		public override int MineralPatches => 0;

		protected override IEnumerable<(EnemyType, int)> GetBuildings()
		{
			return new List<(EnemyType, int)>()
			{
				(EnemyType.Spire, 2),
				(EnemyType.Lair, 2),
				(EnemyType.HydraliskDen, 3),
				(EnemyType.SporeCannon, 7)
			};
		}

		protected override IEnumerable<(EnemyType, int)> GetEnemies()
		{
			return new List<(EnemyType, int)>()
			{
				(EnemyType.Hydralisk, 15),
				(EnemyType.GiantAbberation, 8),
			};
		}

		public override EnemyType GetBoss => EnemyType.CaptainGamala;
	}
}
