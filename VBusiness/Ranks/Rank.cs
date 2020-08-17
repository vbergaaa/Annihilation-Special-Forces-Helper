using System;
using System.Collections.Generic;
using System.Text;
using VEntityFramework.Model;

namespace VBusiness.Ranks
{
	public abstract class Rank : VRank
	{
		#region Constructor

		public Rank(VUnitConfiguration config) : base(config)
		{
		}

		#endregion

		#region New

		public static VRank New(UnitRank rank, VUnitConfiguration config)
		{
			return rank switch
			{
				UnitRank.None => new EmptyRank(config),
				UnitRank.D => new RankD(config),
				UnitRank.C => new RankC(config),
				UnitRank.B => new RankB(config),
				UnitRank.A => new RankA(config),
				UnitRank.S => new RankS(config),
				UnitRank.SD => new RankSD(config),
				UnitRank.SC => new RankSC(config),
				UnitRank.SB => new RankSB(config),
				UnitRank.SA => new RankSA(config),
				UnitRank.SS => new RankSS(config),
				UnitRank.SSD => new RankSSD(config),
				UnitRank.SSC => new RankSSC(config),
				UnitRank.SSB => new RankSSB(config),
				UnitRank.SSA => new RankSSA(config),
				UnitRank.SSS => new RankSSS(config),
				UnitRank.X => new RankX(config),
				UnitRank.SX => new RankSX(config),
				UnitRank.SSX => new RankSSX(config),
				UnitRank.SSSX => new RankSSSX(config),
				UnitRank.XX => new RankXX(config),
				UnitRank.XD => new RankXD(config),
				UnitRank.SXD => new RankSXD(config),
				UnitRank.Z => new RankZ(config),
				UnitRank.SZ => new RankSZ(config),
				UnitRank.SSZ => new RankSSZ(config),
				UnitRank.SSSZ => new RankSSSZ(config),
				UnitRank.XZ => new RankXZ(config),
				UnitRank.XDZ => new RankXDZ(config),
				UnitRank.SXDZ => new RankSXDZ(config),
				UnitRank.XYZ => new RankXYZ(config),
				_ => null,
			};
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
			if (Rank >= UnitRank.SS)
			{
				if (Rank >= UnitRank.SSS)
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
			if (Rank >= UnitRank.SX)
			{
				if (Rank >= UnitRank.SSSX)
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
			if (Rank >= UnitRank.SXD)
			{
				if (Rank >= UnitRank.SZ)
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
			if (Rank >= UnitRank.XZ)
			{
				if (Rank >= UnitRank.XDZ)
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
			if (Rank >= UnitRank.SXDZ)
			{
				ActivateQuasarBuff();
			}
			if (Rank >= UnitRank.XYZ)
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
			if (Rank >= UnitRank.SS)
			{
				if (Rank >= UnitRank.SSS)
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
			if (Rank >= UnitRank.SX)
			{
				if (Rank >= UnitRank.SSSX)
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
			if (Rank >= UnitRank.SXD)
			{
				if (Rank >= UnitRank.SZ)
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
			if (Rank >= UnitRank.XZ)
			{
				if (Rank >= UnitRank.XDZ)
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
			if (Rank >= UnitRank.SXDZ)
			{
				DeactivateQuasarBuff();
			}
			if (Rank >= UnitRank.XYZ)
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
			UnitConfiguration.Loadout.Stats.DamageReduction += DamageReduction;
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
			UnitConfiguration.Loadout.Stats.DamageReduction -= DamageReduction;
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
