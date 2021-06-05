using System;
using System.Collections.Generic;
using VBusiness.HelperClasses;
using VBusiness.Rooms;
using VEntityFramework;
using VEntityFramework.Model;

namespace VBusiness
{
	public abstract class Room
	{
		public static Room New(RoomNumber number)
		{
			var roomType = Type.GetType($"VBusiness.Rooms.{number}");

			if (roomType == null)
			{
				ErrorReporter.ReportDebug($"Please create a class named VBusiness.Rooms.Room{number}");
				return null;
			}

			var ret = (Room)Activator.CreateInstance(roomType);
			return ret;

		}
		public abstract RoomNumber RoomNumber { get; }
		public IEnumerable<EnemyQuantity> Buildings => GetBuildings();
		public IEnumerable<EnemyQuantity> EnemiesPerWave => GetEnemies();

		public bool HasBoss => GetBoss != EnemyType.None;
		public virtual EnemyType GetBoss => EnemyType.None;
		public abstract int MineralPatches { get; }
		protected abstract IEnumerable<EnemyQuantity> GetBuildings();
		protected abstract IEnumerable<EnemyQuantity> GetEnemies();
	}
}
