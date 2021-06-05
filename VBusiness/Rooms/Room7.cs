using System.Collections.Generic;
using VBusiness.HelperClasses;
using VEntityFramework.Model;

namespace VBusiness.Rooms
{
	public class Room7 : Room
	{
		public override RoomNumber RoomNumber => RoomNumber.Room7;

		public override int MineralPatches => 0;

		protected override IEnumerable<EnemyQuantity> GetBuildings()
		{
			return new List<EnemyQuantity>()
			{
				new EnemyQuantity(EnemyType.SpineCrawler, 9),
				new EnemyQuantity(EnemyType.SpawningPool, 2),
				new EnemyQuantity(EnemyType.SporeCrawler, 3),
			};
		}

		protected override IEnumerable<EnemyQuantity> GetEnemies()
		{
			return new List<EnemyQuantity>()
			{
				new EnemyQuantity(EnemyType.Zergling, 40),
			};
		}
	}
}
