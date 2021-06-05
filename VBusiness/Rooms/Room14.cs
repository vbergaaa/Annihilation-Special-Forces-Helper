using System.Collections.Generic;
using VBusiness.HelperClasses;
using VEntityFramework.Model;

namespace VBusiness.Rooms
{
	public class Room14 : Room
	{
		// Hard Room 2
		public override RoomNumber RoomNumber => RoomNumber.Room14;

		public override int MineralPatches => 0;
		
		protected override IEnumerable<EnemyQuantity> GetBuildings()
		{
			return new List<EnemyQuantity>()
			{
				new EnemyQuantity(EnemyType.RoachWarren, 3),
				new EnemyQuantity(EnemyType.SporeCrawler, 6),
				new EnemyQuantity(EnemyType.Spire, 1),
			};
		}

		protected override IEnumerable<EnemyQuantity> GetEnemies()
		{
			return new List<EnemyQuantity>()
			{
				new EnemyQuantity(EnemyType.Roach, 18),
			};
		}
	}
}
