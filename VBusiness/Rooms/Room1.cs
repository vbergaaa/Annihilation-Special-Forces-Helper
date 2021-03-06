﻿using System.Collections.Generic;
using VBusiness.HelperClasses;
using VEntityFramework.Model;

namespace VBusiness.Rooms
{
	public class Room1 : Room
	{
		public override RoomNumber RoomNumber => RoomNumber.Room1;

		public override int MineralPatches => 0;

		protected override IEnumerable<EnemyQuantity> GetBuildings()
		{
			return new List<EnemyQuantity>()
			{
				new EnemyQuantity(EnemyType.SpineCrawler, 2),
				new EnemyQuantity(EnemyType.EvolutionChamber, 3),
			};
		}

		protected override IEnumerable<EnemyQuantity> GetEnemies()
		{
			return new List<EnemyQuantity>()
			{
				new EnemyQuantity(EnemyType.InfestedTerran, 18),
			};
		}

		protected internal override RoomNumber AdditionalOpenRooms => RoomNumber.Room3;
	}
}
