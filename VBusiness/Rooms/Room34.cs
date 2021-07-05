using System.Collections.Generic;
using VBusiness.HelperClasses;

namespace VBusiness.Rooms
{
	public class Room34 : Room
	{
		public override RoomNumber RoomNumber => Rooms.RoomNumber.Room34;

		public override int MineralPatches => 0;

		protected override IEnumerable<EnemyQuantity> GetBuildings()
		{
			yield return new EnemyQuantity(VEntityFramework.Model.EnemyType.Hive, 4);
			yield return new EnemyQuantity(VEntityFramework.Model.EnemyType.Spire, 2);
			yield return new EnemyQuantity(VEntityFramework.Model.EnemyType.PygaliskCavern, 1);
		}

		protected override IEnumerable<EnemyQuantity> GetEnemies()
		{
			yield return new EnemyQuantity(VEntityFramework.Model.EnemyType.Infestor, 16);
			yield return new EnemyQuantity(VEntityFramework.Model.EnemyType.Pygalisk, 8);
		}
	}
}
