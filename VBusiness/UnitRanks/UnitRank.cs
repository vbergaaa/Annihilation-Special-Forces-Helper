using EnumsNET;
using System;
using VBusiness.Perks;
using VBusiness.Souls;
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

		#region MegaBuffs

		public void ActivateMegaBuff() { }

		public void ActivateSuperMegaBuff() { }

		public void DeactivateMegaBuff() { }

		public void DeactivateSuperMegaBuff() { }

		#endregion

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

		#region DivineBuffs

		public void ActivateDivineBuff() { }

		public void ActivateSuperDivineBuff() { }

		public void DeactivateDivineBuff() { }

		public void DeactivateSuperDivineBuff() { }

		#endregion

		#region Omega Buffs

		public void ActivateOmegaBuff()
		{
			Loadout.Stats.Attack += 50;
			Loadout.Stats.UpdateAttackSpeed("Rank", 50);
			Loadout.Stats.UpdateHealth("Rank", 50);
			Loadout.Stats.HealthArmor += 50;
			Loadout.Stats.UpdateShields("Rank", 50);
			Loadout.Stats.ShieldsArmor += 50;
			Loadout.Stats.CriticalChance += 5;
			Loadout.Stats.CriticalDamage += 10;
		}

		public void ActivateSuperOmegaBuff()
		{
			Loadout.Stats.Attack += 100;
			Loadout.Stats.UpdateAttackSpeed("Rank", 100);
			Loadout.Stats.UpdateHealth("Rank", 100);
			Loadout.Stats.HealthArmor += 100;
			Loadout.Stats.UpdateShields("Rank", 100);
			Loadout.Stats.ShieldsArmor += 100;
			Loadout.Stats.CriticalChance += 10;
			Loadout.Stats.CriticalDamage += 20;
		}

		public void DeactivateOmegaBuff()
		{
			Loadout.Stats.Attack -= 50;
			Loadout.Stats.UpdateAttackSpeed("Rank", -50);
			Loadout.Stats.UpdateHealth("Rank", -50);
			Loadout.Stats.HealthArmor -= 50;
			Loadout.Stats.UpdateShields("Rank", -50);
			Loadout.Stats.ShieldsArmor -= 50;
			Loadout.Stats.CriticalChance -= 5;
			Loadout.Stats.CriticalDamage -= 10;
		}

		public void DeactivateSuperOmegaBuff()
		{
			Loadout.Stats.Attack -= 100;
			Loadout.Stats.UpdateAttackSpeed("Rank", -100);
			Loadout.Stats.UpdateHealth("Rank", -100);
			Loadout.Stats.HealthArmor -= 100;
			Loadout.Stats.UpdateShields("Rank", -100);
			Loadout.Stats.ShieldsArmor -= 100;
			Loadout.Stats.CriticalChance -= 10;
			Loadout.Stats.CriticalDamage -= 20;
		}

		#endregion

		#region QuasarBuffs

		public void ActivateQuasarBuff() { }

		public void DeactivateQuasarBuff() { }

		#endregion

		#region VoidBuffs

		public void ActivateVoidBuff() { }

		public void DeactivateVoidBuff() { }

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
			if (Rank >= UnitRankType.SSS)
			{
				Loadout.Stats.Attack -= 1.5 * ((PerkCollection)Loadout.Perks).TrifectaPower.DesiredLevel;
				Loadout.Stats.UpdateAttackSpeed("Trifecta", -1.5 * ((PerkCollection)Loadout.Perks).TrifectaPower.DesiredLevel);
				Loadout.Stats.UpdateHealth("Trifecta", -1.5 * ((PerkCollection)Loadout.Perks).TrifectaPower.DesiredLevel);
				Loadout.Stats.HealthArmor -= 1 * ((PerkCollection)Loadout.Perks).TrifectaPower.DesiredLevel;
				Loadout.Stats.UpdateShields("Trifecta", -1.5 * ((PerkCollection)Loadout.Perks).TrifectaPower.DesiredLevel);
				Loadout.Stats.ShieldsArmor -= 1 * ((PerkCollection)Loadout.Perks).TrifectaPower.DesiredLevel;
			}
		}

		void ActivateTrifectaPower()
		{
			if (Rank >= UnitRankType.SSS)
			{
				Loadout.Stats.Attack += 1.5 * ((PerkCollection)Loadout.Perks).TrifectaPower.DesiredLevel;
				Loadout.Stats.UpdateAttackSpeed("Trifecta", 1.5 * ((PerkCollection)Loadout.Perks).TrifectaPower.DesiredLevel);
				Loadout.Stats.UpdateHealth("Trifecta", 1.5 * ((PerkCollection)Loadout.Perks).TrifectaPower.DesiredLevel);
				Loadout.Stats.HealthArmor += 1 * ((PerkCollection)Loadout.Perks).TrifectaPower.DesiredLevel;
				Loadout.Stats.UpdateShields("Trifecta", 1.5 * ((PerkCollection)Loadout.Perks).TrifectaPower.DesiredLevel);
				Loadout.Stats.ShieldsArmor += 1 * ((PerkCollection)Loadout.Perks).TrifectaPower.DesiredLevel;
			}
		}
		#endregion

		#region Activate

		public override void ActivateRank()
		{
			Loadout.Stats.Attack += Attack;
			Loadout.Stats.UpdateAttackSpeed("Rank", AttackSpeed);
			Loadout.Stats.UpdateHealth("Rank", Vitals);
			Loadout.Stats.HealthArmor += Vitals;
			Loadout.Stats.UpdateHealth("Rank", Vitals);
			Loadout.Stats.ShieldsArmor += Vitals;
			Loadout.Stats.UpdateDamageIncrease("Rank", DamageIncrease);
			Loadout.Stats.UpdateDamageReduction("Rank", DamageReduction);
			Loadout.Stats.CooldownReduction += Speed;
			Loadout.Stats.MoveSpeed += Speed;

			ActivateMegaBuffs();
			ActivateGodBuffs();
			ActivateDivineBuffs();
			ActivateOmegaBuffs();
			ActivateVoidBuffs();
			ActivateTrifectaPower();
		}

		#endregion

		#region Deactivate

		public override void DeactivateRank()
		{
			Loadout.Stats.Attack -= Attack;
			Loadout.Stats.UpdateAttackSpeed("Rank", -AttackSpeed);
			Loadout.Stats.UpdateHealth("Rank", Vitals);
			Loadout.Stats.HealthArmor -= Vitals;
			Loadout.Stats.UpdateHealth("Rank", Vitals);
			Loadout.Stats.ShieldsArmor -= Vitals;
			Loadout.Stats.UpdateDamageIncrease("Rank", -DamageIncrease);
			Loadout.Stats.UpdateDamageReduction("Rank", -DamageReduction);
			Loadout.Stats.CooldownReduction -= Speed;
			Loadout.Stats.MoveSpeed -= Speed;

			DeactivateMegaBuffs();
			DeactivateGodBuffs();
			DeactivateDivineBuffs();
			DeactivateOmegaBuffs();
			DeactivateVoidBuffs();
			DeactivateTrifectaPower();
		}

		#endregion
	}
}
