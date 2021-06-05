using System.Collections.Generic;
using VBusiness.HelperClasses;
using VEntityFramework.Model;

namespace VBusiness.Rooms
{
	public class Room15 : Room
	{
		// Hard Room 3
		public override RoomNumber RoomNumber => RoomNumber.Room15;

		public override int MineralPatches => 8;

		protected override IEnumerable<EnemyQuantity> GetBuildings()
		{
			return new List<EnemyQuantity>()
			{
				new EnemyQuantity(EnemyType.RoachWarren, 3),
				new EnemyQuantity(EnemyType.SporeCrawler, 9),
				new EnemyQuantity(EnemyType.Spire, 1),
				new EnemyQuantity(EnemyType.Lair, 1),
			};
		}

		protected override IEnumerable<EnemyQuantity> GetEnemies()
		{
			return new List<EnemyQuantity>()
			{
				new EnemyQuantity(EnemyType.Roach, 18),
				new EnemyQuantity(EnemyType.GiantAbberation, 4),
			};
		}
	}
}
