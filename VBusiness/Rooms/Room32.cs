using System.Collections.Generic;
using VBusiness.HelperClasses;
using VEntityFramework.Model;

namespace VBusiness.Rooms
{
	public class Room32 : Room
	{
		// Impossible Room 2
		public override int RoomNumber => 32;

		public override int MineralPatches => 0;

		protected override IEnumerable<EnemyQuantity> GetBuildings()
		{
			return new List<EnemyQuantity>()
			{
				new EnemyQuantity(EnemyType.Spire, 1),
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
