using System.Collections.Generic;
using VBusiness.HelperClasses;
using VEntityFramework.Model;

namespace VBusiness.Rooms
{
	public class Room4 : Room
	{
		public override int RoomNumber => 4;

		public override int MineralPatches => 6;

		protected override IEnumerable<EnemyQuantity> GetBuildings()
		{
			return new List<EnemyQuantity>()
			{
				new EnemyQuantity(EnemyType.SpineCrawler, 15),
				new EnemyQuantity(EnemyType.EvolutionChamber, 4),
				new EnemyQuantity(EnemyType.Hatchery, 1),
			};
		}

		protected override IEnumerable<EnemyQuantity> GetEnemies()
		{
			return new List<EnemyQuantity>()
			{
				new EnemyQuantity(EnemyType.InfestedTerran, 40),
				new EnemyQuantity(EnemyType.Abberation, 3),
			};
		}
	}
}
