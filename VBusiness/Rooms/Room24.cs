﻿using System.Collections.Generic;
using VBusiness.HelperClasses;
using VEntityFramework.Model;

namespace VBusiness.Rooms
{
	public class Room24 : Room
	{
		// Titanic room 1
		public override RoomNumber RoomNumber => RoomNumber.Room24;

		public override int MineralPatches => 0;

		protected override IEnumerable<EnemyQuantity> GetBuildings()
		{
			return new List<EnemyQuantity>()
			{
				new EnemyQuantity(EnemyType.Spire, 2),
				new EnemyQuantity(EnemyType.HydraliskDen, 2),
				new EnemyQuantity(EnemyType.SporeCannon, 17),
				new EnemyQuantity(EnemyType.Hive, 1),
			};
		}

		protected override IEnumerable<EnemyQuantity> GetEnemies()
		{
			return new List<EnemyQuantity>()
			{
				new EnemyQuantity(EnemyType.Hydralisk, 10),
				new EnemyQuantity(EnemyType.Infestor, 4),
			};
		}

		public override EnemyType Bruta => EnemyType.Bruta5;
	}
}
