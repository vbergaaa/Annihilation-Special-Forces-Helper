using System;
using System.Collections.Generic;
using System.Text;
using VEntityFramework.Model;

namespace VBusiness.Ranks
{
	public abstract class Rank : VRank
	{
		#region Buffs

		public override Action<VStats> ActivateMegaBuff => null;
		public override Action<VStats> ActivateSuperMegaBuff => null;
		public override Action<VStats> ActivateGodBuff => null;
		public override Action<VStats> ActivateSuperGodBuff => null;
		public override Action<VStats> ActivateDivineBuff
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

		public override Action<VStats> ActivateSuperDivineBuff
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

		public override Action<VStats> ActivateQuasarBuff => null;
		public override Action<VStats> ActivateVoidBuff => null;

		public override Action<VStats> DeactivateMegaBuff => null;
		public override Action<VStats> DeactivateSuperMegaBuff => null;
		public override Action<VStats> DeactivateGodBuff => null;
		public override Action<VStats> DeactivateSuperGodBuff => null; public override Action<VStats> DeactivateDivineBuff
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

		public override Action<VStats> DeactivateSuperDivineBuff
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
		public override Action<VStats> DeactivateQuasarBuff => null;
		public override Action<VStats> DeactivateVoidBuff => null;

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
