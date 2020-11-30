using System;
using System.Collections.Generic;
using System.Text;
using VEntityFramework.Model;

namespace VBusiness.Units
{
	public class DarkShadow : Unit
	{
		public override Evolution Evolution => Evolution.Basic;

		public override VEntityFramework.Model.Unit BaseUnit => VEntityFramework.Model.Unit.DarkShadow;

		public override bool IsHidden => false;

		public override int BaseMineralCost => 2000;
	}
}
