using System;
using System.Collections.Generic;
using VEntityFramework.Model;

namespace VBusiness.Rooms
{
	public class Room3 : Room
	{
		public override int RoomNumber => 3;

		public override int MineralPatches => 3;

		protected override IEnumerable<(EnemyType, int)> GetBuildings()
		{
			return new List<(EnemyType, int)>()
			{
				(EnemyType.SpineCrawler, 10),
				(EnemyType.EvoChamber, 6),
			};
		}

		protected override IEnumerable<(EnemyType, int)> GetEnemies()
		{
			return new List<(EnemyType, int)>()
			{
				(EnemyType.InfestedTerran, 48),
			};
		}
	}
}
