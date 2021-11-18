using EnumsNET;
using System;
using VBusiness.Perks;
using VEntityFramework;
using VEntityFramework.Model;

namespace VBusiness.Ranks
{
	public abstract class UnitRank : VUnitRank
	{
		#region New

		public static VUnitRank New(UnitRankType rank)
		{
			if (rank == UnitRankType.None)
			{
				return new EmptyRank();
			}
			var rankName = "Rank" + rank.AsString(EnumFormat.Name);
			var rankType = System.Type.GetType($"VBusiness.Ranks.{rankName}");

			if (rankType == null)
			{
				ErrorReporter.ReportDebug($"Please create a class named VBusiness.Ranks.{rankName}");
				return new EmptyRank();
			}

			var ret = (UnitRank)Activator.CreateInstance(rankType);
			return ret;
		}

		#endregion

		#region Properties

		public override VLoadout Loadout { get; set; }

		#endregion

		#region Buffs

		#region God Buffs

		public void ActivateGodBuff()
		{
			Loadout.Stats.CriticalChance += 5;
			Loadout.Stats.CriticalDamage += 10;
		}

		public void ActivateSuperGodBuff()
		{
			Loadout.Stats.CriticalChance += 10;
			Loadout.Stats.CriticalDamage += 20;
		}

		public void DeactivateGodBuff()
		{
			Loadout.Stats.CriticalChance -= 5;
			Loadout.Stats.CriticalDamage -= 10;
		}

		public void DeactivateSuperGodBuff()
		{
			Loadout.Stats.CriticalChance -= 10;
			Loadout.Stats.CriticalDamage -= 20;
		}

		#endregion

		#region Omega Buffs

		public void ActivateOmegaBuff()
		{
			Loadout.Stats.Attack += 50;
			Loadout.Stats.UpdateAttackSpeed("Omega", 50);
			Loadout.Stats.UpdateHealth("Core", 50);
			Loadout.Stats.UpdateHealthArmor("Omega", 10); // we were lied to
			Loadout.Stats.UpdateShields("Core", 50);
			Loadout.Stats.UpdateShieldsArmor("Omega", 10);
			Loadout.Stats.CriticalChance += 5;
			Loadout.Stats.CriticalDamage += 10;
		}

		public void ActivateSuperOmegaBuff()
		{
			Loadout.Stats.Attack += 100;
			Loadout.Stats.UpdateAttackSpeed("Omega", 100);
			Loadout.Stats.UpdateHealth("Core", 100);
			Loadout.Stats.UpdateHealthArmor("Omega", 20);
			Loadout.Stats.UpdateShields("Core", 100);
			Loadout.Stats.UpdateShieldsArmor("Omega", 20);
			Loadout.Stats.CriticalChance += 10;
			Loadout.Stats.CriticalDamage += 20;
		}

		public void DeactivateOmegaBuff()
		{
			Loadout.Stats.Attack -= 50;
			Loadout.Stats.UpdateAttackSpeed("Omega", -50);
			Loadout.Stats.UpdateHealth("Core", -50);
			Loadout.Stats.UpdateHealthArmor("Omega", -10);
			Loadout.Stats.UpdateShields("Core", -50);
			Loadout.Stats.UpdateShieldsArmor("Omega", -10);
			Loadout.Stats.CriticalChance -= 5;
			Loadout.Stats.CriticalDamage -= 10;
		}

		public void DeactivateSuperOmegaBuff()
		{
			Loadout.Stats.Attack -= 100;
			Loadout.Stats.UpdateAttackSpeed("Omega", -100);
			Loadout.Stats.UpdateHealth("Core", -100);
			Loadout.Stats.UpdateHealthArmor("Omega", -20);
			Loadout.Stats.UpdateShields("Core", -100);
			Loadout.Stats.UpdateShieldsArmor("Omega", -20);
			Loadout.Stats.CriticalChance -= 10;
			Loadout.Stats.CriticalDamage -= 20;
		}

		#endregion

		#region VoidBuffs

		public void ActivateVoidBuff()
		{
			Loadout.Stats.UpdateAcceleration("Void", 100);
		}

		public void DeactivateVoidBuff()
		{
			Loadout.Stats.UpdateAcceleration("Void", -100);
		}

