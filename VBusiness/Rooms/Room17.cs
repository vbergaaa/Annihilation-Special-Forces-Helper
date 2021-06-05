using System.Collections.Generic;
using VBusiness.HelperClasses;
using VEntityFramework.Model;

namespace VBusiness.Rooms
{
	public class Room17 : Room
	{
		// Insane Room 1
		public override RoomNumber RoomNumber => RoomNumber.Room17;

		public override int MineralPatches => 0;

		protected override IEnumerable<EnemyQuantity> GetBuildings()
		{
			return new List<EnemyQuantity>()
			{
				new EnemyQuantity(EnemyType.HydraliskDen, 2),
				new EnemyQuantity(EnemyType.SporeCannon, 7)
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
