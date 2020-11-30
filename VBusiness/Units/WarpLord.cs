using VEntityFramework.Model;

namespace VBusiness.Units
{
	public class WarpLord : Unit
	{
		public override VEntityFramework.Model.Unit BaseUnit => VEntityFramework.Model.Unit.WarpLord;

		public override bool IsHidden => false;

		public override Evolution Evolution => Evolution.Basic;

		public override int BaseMineralCost => 2000;
	}
}