		#endregion

		#endregion

		#region Trigger Buffs

		#region Activate

		#region MegaBuffs

		void ActivateMegaBuffs()
		{
			if (Rank >= UnitRankType.SS)
			{
				if (Rank >= UnitRankType.SSS)
				{
                    ActivateSuperMegaBuff();
				}
				else
				{
                    ActivateMegaBuff();
				}
			}
		}

		#endregion

		#region GodBuffs

		void ActivateGodBuffs()
		{
			if (Rank >= UnitRankType.SX)
			{
				if (Rank >= UnitRankType.SSSX)
				{
					ActivateSuperGodBuff();
				}
				else
				{
					ActivateGodBuff();
				}
			}
		}

		#endregion

		#region Divine Buffs

		void ActivateDivineBuffs()
		{
			if (Rank >= UnitRankType.SXD)
			{
				if (Rank >= UnitRankType.SZ)
				{
                    ActivateSuperDivineBuff();
				}
				else
				{
                    ActivateDivineBuff();
				}
			}
		}

		#endregion

		#region OmegaBuffs

		void ActivateOmegaBuffs()
		{
			if (Rank >= UnitRankType.XZ)
			{
				if (Rank >= UnitRankType.XDZ)
				{
					ActivateSuperOmegaBuff();
				}
				else
				{
					ActivateOmegaBuff();
				}
			}
		}

		#endregion

		#region VoidBuffs

		void ActivateVoidBuffs()
		{
			if (Rank >= UnitRankType.SXDZ)
			{
                ActivateQuasarBuff();
			}
			if (Rank >= UnitRankType.XYZ)
			{
				ActivateVoidBuff();
			}
		}

		#endregion

		#endregion

		#region Deactivate

		#region MegaBuffs

		void DeactivateMegaBuffs()
		{
			if (Rank >= UnitRankType.SS)
			{
				if (Rank >= UnitRankType.SSS)
				{
                    DeactivateSuperMegaBuff();
				}
				else
				{
                    DeactivateMegaBuff();
				}
			}
		}

		#endregion

		#region GodBuffs

		void DeactivateGodBuffs()
		{
			if (Rank >= UnitRankType.SX)
			{
				if (Rank >= UnitRankType.SSSX)
				{
					DeactivateSuperGodBuff();
				}
				else
				{
					DeactivateGodBuff();
				}
			}
		}

		#endregion

		#region Divine Buffs

		void DeactivateDivineBuffs()
		{
			if (Rank >= UnitRankType.SXD)
			{
				if (Rank >= UnitRankType.SZ)
				{
                    DeactivateSuperDivineBuff();
				}
				else
				{
                    DeactivateDivineBuff();
				}
			}
		}

		#endregion

		#region OmegaBuffs

		void DeactivateOmegaBuffs()
		{
			if (Rank >= UnitRankType.XZ)
			{
				if (Rank >= UnitRankType.XDZ)
				{
					DeactivateSuperOmegaBuff();
				}
				else
				{
					DeactivateOmegaBuff();
				}
			}
		}

		#endregion

		#region VoidBuffs

		void DeactivateVoidBuffs()
		{
			if (Rank >= UnitRankType.SXDZ)
			{
                DeactivateQuasarBuff();
			}
			if (Rank >= UnitRankType.XYZ)
			{
				DeactivateVoidBuff();
			}
		}

		#endregion

		#endregion

		#endregion

		#region Trifecta Power

		void DeactivateTrifectaPower()
		{
			var perks = Loadout.Perks as PerkCollection;
			var trifectaLevel = perks.TrifectaPower.DesiredLevel;
			if (Rank >= UnitRankType.SSS)
			{
				Loadout.Stats.Attack -= 1.5 * trifectaLevel;
				Loadout.Stats.UpdateAttackSpeed("Trifecta", -1.5 * trifectaLevel);
				Loadout.Stats.UpdateHealth("Core", -1.5 * trifectaLevel);
				Loadout.Stats.UpdateHealthArmor("Trifecta", -trifectaLevel);
				Loadout.Stats.UpdateShields("Core", -1.5 * trifectaLevel);
				Loadout.Stats.UpdateShieldsArmor("Trifecta", -trifectaLevel);
			}
			if (Rank >= UnitRankType.Z && perks.UpgradeCache.DesiredLevel > 0 && trifectaLevel == perks.TrifectaPower.MaxLevel)
			{
				Loadout.Stats.Attack -= 1.5 * trifectaLevel;
				Loadout.Stats.UpdateAttackSpeed("Trifecta", -1.5 * trifectaLevel);
				Loadout.Stats.UpdateHealth("Core", -1.5 * trifectaLevel);
				Loadout.Stats.UpdateShields("Core", -1.5 * trifectaLevel);
			}
		}

