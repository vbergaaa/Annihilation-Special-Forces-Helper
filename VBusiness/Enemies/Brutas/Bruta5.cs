using VBusiness.HelperClasses;
using VEntityFramework.Model;

namespace VBusiness.Enemies
{
	public class Bruta5 : Bruta
	{
		public override EnemyType EnemyType => EnemyType.Bruta5;
		public override EnemyQuantity BrutaSpawns => new(EnemyType.GiantAbberation, 20);
	}
}
