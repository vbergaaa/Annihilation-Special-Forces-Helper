using System.Collections.Generic;
using VBusiness.HelperClasses;
using VEntityFramework.Model;

namespace VBusiness.Rooms
{
	public class Room33 : Room
	{
		public override RoomNumber RoomNumber => RoomNumber.Room33;

		public override int MineralPatches => 0;

		protected override IEnumerable<EnemyQuantity> GetBuildings()
		{
			return new List<EnemyQuantity>()
			{
				new EnemyQuantity(EnemyType.Spire, 2),
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

		public override EnemyType GetBoss => EnemyType.MajorAsylum;
	}
}
