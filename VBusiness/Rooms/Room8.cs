using System.Collections.Generic;
using VBusiness.HelperClasses;
using VEntityFramework.Model;

namespace VBusiness.Rooms
{
	public class Room8 : Room
	{
		public override int RoomNumber => 8;

		public override int MineralPatches => 5;

		protected override IEnumerable<EnemyQuantity> GetBuildings()
		{
			return new List<EnemyQuantity>()
			{
				new EnemyQuantity(EnemyType.SpawningPool, 3),
				new EnemyQuantity(EnemyType.SporeCrawler, 5),
			};
		}

		protected override IEnumerable<EnemyQuantity> GetEnemies()
		{
			return new List<EnemyQuantity>()
			{
				new EnemyQuantity(EnemyType.Zergling, 60),
			};
		}
	}
}
