using System;
using System.Collections.Generic;
using System.Text;
using VEntityFramework.Model;

namespace VBusiness.Rooms
{
	public class Room4 : Room
	{
		public override int RoomNumber => 4;

		public override int MineralPatches => 6;

		protected override IEnumerable<(EnemyType, int)> GetBuildings()
		{
			return new List<(EnemyType, int)>()
			{
				(EnemyType.SpineCrawler, 15),
				(EnemyType.EvolutionChamber, 4),
				(EnemyType.Hatchery, 4),
			};
		}

		protected override IEnumerable<(EnemyType, int)> GetEnemies()
		{
			return new List<(EnemyType, int)>()
			{
				(EnemyType.InfestedTerran, 40),
				(EnemyType.Abberation, 3),
			};
		}
	}
}
