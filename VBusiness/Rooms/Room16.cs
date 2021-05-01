using System.Collections.Generic;
using VBusiness.HelperClasses;
using VEntityFramework.Model;

namespace VBusiness.Rooms
{
	public class Room16 : Room
	{
		// Hard Room 4
		public override int RoomNumber => 16;

		public override int MineralPatches => 0;

		protected override IEnumerable<EnemyQuantity> GetBuildings()
		{
			return new List<EnemyQuantity>()
			{
				new EnemyQuantity(EnemyType.SporeCrawler, 10),
				new EnemyQuantity(EnemyType.Spire, 2),
				new EnemyQuantity(EnemyType.Lair, 2),
			};
		}

		protected override IEnumerable<EnemyQuantity> GetEnemies()
		{
			return new List<EnemyQuantity>()
			{
				new EnemyQuantity(EnemyType.Roach, 18),
				new EnemyQuantity(EnemyType.GiantAbberation, 8),
			};
		}

		public override EnemyType GetBoss => EnemyType.LieutenantRailgul;
	}
}
