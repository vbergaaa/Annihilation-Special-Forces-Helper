using System;
using System.Collections.Generic;
using System.Text;
using VEntityFramework.Model;

namespace VBusiness.Units
{
	public class Striker : Unit
	{
		public override Evolution Evolution => Evolution.Basic;

		public override VEntityFramework.Model.Unit BaseUnit => VEntityFramework.Model.Unit.Striker;

		public override bool IsHidden => throw new NotImplementedException();

		public override int BaseMineralCost => 4000;
	}
}
