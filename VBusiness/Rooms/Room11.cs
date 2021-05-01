using System.Collections.Generic;
using VBusiness.HelperClasses;
using VEntityFramework.Model;

namespace VBusiness.Rooms
{
	public class Room11 : Room
	{
		// Normal Room 2
		public override int RoomNumber => 11;

		public override int MineralPatches => 0;

		protected override IEnumerable<EnemyQuantity> GetBuildings()
		{
			return new List<EnemyQuantity>()
			{
				new EnemyQuantity(EnemyType.SpawningPool, 1),
				new EnemyQuantity(EnemyType.RoachWarren, 2),
				new EnemyQuantity(EnemyType.SporeCrawler, 8),
			};
		}

		protected override IEnumerable<EnemyQuantity> GetEnemies()
		{
			return new List<EnemyQuantity>()
			{
				new EnemyQuantity(EnemyType.Zergling, 12),
				new EnemyQuantity(EnemyType.Roach, 12),
			};
		}
	}
}
