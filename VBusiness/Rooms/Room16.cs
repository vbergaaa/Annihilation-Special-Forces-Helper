using System;
using System.Collections.Generic;
using System.Text;
using VEntityFramework.Model;

namespace VBusiness.Rooms
{
	public class Room16 : Room
	{
		// Hard Room 4
		public override int RoomNumber => 16;

		public override int MineralPatches => 0;

		protected override IEnumerable<(EnemyType, int)> GetBuildings()
		{
			return new List<(EnemyType, int)>()
			{
				(EnemyType.SporeCrawler, 10),
				(EnemyType.Spire, 2),
				(EnemyType.Lair, 2),
			};
		}

		protected override IEnumerable<(EnemyType, int)> GetEnemies()
		{
			return new List<(EnemyType, int)>()
			{
				(EnemyType.Roach, 18),
				(EnemyType.GiantAbberation, 8),
			};
		}

		public override EnemyType GetBoss => EnemyType.LieutenantRailgul;
	}
}
