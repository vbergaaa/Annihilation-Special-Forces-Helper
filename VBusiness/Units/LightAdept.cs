using System;
using System.Collections.Generic;
using System.Text;
using VEntityFramework.Model;

namespace VBusiness.Units
{
	public class LightAdept : Unit
	{
		public override Evolution Evolution => Evolution.Basic;

		public override VEntityFramework.Model.Unit BaseUnit => VEntityFramework.Model.Unit.LightAdept;

		public override bool IsHidden => false;

		public override int BaseMineralCost => 5000;
	}
}
