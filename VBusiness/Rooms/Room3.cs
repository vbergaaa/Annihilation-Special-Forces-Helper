using System.Collections.Generic;
using VBusiness.HelperClasses;
using VEntityFramework.Model;

namespace VBusiness.Rooms
{
	public class Room3 : Room
	{
		public override RoomNumber RoomNumber => RoomNumber.Room3;

		public override int MineralPatches => 3;

		protected override IEnumerable<EnemyQuantity> GetBuildings()
		{
			return new List<EnemyQuantity>()
			{
				new EnemyQuantity(EnemyType.SpineCrawler, 10),
				new EnemyQuantity(EnemyType.EvolutionChamber, 6),
			};
		}

		protected override IEnumerable<EnemyQuantity> GetEnemies()
		{
			return new List<EnemyQuantity>()
			{
				new EnemyQuantity(EnemyType.InfestedTerran, 48),
			};
		}
	}
}
