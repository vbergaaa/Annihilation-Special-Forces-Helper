using System.Collections.Generic;
using VBusiness.HelperClasses;
using VEntityFramework.Model;

namespace VBusiness.Rooms
{
	public class Room9 : Room
	{
		public override RoomNumber RoomNumber => RoomNumber.Room9;

		public override int MineralPatches => 6;

		protected override IEnumerable<EnemyQuantity> GetBuildings()
		{
			var test = new List<EnemyQuantity>()
			{
				new EnemyQuantity(EnemyType.SpineCrawler, 19),
				new EnemyQuantity(EnemyType.SpawningPool, 4),
				new EnemyQuantity(EnemyType.Hatchery, 1),
				new EnemyQuantity(EnemyType.SporeCrawler, 3),
			};
			return test;
		}

		protected override IEnumerable<EnemyQuantity> GetEnemies()
		{
			return new List<EnemyQuantity>()
			{
				new EnemyQuantity(EnemyType.Abberation, 8),
				new EnemyQuantity(EnemyType.Zergling, 48),
			};
		}

		public override EnemyType Bruta => EnemyType.Bruta1;
	}
}
