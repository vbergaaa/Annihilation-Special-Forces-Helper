using System.Collections.Generic;
using VBusiness.HelperClasses;

namespace VBusiness.Rooms
{
	public class Room36 : Room
	{
		public override RoomNumber RoomNumber => RoomNumber.Room36;

		public override int MineralPatches => 0;

		protected override IEnumerable<EnemyQuantity> GetBuildings()
		{
			yield return new EnemyQuantity(VEntityFramework.Model.EnemyType.Hive, 5);
			yield return new EnemyQuantity(VEntityFramework.Model.EnemyType.Spire, 3);
			yield return new EnemyQuantity(VEntityFramework.Model.EnemyType.PygaliskCavern, 1);
		}

		protected override IEnumerable<EnemyQuantity> GetEnemies()
		{
			yield return new EnemyQuantity(VEntityFramework.Model.EnemyType.Infestor, 20);
			yield return new EnemyQuantity(VEntityFramework.Model.EnemyType.Pygalisk, 8);
		}
	}
}
