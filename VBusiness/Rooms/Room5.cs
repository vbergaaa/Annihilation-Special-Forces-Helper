using System.Collections.Generic;
using VBusiness.HelperClasses;
using VEntityFramework.Model;

namespace VBusiness.Rooms
{
	class Room5 : Room
	{
		public override RoomNumber RoomNumber => RoomNumber.Room5;

		public override int MineralPatches => 0;

		protected override IEnumerable<EnemyQuantity> GetBuildings()
		{
			return new List<EnemyQuantity>()
			{
				new EnemyQuantity(EnemyType.SpineCrawler, 19),
				new EnemyQuantity(EnemyType.Hatchery, 2),
			};
		}

		protected override IEnumerable<EnemyQuantity> GetEnemies()
		{
			return new List<EnemyQuantity>()
			{
				new EnemyQuantity(EnemyType.Abberation, 10),
			};
		}
	}
}
