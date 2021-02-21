using EnumsNET;
using System;
using VBusiness.Souls;
using VEntityFramework.Model;

namespace VBusiness.Ranks
{
	public abstract class UnitRank : VUnitRank
	{
		#region Constructor

		public UnitRank(VUnitConfiguration config) : base(config)
		{
		}

		#endregion

		#region New

		public static VUnitRank New(VEntityFramework.Model.UnitRank rank, VUnitConfiguration config)
		{
			if (rank == VEntityFramework.Model.UnitRank.None)
			{
				return new EmptyRank(config);
			}
			var rankName = "Rank" + rank.AsString(EnumFormat.Name);
			var rankType = System.Type.GetType($"VBusiness.Ranks.{rankName}");

			if (rankType == null)
			{
#if DEBUG
				throw new Exception($"Please create a class named VBusiness.Ranks.{rankName}");
#else
				return new EmptyRank(config);
#endif
			}

			var ret = (UnitRank)Activator.CreateInstance(rankType, config);
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
			UnitConfiguration.Loadout.Stats.CriticalChance += 5;
			UnitConfiguration.Loadout.Stats.CriticalDamage += 10;
		}

		public void ActivateSuperGodBuff()
		{
			UnitConfiguration.Loadout.Stats.CriticalChance += 10;
			UnitConfiguration.Loadout.Stats.CriticalDamage += 20;
		}

		public void DeactivateGodBuff()
		{
			UnitConfiguration.Loadout.Stats.CriticalChance -= 5;
			UnitConfiguration.Loadout.Stats.CriticalDamage -= 10;
		}

		public void DeactivateSuperGodBuff()
		{
			UnitConfiguration.Loadout.Stats.CriticalChance -= 10;
			UnitConfiguration.Loadout.Stats.CriticalDamage -= 20;
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
			UnitConfiguration.Loadout.Stats.Attack += 50;
			UnitConfiguration.Loadout.Stats.AttackSpeed += 50;
			UnitConfiguration.Loadout.Stats.Health += 50;
			UnitConfiguration.Loadout.Stats.HealthArmor += 50;
			UnitConfiguration.Loadout.Stats.Shields += 50;
			UnitConfiguration.Loadout.Stats.ShieldsArmor += 50;
			UnitConfiguration.Loadout.Stats.CriticalChance += 5;
			UnitConfiguration.Loadout.Stats.CriticalDamage += 10;
		}

		public void ActivateSuperOmegaBuff()
		{
			UnitConfiguration.Loadout.Stats.Attack += 100;
			UnitConfiguration.Loadout.Stats.AttackSpeed += 100;
			UnitConfiguration.Loadout.Stats.Health += 100;
			UnitConfiguration.Loadout.Stats.HealthArmor += 100;
			UnitConfiguration.Loadout.Stats.Shields += 100;
			UnitConfiguration.Loadout.Stats.ShieldsArmor += 100;
			UnitConfiguration.Loadout.Stats.CriticalChance += 10;
			UnitConfiguration.Loadout.Stats.CriticalDamage += 20;
		}

		public void DeactivateOmegaBuff()
		{
			UnitConfiguration.Loadout.Stats.Attack -= 50;
			UnitConfiguration.Loadout.Stats.AttackSpeed -= 50;
			UnitConfiguration.Loadout.Stats.Health -= 50;
			UnitConfiguration.Loadout.Stats.HealthArmor -= 50;
			UnitConfiguration.Loadout.Stats.Shields -= 50;
			UnitConfiguration.Loadout.Stats.ShieldsArmor -= 50;
			UnitConfiguration.Loadout.Stats.CriticalChance -= 5;
			UnitConfiguration.Loadout.Stats.CriticalDamage -= 10;
		}

		public void DeactivateSuperOmegaBuff()
		{
			UnitConfiguration.Loadout.Stats.Attack -= 100;
			UnitConfiguration.Loadout.Stats.AttackSpeed -= 100;
			UnitConfiguration.Loadout.Stats.Health -= 100;
			UnitConfiguration.Loadout.Stats.HealthArmor -= 100;
			UnitConfiguration.Loadout.Stats.Shields -= 100;
			UnitConfiguration.Loadout.Stats.ShieldsArmor -= 100;
			UnitConfiguration.Loadout.Stats.CriticalChance -= 10;
			UnitConfiguration.Loadout.Stats.CriticalDamage -= 20;
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
			UnitConfiguration.Loadout.Stats.Attack += Attack;
			UnitConfiguration.Loadout.Stats.AttackSpeed += AttackSpeed;
			UnitConfiguration.Loadout.Stats.Health += Vitals;
			UnitConfiguration.Loadout.Stats.HealthArmor += Vitals;
			UnitConfiguration.Loadout.Stats.Shields += Vitals;
			UnitConfiguration.Loadout.Stats.ShieldsArmor += Vitals;
			UnitConfiguration.Loadout.Stats.DamageIncrease += DamageIncrease;
			UnitConfiguration.Loadout.Stats.UpdateDamageReduction("Rank", DamageReduction);
			UnitConfiguration.Loadout.Stats.CooldownReduction += Speed;
			UnitConfiguration.Loadout.Stats.MoveSpeed += Speed;
			UnitConfiguration.Loadout.Stats.Rank = Rank;

			ActivateMegaBuffs();
			ActivateGodBuffs();
			ActivateDivineBuffs();
			ActivateOmegaBuffs();
			ActivateVoidBuffs();
		}

		#endregion

		#region Deactivate

		public override void DeactivateRank()
		{
			UnitConfiguration.Loadout.Stats.Attack -= Attack;
			UnitConfiguration.Loadout.Stats.AttackSpeed -= AttackSpeed;
			UnitConfiguration.Loadout.Stats.Health -= Vitals;
			UnitConfiguration.Loadout.Stats.HealthArmor -= Vitals;
			UnitConfiguration.Loadout.Stats.Shields -= Vitals;
			UnitConfiguration.Loadout.Stats.ShieldsArmor -= Vitals;
			UnitConfiguration.Loadout.Stats.DamageIncrease -= DamageIncrease;
			UnitConfiguration.Loadout.Stats.UpdateDamageReduction("Rank", -DamageReduction);
			UnitConfiguration.Loadout.Stats.CooldownReduction -= Speed;
			UnitConfiguration.Loadout.Stats.MoveSpeed -= Speed;
			UnitConfiguration.Loadout.Stats.Rank = Rank;

			DeactivateMegaBuffs();
			DeactivateGodBuffs();
			DeactivateDivineBuffs();
			DeactivateOmegaBuffs();
			DeactivateVoidBuffs();
		}

		#endregion
	}
}
