using System;
using System.Collections.Generic;
using System.Text;

namespace VBusiness.Units
{
	public class ShieldBattery : Unit
	{
		public override VEntityFramework.Model.Unit BaseUnit => VEntityFramework.Model.Unit.ShieldBattery;

		public override bool IsHidden => false;

		public override VEntityFramework.Model.Evolution Evolution => VEntityFramework.Model.Evolution.Basic;
		
		public override int BaseMineralCost => 2250;
	}
}
