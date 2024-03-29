﻿using EnumsNET;
using System;
using System.Collections.Generic;
using VBusiness.HelperClasses;
using VBusiness.Rooms;
using VEntityFramework;
using VEntityFramework.Model;

namespace VBusiness.Enemies
{
	public abstract class EnemyUnit
	{
		public abstract EnemyType EnemyType { get; }
		public abstract double Attack { get; }
		public abstract double AttackSpeed { get; }
		public abstract double Health { get; }
		public abstract double HealthArmor { get; }
		public abstract double AttackIncrement { get; }
		public abstract double HealthIncrement { get; }
		public abstract double HealthArmorIncrement { get; }
		public abstract int MineralBounty { get; }
		public virtual int KillBounty { get; }
		public virtual EnemyQuantity BrutaSpawns => new();

		public static EnemyUnit New(EnemyType unitType)
		{
			var enemyName = unitType.AsString(EnumFormat.Name);
			var enemyType = System.Type.GetType($"VBusiness.Enemies.{enemyName}");

			if (enemyType == null)
			{
				ErrorReporter.ReportDebug($"Please create a class named VBusiness.Enemies.{enemyName}");
				return null;
			}

			var ret = (EnemyUnit)Activator.CreateInstance(enemyType);
			return ret;
		}

		protected virtual IEnumerable<EnemyQuantity> UnitsSpawnedOnDeath => Array.Empty<EnemyQuantity>();

		public static EnemyType FirstUnit => EnemyType.InfestedTerran;
		public static EnemyType LastUnit => FirstAbbertion - 1;
		public static EnemyType FirstAbbertion => EnemyType.Abberation;
		public static EnemyType LastAbbertion => EnemyType.Queen - 1;
		public static EnemyType FirstQueen => EnemyType.Queen;
		public static EnemyType LastQueen => EnemyType.SergeantRamone - 1;
		public static EnemyType FirstBoss => EnemyType.SergeantRamone;
		public static EnemyType LastBoss => EnemyType.EvolutionChamber - 1;
		public static EnemyType FirstBruta => EnemyType.Bruta1;

		public static RoomNumber Bruta1Room => RoomNumber.Room9;
		public static RoomNumber Bruta2Room => RoomNumber.Room12;
		public static RoomNumber Bruta3Room => RoomNumber.Room17;
		public static RoomNumber Bruta4Room => RoomNumber.Room21;
		public static RoomNumber Bruta5Room => RoomNumber.Room24;
		public static RoomNumber Bruta6Room => RoomNumber.Room31;

		internal virtual IEnumerable<EnemyQuantity> GetUnitsSpawnedOnDeath(double tierUpLevels, RoomNumber room)
		{
			if (EnemyType.IsBoss() || EnemyType.IsBuilding())
			{
				return UnitsSpawnedOnDeath.TierUp(tierUpLevels);
			}
			return UnitsSpawnedOnDeath;
		}
	}
}
