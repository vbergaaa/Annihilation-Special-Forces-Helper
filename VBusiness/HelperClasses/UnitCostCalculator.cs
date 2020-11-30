using System;
using System.Collections.Generic;
using System.Text;
using VEntityFramework.Model;

namespace VBusiness.HelperClasses
{
	public static class UnitCostCalculator
	{
		#region Mineral Costs

		public static int GetMineralCost(this VUnit unit)
		{
			if (unit.IsHidden)
			{
				throw new NotImplementedException("Mineral Costs of Hidden units have not been determined");
			}
			else if (unit.Evolution == Evolution.Basic)
			{
				return GetMineralCostOfBasicUnit(unit);
			}
			throw new NotImplementedException("Only mineral cost of Basic units have been implemented");
		}

		#region Basic Mineral Costs

		static int GetMineralCostOfBasicUnit(VUnit unit)
		{
			return GetMineralCostOfBasicUnit(unit.BaseMineralCost, unit.Infusion);
		}

		static int GetMineralCostOfBasicUnit(int baseCost, int infuse)
		{
			if (infuse <= 0)
			{
				return baseCost;
			}
			return GetMineralCostOfBasicUnit(baseCost, infuse - 1) + (baseCost * ((infuse + 1) / 2));
		}

		#endregion

		#endregion

		#region KillCosts

		public static int GetKillCost(this VUnit unit)
		{
			if (unit.IsHidden)
			{
				throw new NotImplementedException("Kill Costs of Hidden units have not been determined");
			}
			else if (unit.Evolution == Evolution.Basic)
			{
				return GetKillCostOfBasicUnit(unit.Infusion);
			}
			throw new NotImplementedException("Only kill cost of Basic units have been implemented");
		}

		#region Basic Kill Costs

		static int GetKillCostOfBasicUnit(int infuse)
		{
			if (infuse <= 0)
			{
				return 0;
			}
			return GetKillCostOfBasicUnit(infuse - 1) + (infuse * 200);
		}

		#endregion

		#endregion
	}
}
