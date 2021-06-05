using System.Collections.Generic;
using VBusiness.HelperClasses;
using VEntityFramework.Model;

namespace VBusiness.Rooms
{
	public class Room18 : Room
	{
		// Insane Room 2
		public override RoomNumber RoomNumber => RoomNumber.Room18;

		public override int MineralPatches => 0;

		protected override IEnumerable<EnemyQuantity> GetBuildings()
		{
			return new List<EnemyQuantity>()
			{
				new EnemyQuantity(EnemyType.Spire, 2),
				new EnemyQuantity(EnemyType.HydraliskDen, 2),
				new EnemyQuantity(EnemyType.SporeCannon, 8)
			};
		}

		protected override IEnumerable<EnemyQuantity> GetEnemies()
		{
			return new List<EnemyQuantity>()
			{
				new EnemyQuantity(EnemyType.Hydralisk, 10),
			};
		}
	}
}
