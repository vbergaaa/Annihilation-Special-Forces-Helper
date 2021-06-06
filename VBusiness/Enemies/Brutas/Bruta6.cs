using VBusiness.HelperClasses;
using VEntityFramework.Model;

namespace VBusiness.Enemies
{
	public class Bruta6 : Bruta
	{
		public override EnemyType EnemyType => EnemyType.Bruta6;
		public override EnemyQuantity BrutaSpawns => new EnemyQuantity(EnemyType.Infestor, 10);
	}
}
