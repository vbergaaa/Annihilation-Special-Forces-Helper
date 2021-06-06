using System;
using System.Collections.Generic;
using System.Text;
using VBusiness.HelperClasses;
using VEntityFramework.Model;

namespace VBusiness.Enemies
{
	public class Bruta1 : Bruta
	{
		public override EnemyType EnemyType => EnemyType.Bruta1;
		public override EnemyQuantity BrutaSpawns => new EnemyQuantity(EnemyType.Zergling, 10);
	}
}
