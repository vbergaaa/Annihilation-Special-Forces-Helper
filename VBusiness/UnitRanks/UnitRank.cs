using EnumsNET;
using System;
using VBusiness.Souls;
using VEntityFramework.Model;

namespace VBusiness.Ranks
{
	public abstract class UnitRank : VUnitRank
	{
		#region Constructor

		public UnitRank(VUnit unit) : base(unit)
		{
		}

		#endregion

		#region New

		public static VUnitRank New(VEntityFramework.Model.UnitRank rank, VUnit unit)
		{
			if (rank == VEntityFramework.Model.UnitRank.None)
			{
				return new EmptyRank(unit);
			}
			var rankName = "Rank" + rank.AsString(EnumFormat.Name);
			var rankType = System.Type.GetType($"VBusiness.Ranks.{rankName}");

			if (rankType == null)
			{
#if DEBUG
				throw new Exception($"Please create a class named VBusiness.Ranks.{rankName}");
#else
				return new EmptyRank(unit);
#endif
			}

			var ret = (UnitRank)Activator.CreateInstance(rankType, unit);
			return ret;
		}

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
			Unit.Loadout.Stats.CriticalChance += 5;
			Unit.Loadout.Stats.CriticalDamage += 10;
		}

		public void ActivateSuperGodBuff()
		{
			Unit.Loadout.Stats.CriticalChance += 10;
			Unit.Loadout.Stats.CriticalDamage += 20;
		}

		public void DeactivateGodBuff()
		{
			Unit.Loadout.Stats.CriticalChance -= 5;
			Unit.Loadout.Stats.CriticalDamage -= 10;
		}

		public void DeactivateSuperGodBuff()
		{
			Unit.Loadout.Stats.CriticalChance -= 10;
			Unit.Loadout.Stats.CriticalDamage -= 20;
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
			Unit.Loadout.Stats.Attack += 50;
			Unit.Loadout.Stats.UpdateAttackSpeed("Rank", 50);
			Unit.Loadout.Stats.Health += 50;
			Unit.Loadout.Stats.HealthArmor += 50;
			Unit.Loadout.Stats.Shields += 50;
			Unit.Loadout.Stats.ShieldsArmor += 50;
			Unit.Loadout.Stats.CriticalChance += 5;
			Unit.Loadout.Stats.CriticalDamage += 10;
		}

		public void ActivateSuperOmegaBuff()
		{
			Unit.Loadout.Stats.Attack += 100;
			Unit.Loadout.Stats.UpdateAttackSpeed("Rank", 100);
			Unit.Loadout.Stats.Health += 100;
			Unit.Loadout.Stats.HealthArmor += 100;
			Unit.Loadout.Stats.Shields += 100;
			Unit.Loadout.Stats.ShieldsArmor += 100;
			Unit.Loadout.Stats.CriticalChance += 10;
			Unit.Loadout.Stats.CriticalDamage += 20;
		}

		public void DeactivateOmegaBuff()
		{
			Unit.Loadout.Stats.Attack -= 50;
			Unit.Loadout.Stats.UpdateAttackSpeed("Rank", -50);
			Unit.Loadout.Stats.Health -= 50;
			Unit.Loadout.Stats.HealthArmor -= 50;
			Unit.Loadout.Stats.Shields -= 50;
			Unit.Loadout.Stats.ShieldsArmor -= 50;
			Unit.Loadout.Stats.CriticalChance -= 5;
			Unit.Loadout.Stats.CriticalDamage -= 10;
		}

