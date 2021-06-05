using EnumsNET;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;
using VBusiness;
using VBusiness.Rooms;

namespace Tests
{
	public class RoomTests
	{
		[Test]
		public void TestRoomsDontThrow()
		{
			var rooms = Enums.GetValues<RoomNumber>();

			foreach (var roomType in rooms)
			{
				if (roomType != RoomNumber.None)
				{
					var room = Room.New(roomType);
					Assert.That(() => room.Buildings, Throws.Nothing);
					Assert.That(() => room.EnemiesPerWave, Throws.Nothing);
					Assert.That(() => room.GetBoss, Throws.Nothing);
					Assert.That(() => room.MineralPatches, Throws.Nothing);
					Assert.That(() => room.RoomNumber, Throws.Nothing);
				}
			}
		}
	}
}
