using System;
using System.Collections.Generic;
using VBusiness.HelperClasses;
using VEntityFramework;
using VEntityFramework.Model;

namespace VBusiness
{
	public abstract class Room
	{
		public static Room New(int number)
		{
			var roomType = System.Type.GetType($"VBusiness.Rooms.Room{number}");

			if (roomType == null)
			{
				ErrorReporter.ReportDebug($"Please create a class named VBusiness.Rooms.Room{number}");
				return null;
			}

			var ret = (Room)Activator.CreateInstance(roomType);
			return ret;

		}
		public abstract int RoomNumber { get; }
		public IEnumerable<EnemyQuantity> Buildings => GetBuildings();
		public IEnumerable<EnemyQuantity> EnemiesPerWave => GetEnemies();

		public bool HasBoss => GetBoss != EnemyType.None;
		public virtual EnemyType GetBoss => EnemyType.None;
		public abstract int MineralPatches { get; }
		protected abstract IEnumerable<EnemyQuantity> GetBuildings();
		protected abstract IEnumerable<EnemyQuantity> GetEnemies();
	}
}
