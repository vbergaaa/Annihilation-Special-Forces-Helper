using System;
using System.Collections.Generic;
using System.Text;
using VEntityFramework.Model;

namespace VBusiness.Ranks
{
	public abstract class Rank : VRank
	{
		#region New

		public static VRank New(UnitRank rank)
		{
			return rank switch
			{
				(UnitRank.None) => new EmptyRank(),
				(UnitRank.D) => new RankD(),
				(UnitRank.C) => new RankC(),
				(UnitRank.B) => new RankB(),
				(UnitRank.A) => new RankA(),
				(UnitRank.S) => new RankS(),
				(UnitRank.SD) => new RankSD(),
				(UnitRank.SC) => new RankSC(),
				(UnitRank.SB) => new RankSB(),
				(UnitRank.SA) => new RankSA(),
				(UnitRank.SS) => new RankSS(),
				(UnitRank.SSD) => new RankSSD(),
				(UnitRank.SSC) => new RankSSC(),
				(UnitRank.SSB) => new RankSSB(),
				(UnitRank.SSA) => new RankSSA(),
				(UnitRank.SSS) => new RankSSS(),
				(UnitRank.X) => new RankX(),
				(UnitRank.SX) => new RankSX(),
				(UnitRank.SSX) => new RankSSX(),
				(UnitRank.SSSX) => new RankSSSX(),
				(UnitRank.XX) => new RankXX(),
				(UnitRank.XD) => new RankXD(),
				(UnitRank.SXD) => new RankSXD(),
				(UnitRank.Z) => new RankZ(),
				(UnitRank.SZ) => new RankSZ(),
				(UnitRank.SSZ) => new RankSSZ(),
				(UnitRank.SSSZ) => new RankSSSZ(),
				(UnitRank.XZ) => new RankXZ(),
				(UnitRank.XDZ) => new RankXDZ(),
				(UnitRank.SXDZ) => new RankSXDZ(),
				(UnitRank.XYZ) => new RankXYZ(),
				_ => null,
			};
		}

		#endregion

		#region Buffs

		public override Action<VStats> ActivateMegaBuff => (stats) => { };
		public override Action<VStats> ActivateSuperMegaBuff => (stats) => { };
		public override Action<VStats> ActivateGodBuff
		{
			get
			{
				return (stats) =>
				{
					stats.CriticalChance += 5;
					stats.CriticalDamage += 10;
				};
			}
		}
		public override Action<VStats> ActivateSuperGodBuff
		{
			get
			{
				return (stats) =>
				{
					stats.CriticalChance += 10;
					stats.CriticalDamage += 20;
				};
			}
		}
		public override Action<VStats> ActivateDivineBuff => (stats) => { };

		public override Action<VStats> ActivateSuperDivineBuff => (stats) => { };

		public override Action<VStats> ActivateOmegaBuff
		{
			get
			{
				return (stats) =>
				{
					stats.Attack += 50;
					stats.AttackSpeed += 50;
					stats.Health += 50;
					stats.HealthArmor += 50;
					stats.Shields += 50;
					stats.ShieldsArmor += 50;
					stats.CriticalChance += 5;
					stats.CriticalDamage += 10;
				};
			}
		}

		public override Action<VStats> ActivateSuperOmegaBuff
		{
			get
			{
				return (stats) =>
				{
					stats.Attack += 100;
					stats.AttackSpeed += 100;
					stats.Health += 100;
					stats.HealthArmor += 100;
					stats.Shields += 100;
					stats.ShieldsArmor += 100;
					stats.CriticalChance += 10;
					stats.CriticalDamage += 20;
				};
			}
		}

		public override Action<VStats> ActivateQuasarBuff => (stats) => { };
		public override Action<VStats> ActivateVoidBuff => (stats) => { };

		public override Action<VStats> DeactivateMegaBuff => (stats) => { };
		public override Action<VStats> DeactivateSuperMegaBuff => (stats) => { };
		public override Action<VStats> DeactivateDivineBuff => (stats) => { };
		public override Action<VStats> DeactivateSuperDivineBuff => (stats) => { }; 
		public override Action<VStats> DeactivateGodBuff
		{
			get
			{
				return (stats) =>
				{
					stats.CriticalChance -= 5;
					stats.CriticalDamage -= 10;
				};
			}
		}

		public override Action<VStats> DeactivateSuperGodBuff
		{
			get
			{
				return (stats) =>
				{
					stats.CriticalChance -= 10;
					stats.CriticalDamage -= 20;
				};
			}
		}

		public override Action<VStats> DeactivateOmegaBuff
		{
			get
			{
				return (stats) =>
				{
					stats.Attack -= 50;
					stats.AttackSpeed -= 50;
					stats.Health -= 50;
					stats.HealthArmor -= 50;
					stats.Shields -= 50;
					stats.ShieldsArmor -= 50;
					stats.CriticalChance -= 5;
					stats.CriticalDamage -= 10;
				};
			}
		}

