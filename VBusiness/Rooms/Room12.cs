using System.Collections.Generic;
using VBusiness.HelperClasses;
using VEntityFramework.Model;

namespace VBusiness.Rooms
{
	public class Room12 : Room
	{
		// Normal Room 3
		public override RoomNumber RoomNumber => RoomNumber.Room12;

		public override int MineralPatches => 8;

		protected override IEnumerable<EnemyQuantity> GetBuildings()
		{
			return new List<EnemyQuantity>()
			{
				new EnemyQuantity(EnemyType.Lair, 1),
				new EnemyQuantity(EnemyType.RoachWarren, 3),
				new EnemyQuantity(EnemyType.SporeCrawler, 23), // maybe 22?
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
