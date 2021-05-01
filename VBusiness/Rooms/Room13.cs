using System.Collections.Generic;
using VBusiness.HelperClasses;
using VEntityFramework.Model;

namespace VBusiness.Rooms
{
	public class Room13 : Room
	{
		// Hard Room 1
		public override int RoomNumber => 13;

		public override int MineralPatches => 9;

		protected override IEnumerable<EnemyQuantity> GetBuildings()
		{
			return new List<EnemyQuantity>()
			{
				new EnemyQuantity(EnemyType.RoachWarren, 2),
				new EnemyQuantity(EnemyType.SporeCrawler, 10),
				new EnemyQuantity(EnemyType.Spire, 1),
			};
		}

		protected override IEnumerable<EnemyQuantity> GetEnemies()
		{
			return new List<EnemyQuantity>()
			{
				new EnemyQuantity(EnemyType.Roach, 12),
			};
		}
	}
}
