using System.Collections.Generic;
using VBusiness.HelperClasses;
using VEntityFramework.Model;

namespace VBusiness.Rooms
{
	public class Room27 : Room
	{
		// Mythic Room 2
		public override int RoomNumber => 27;

		public override int MineralPatches => 0;

		protected override IEnumerable<EnemyQuantity> GetBuildings()
		{
			return new List<EnemyQuantity>()
			{
				new EnemyQuantity(EnemyType.Spire, 3),
				new EnemyQuantity(EnemyType.SporeCannon, 9),
				new EnemyQuantity(EnemyType.Hive, 4),
			};
		}

		protected override IEnumerable<EnemyQuantity> GetEnemies()
		{
			return new List<EnemyQuantity>()
			{
				new EnemyQuantity(EnemyType.Infestor, 16),
			};
		}
	}
}
