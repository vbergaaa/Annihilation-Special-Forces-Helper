using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;
using VBusiness;

namespace Tests
{
	public class RoomTests
	{
		[Test]
		public void TestRoomsDontThrow()
		{
			for (var i = 1; i <= 33; i++)
			{
				var room = Room.New(i);
				Assert.That(() => room.Buildings, Throws.Nothing);
				Assert.That(() => room.EnemiesPerWave, Throws.Nothing);
				Assert.That(() => room.GetBoss, Throws.Nothing);
				Assert.That(() => room.MineralPatches, Throws.Nothing);
				Assert.That(() => room.RoomNumber, Throws.Nothing);
			}
		}
	}
}
