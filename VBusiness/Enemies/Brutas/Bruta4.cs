using VBusiness.HelperClasses;
using VEntityFramework.Model;

namespace VBusiness.Enemies
{
	public class Bruta4 : Bruta
	{
		public override EnemyType EnemyType => EnemyType.Bruta4;
		public override EnemyQuantity BrutaSpawns => new(EnemyType.GiantAbberation, 10);
	}
}
