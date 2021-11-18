using VBusiness.HelperClasses;
using VEntityFramework.Model;

namespace VBusiness.Enemies
{
	public class Bruta3 : Bruta
	{
		public override EnemyType EnemyType => EnemyType.Bruta3;
		public override EnemyQuantity BrutaSpawns => new(EnemyType.Hydralisk, 10);
	}
}