		public void DeactivateSuperOmegaBuff()
		{
			Unit.Loadout.Stats.Attack -= 100;
			Unit.Loadout.Stats.UpdateAttackSpeed("Rank", -100);
			Unit.Loadout.Stats.Health -= 100;
			Unit.Loadout.Stats.HealthArmor -= 100;
			Unit.Loadout.Stats.Shields -= 100;
			Unit.Loadout.Stats.ShieldsArmor -= 100;
			Unit.Loadout.Stats.CriticalChance -= 10;
			Unit.Loadout.Stats.CriticalDamage -= 20;
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
			if (Rank >= VEntityFramework.Model.UnitRank.SS)
			{
				if (Rank >= VEntityFramework.Model.UnitRank.SSS)
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
			if (Rank >= VEntityFramework.Model.UnitRank.SX)
			{
				if (Rank >= VEntityFramework.Model.UnitRank.SSSX)
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
			if (Rank >= VEntityFramework.Model.UnitRank.SXD)
			{
				if (Rank >= VEntityFramework.Model.UnitRank.SZ)
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
			if (Rank >= VEntityFramework.Model.UnitRank.XZ)
			{
				if (Rank >= VEntityFramework.Model.UnitRank.XDZ)
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
			if (Rank >= VEntityFramework.Model.UnitRank.SXDZ)
			{
				ActivateQuasarBuff();
			}
			if (Rank >= VEntityFramework.Model.UnitRank.XYZ)
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
			if (Rank >= VEntityFramework.Model.UnitRank.SS)
			{
				if (Rank >= VEntityFramework.Model.UnitRank.SSS)
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
			if (Rank >= VEntityFramework.Model.UnitRank.SX)
			{
				if (Rank >= VEntityFramework.Model.UnitRank.SSSX)
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
			if (Rank >= VEntityFramework.Model.UnitRank.SXD)
			{
				if (Rank >= VEntityFramework.Model.UnitRank.SZ)
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
			if (Rank >= VEntityFramework.Model.UnitRank.XZ)
			{
				if (Rank >= VEntityFramework.Model.UnitRank.XDZ)
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
			if (Rank >= VEntityFramework.Model.UnitRank.SXDZ)
			{
				DeactivateQuasarBuff();
			}
			if (Rank >= VEntityFramework.Model.UnitRank.XYZ)
			{
				DeactivateVoidBuff();
			}
		}

		#endregion

		#endregion

		#endregion

		#region Activate

		public override void ActivateRank()
		{
			if (Unit.IsCurrentUnit)
			{
				Unit.Loadout.Stats.Attack += Attack;
				Unit.Loadout.Stats.UpdateAttackSpeed("Rank", AttackSpeed);
				Unit.Loadout.Stats.Health += Vitals;
				Unit.Loadout.Stats.HealthArmor += Vitals;
				Unit.Loadout.Stats.Shields += Vitals;
				Unit.Loadout.Stats.ShieldsArmor += Vitals;
				Unit.Loadout.Stats.DamageIncrease += DamageIncrease;
				Unit.Loadout.Stats.UpdateDamageReduction("Rank", DamageReduction);
				Unit.Loadout.Stats.CooldownReduction += Speed;
				Unit.Loadout.Stats.MoveSpeed += Speed;
				Unit.Loadout.Stats.Rank = Rank;

				ActivateMegaBuffs();
				ActivateGodBuffs();
				ActivateDivineBuffs();
				ActivateOmegaBuffs();
				ActivateVoidBuffs();
			}
		}

		#endregion

		#region Deactivate

		public override void DeactivateRank()
		{
			if (Unit.IsCurrentUnit)
			{
				Unit.Loadout.Stats.Attack -= Attack;
				Unit.Loadout.Stats.UpdateAttackSpeed("Rank", -AttackSpeed);
				Unit.Loadout.Stats.Health -= Vitals;
				Unit.Loadout.Stats.HealthArmor -= Vitals;
				Unit.Loadout.Stats.Shields -= Vitals;
				Unit.Loadout.Stats.ShieldsArmor -= Vitals;
				Unit.Loadout.Stats.DamageIncrease -= DamageIncrease;
				Unit.Loadout.Stats.UpdateDamageReduction("Rank", -DamageReduction);
				Unit.Loadout.Stats.CooldownReduction -= Speed;
				Unit.Loadout.Stats.MoveSpeed -= Speed;
				Unit.Loadout.Stats.Rank = Rank;

				DeactivateMegaBuffs();
				DeactivateGodBuffs();
				DeactivateDivineBuffs();
				DeactivateOmegaBuffs();
				DeactivateVoidBuffs();
			}
		}

		#endregion
	}
}
