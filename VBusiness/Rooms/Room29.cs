using System.Collections.Generic;
using VBusiness.HelperClasses;
using VEntityFramework.Model;

namespace VBusiness.Rooms
{
	public class Room29 : Room
	{
		// Divine Room 2
		
		public override RoomNumber RoomNumber => RoomNumber.Room29;

		public override int MineralPatches => 0;

		protected override IEnumerable<EnemyQuantity> GetBuildings()
		{
			return new List<EnemyQuantity>()
			{
				new EnemyQuantity(EnemyType.Spire, 2),
				new EnemyQuantity(EnemyType.SporeCannon, 8),
				new EnemyQuantity(EnemyType.Hive, 2),
				new EnemyQuantity(EnemyType.PygaliskCavern, 2),
			};
		}

		protected override IEnumerable<EnemyQuantity> GetEnemies()
		{
			return new List<EnemyQuantity>()
			{
				new EnemyQuantity(EnemyType.Pygalisk, 16),
				new EnemyQuantity(EnemyType.Infestor, 8),
			};
		}
	}
}