		public override Action<VStats> DeactivateSuperOmegaBuff
		{
			get
			{
				return (stats) =>
				{
					stats.Attack -= 100;
					stats.AttackSpeed -= 100;
					stats.Health -= 100;
					stats.HealthArmor -= 100;
					stats.Shields -= 100;
					stats.ShieldsArmor -= 100;
					stats.CriticalChance -= 10;
					stats.CriticalDamage -= 20;
				};
			}
		}
		public override Action<VStats> DeactivateQuasarBuff => (stats) => { };
		public override Action<VStats> DeactivateVoidBuff => (stats) => { };

		#endregion

		#region Activate / Deactivate

		public override Action<VStats> ActivateRank
		{
			get
			{
				return (stats) =>
				{
					stats.Attack += Attack;
					stats.AttackSpeed += AttackSpeed;
					stats.Health += Vitals;
					stats.HealthArmor += Vitals;
					stats.Shields += Vitals;
					stats.ShieldsArmor += Vitals;
					stats.DamageIncrease += DamageIncrease;
					stats.DamageReduction += DamageReduction;
					stats.CooldownReduction += Speed;
					stats.MoveSpeed += Speed;
					stats.Rank = Rank;

					ActivateMegaBuffs(stats);
					ActivateGodBuffs(stats);
					ActivateDivineBuffs(stats);
					ActivateOmegaBuffs(stats);
					ActivateVoidBuffs(stats);
				};
			}
		}

		void ActivateGodBuffs(VStats stats)
		{
			if (Rank >= UnitRank.SX)
			{
				if (Rank >= UnitRank.SSSX)
				{
					ActivateSuperGodBuff(stats);
				}
				else
				{
					ActivateGodBuff(stats);
				}
			}
		}

		void ActivateDivineBuffs(VStats stats)
		{
			if (Rank >= UnitRank.SXD)
			{
				if (Rank >= UnitRank.SZ)
				{
					ActivateSuperDivineBuff(stats);
				}
				else
				{
					ActivateDivineBuff(stats);
				}
			}
		}

		void ActivateOmegaBuffs(VStats stats)
		{
			if (Rank >= UnitRank.XZ)
			{
				if (Rank >= UnitRank.XDZ)
				{
					ActivateSuperOmegaBuff(stats);
				}
				else
				{
					ActivateOmegaBuff(stats);
				}
			}
		}

		void ActivateVoidBuffs(VStats stats)
		{
			if (Rank >= UnitRank.SXDZ)
			{
				if (Rank >= UnitRank.XYZ)
				{
					ActivateVoidBuff(stats);
				}
				else
				{
					ActivateQuasarBuff(stats);
				}
			}
		}

		private void ActivateMegaBuffs(VStats stats)
		{
			if (Rank >= UnitRank.SS)
			{
				if (Rank >= UnitRank.SSS)
				{
					ActivateSuperMegaBuff(stats);
				}
				else
				{
					ActivateMegaBuff(stats);
				}
			}
		}

		public override Action<VStats> DeactivateRank
		{
			get
			{
				return (stats) =>
				{
					stats.Attack -= Attack;
					stats.AttackSpeed -= AttackSpeed;
					stats.Health -= Vitals;
					stats.HealthArmor -= Armor;
					stats.Shields -= Vitals;
					stats.ShieldsArmor -= Armor;
					stats.DamageIncrease -= DamageIncrease;
					stats.DamageReduction -= DamageReduction;
					stats.CooldownReduction -= Speed;
					stats.MoveSpeed -= Speed;

					DeactivateMegaBuffs(stats);
					DeactivateGodBuffs(stats);
					DeactivateDivineBuffs(stats);
					DeactivateOmegaBuffs(stats);
					DeactivateVoidBuffs(stats);
				};
			}
		}

		void DeactivateGodBuffs(VStats stats)
		{
			if (Rank >= UnitRank.SX)
			{
				if (Rank >= UnitRank.SSSX)
				{
					DeactivateSuperGodBuff(stats);
				}
				else
				{
					DeactivateGodBuff(stats);
				}
			}
		}

		void DeactivateDivineBuffs(VStats stats)
		{
			if (Rank >= UnitRank.SXD)
			{
				if (Rank >= UnitRank.SZ)
				{
					DeactivateSuperDivineBuff(stats);
				}
				else
				{
					DeactivateDivineBuff(stats);
				}
			}
		}

		void DeactivateOmegaBuffs(VStats stats)
		{
			if (Rank >= UnitRank.XZ)
			{
				if (Rank >= UnitRank.XDZ)
				{
					DeactivateSuperOmegaBuff(stats);
				}
				else
				{
					DeactivateOmegaBuff(stats);
				}
			}
		}

		void DeactivateVoidBuffs(VStats stats)
		{
			if (Rank >= UnitRank.SXDZ)
			{
				if (Rank >= UnitRank.XYZ)
				{
					DeactivateVoidBuff(stats);
				}
				else
				{
					DeactivateQuasarBuff(stats);
				}
			}
		}

		private void DeactivateMegaBuffs(VStats stats)
		{
			if (Rank >= UnitRank.SS)
			{
				if (Rank >= UnitRank.SSS)
				{
					DeactivateSuperMegaBuff(stats);
				}
				else
				{
					DeactivateMegaBuff(stats);
				}
			}
		}

		#endregion
	}
}
