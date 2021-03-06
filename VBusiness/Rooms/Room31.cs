﻿using System.Collections.Generic;
using VBusiness.HelperClasses;
using VEntityFramework.Model;

namespace VBusiness.Rooms
{
	public class Room31 : Room
	{
		// Impossible Room 1
		public override RoomNumber RoomNumber => RoomNumber.Room31;

		public override int MineralPatches => 0;

		protected override IEnumerable<EnemyQuantity> GetBuildings()
		{
			return new List<EnemyQuantity>()
			{
				new EnemyQuantity(EnemyType.Spire, 1),
				new EnemyQuantity(EnemyType.Hive, 3),
				new EnemyQuantity(EnemyType.PygaliskCavern, 1),
			};
		}

		protected override IEnumerable<EnemyQuantity> GetEnemies()
		{
			return new List<EnemyQuantity>()
			{
				new EnemyQuantity(EnemyType.Pygalisk, 8),
				new EnemyQuantity(EnemyType.Infestor, 12),
			};
		}

		public override EnemyType Bruta => EnemyType.Bruta6;
	}
}
