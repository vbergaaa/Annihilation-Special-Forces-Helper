using System;
using System.Collections.Generic;
using System.Text;
using VEntityFramework.Model;

namespace VBusiness.Units
{
	public class Dreadnought : Unit
	{
		public override Evolution Evolution => Evolution.Basic;

		public override VEntityFramework.Model.Unit BaseUnit => VEntityFramework.Model.Unit.Dreadnought;

		public override bool IsHidden => false;

		public override int BaseMineralCost => 8000;
	}
}
