﻿using System.Collections.Generic;
using VBusiness.HelperClasses;
using VEntityFramework.Model;

namespace VBusiness.Rooms
{
	public class Room23 : Room
	{
		// Torment Room 1
		public override RoomNumber RoomNumber => RoomNumber.Room23;

		public override int MineralPatches => 0;

		protected override IEnumerable<EnemyQuantity> GetBuildings()
		{
			return new List<EnemyQuantity>()
			{
				new EnemyQuantity(EnemyType.Spire, 2),
				new EnemyQuantity(EnemyType.Lair, 2),
				new EnemyQuantity(EnemyType.HydraliskDen, 3),
				new EnemyQuantity(EnemyType.SporeCannon, 7)
			};
		}

		protected override IEnumerable<EnemyQuantity> GetEnemies()
		{
			return new List<EnemyQuantity>()
			{
				new EnemyQuantity(EnemyType.Hydralisk, 15),
				new EnemyQuantity(EnemyType.GiantAbberation, 8),
			};
		}

		public override EnemyType GetBoss => EnemyType.CaptainGamala;
	}
}