		void ActivateTrifectaPower()
		{
			var perks = Loadout.Perks as PerkCollection;
			var trifectaLevel = perks.TrifectaPower.DesiredLevel;
			if (Rank >= UnitRankType.SSS)
			{
				Loadout.Stats.Attack += 1.5 * trifectaLevel;
				Loadout.Stats.UpdateAttackSpeed("Trifecta", 1.5 * trifectaLevel);
				Loadout.Stats.UpdateHealth("Core", 1.5 * trifectaLevel);
				Loadout.Stats.UpdateHealthArmor("Trifecta", trifectaLevel);
				Loadout.Stats.UpdateShields("Core", 1.5 * trifectaLevel);
				Loadout.Stats.UpdateShieldsArmor("Trifecta", trifectaLevel);
			}
			if (Rank >= UnitRankType.Z && perks.UpgradeCache.DesiredLevel > 0 && trifectaLevel == perks.TrifectaPower.MaxLevel)
			{
				Loadout.Stats.Attack += 1.5 * trifectaLevel;
				Loadout.Stats.UpdateAttackSpeed("Trifecta", 1.5 * trifectaLevel);
				Loadout.Stats.UpdateHealth("Core", 1.5 * trifectaLevel);
				Loadout.Stats.UpdateShields("Core", 1.5 * trifectaLevel);
			}
		}
		#endregion

		#region Activate

		public override void ActivateRank()
		{
			using (Loadout.Stats.SuspendRefreshingStatBindings())
			{
				Loadout.Stats.Attack += Attack;
				Loadout.Stats.UpdateAttackSpeed("Rank", AttackSpeed);
				Loadout.Stats.UpdateHealth("Core", Vitals);
				Loadout.Stats.UpdateHealthArmor("Rank", Armor);
				Loadout.Stats.UpdateShields("Core", Vitals);
				Loadout.Stats.UpdateShieldsArmor("Rank", Armor);
				Loadout.Stats.UpdateDamageIncrease("Rank", DamageIncrease);
				Loadout.Stats.UpdateDamageReduction("Rank", DamageReduction);
				Loadout.Stats.UpdateCooldownSpeed("Rank", Speed);
				Loadout.Stats.MoveSpeed += Speed;

				ActivateMegaBuffs();
				ActivateGodBuffs();
				ActivateDivineBuffs();
				ActivateOmegaBuffs();
				ActivateVoidBuffs();
				ActivateTrifectaPower();
			}
		}

		#endregion

		#region Deactivate

		public override void DeactivateRank()
		{
			using (Loadout.Stats.SuspendRefreshingStatBindings())
			{
				Loadout.Stats.Attack -= Attack;
				Loadout.Stats.UpdateAttackSpeed("Rank", -AttackSpeed);
				Loadout.Stats.UpdateHealth("Core", -Vitals);
				Loadout.Stats.UpdateHealthArmor("Rank", -Armor);
				Loadout.Stats.UpdateShields("Core", -Vitals);
				Loadout.Stats.UpdateShieldsArmor("Rank", -Armor);
				Loadout.Stats.UpdateDamageIncrease("Rank", -DamageIncrease);
				Loadout.Stats.UpdateDamageReduction("Rank", -DamageReduction);
				Loadout.Stats.UpdateCooldownSpeed("Rank", -Speed);
				Loadout.Stats.MoveSpeed -= Speed;

				DeactivateMegaBuffs();
				DeactivateGodBuffs();
				DeactivateDivineBuffs();
				DeactivateOmegaBuffs();
				DeactivateVoidBuffs();
				DeactivateTrifectaPower();
			}
		}

		#endregion
	}
}
