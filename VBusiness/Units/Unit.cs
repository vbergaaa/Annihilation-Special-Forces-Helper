using System;
using VBusiness.HelperClasses;
using VEntityFramework.Model;

namespace VBusiness.Units
{
	public abstract class Unit : VUnit
	{
		#region New

		public static Unit New(VEntityFramework.Model.Unit unitType)
		{
			return unitType switch
			{
				VEntityFramework.Model.Unit.WarpLord => new WarpLord(),
				VEntityFramework.Model.Unit.Probe => new Probe(),
				VEntityFramework.Model.Unit.ShieldBattery => new ShieldBattery(),
				VEntityFramework.Model.Unit.Striker => new Striker(),
				VEntityFramework.Model.Unit.DarkShadow => new DarkShadow(),
				VEntityFramework.Model.Unit.LightAdept => new LightAdept(),
				VEntityFramework.Model.Unit.Dreadnought => new Dreadnought(),
				VEntityFramework.Model.Unit.Templar => new Templar(),
				_ => throw new NotImplementedException("Unit cannot be create via Unit.Create(unit) yet")
			};
		}

		#endregion

		#region Costs

		public override int MineralCost => this.GetMineralCost();
		public override int KillCost => this.GetKillCost();

		#endregion

		#region Infusion

		public override int Infusion
		{
			get => fHasInfusionBeenSetManually ? fInfusion : 0;
			set
			{
				fInfusion = value;
				fHasInfusionBeenSetManually = true;
			}
		}
		int fInfusion;
		bool fHasInfusionBeenSetManually;

		#endregion
	}
}
