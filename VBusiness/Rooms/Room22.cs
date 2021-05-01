﻿using System.Collections.Generic;
using VBusiness.HelperClasses;
using VEntityFramework.Model;

namespace VBusiness.Rooms
{
	public class Room22 : Room
	{
		// Nightmare Room 1
		public override int RoomNumber => 22;

		public override int MineralPatches => 0;

		protected override IEnumerable<EnemyQuantity> GetBuildings()
		{
			return new List<EnemyQuantity>()
			{
				new EnemyQuantity(EnemyType.Spire, 2),
				new EnemyQuantity(EnemyType.Lair, 1),
				new EnemyQuantity(EnemyType.HydraliskDen, 4),
				new EnemyQuantity(EnemyType.SporeCannon, 8)
			};
		}

		protected override IEnumerable<EnemyQuantity> GetEnemies()
		{
			return new List<EnemyQuantity>()
			{
				new EnemyQuantity(EnemyType.Hydralisk, 20),
				new EnemyQuantity(EnemyType.GiantAbberation, 4),
			};
		}
	}
}
