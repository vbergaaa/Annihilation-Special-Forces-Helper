using System.Collections.Generic;
using VBusiness.HelperClasses;
using VEntityFramework.Model;

namespace VBusiness.Rooms
{
	public class Room2 : Room
	{
		public override RoomNumber RoomNumber => RoomNumber.Room2;

		public override int MineralPatches => 6;

		protected override IEnumerable<EnemyQuantity> GetBuildings()
		{
			return new List<EnemyQuantity>()
			{
				new EnemyQuantity(EnemyType.SpineCrawler, 7),
				new EnemyQuantity(EnemyType.EvolutionChamber, 4),
			};
		}

		protected override IEnumerable<EnemyQuantity> GetEnemies()
		{
			return new List<EnemyQuantity>()
			{
				new EnemyQuantity(EnemyType.InfestedTerran, 24),
			};
		}
	}
}
