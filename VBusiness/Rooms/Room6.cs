using System.Collections.Generic;
using VBusiness.HelperClasses;
using VEntityFramework.Model;

namespace VBusiness.Rooms
{
	class Room6 : Room
	{
		public override RoomNumber RoomNumber => RoomNumber.Room6;

		public override int MineralPatches => 0;

		protected override IEnumerable<EnemyQuantity> GetBuildings()
		{
			return new List<EnemyQuantity>()
			{
				new EnemyQuantity(EnemyType.SpineCrawler, 13),
				new EnemyQuantity(EnemyType.SpawningPool, 3),
				new EnemyQuantity(EnemyType.Hatchery, 1),
				new EnemyQuantity(EnemyType.SporeCrawler, 1),
			};
		}

		protected override IEnumerable<EnemyQuantity> GetEnemies()
		{
			return new List<EnemyQuantity>()
			{
				new EnemyQuantity(EnemyType.Abberation, 6),
				new EnemyQuantity(EnemyType.Zergling, 36),
			};
		}

		public override EnemyType GetBoss => EnemyType.SergeantRamone;
	}
}
