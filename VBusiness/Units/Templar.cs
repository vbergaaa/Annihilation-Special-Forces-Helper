using System;
using System.Collections.Generic;
using System.Text;
using VEntityFramework.Model;

namespace VBusiness.Units
{
	public class Templar : Unit
	{
		public override VEntityFramework.Model.Unit BaseUnit => VEntityFramework.Model.Unit.Templar;

		public override bool IsHidden => false;

		public override Evolution Evolution => Evolution.Basic;

		public override int BaseMineralCost => 20000;
	}
}
