using System;
using System.Collections.Generic;
using System.Text;
using VBusiness.HelperClasses;
using VEntityFramework.Model;

namespace VBusiness.Enemies
{
	public class Bruta2 : Bruta
	{
		public override EnemyType EnemyType => EnemyType.Bruta2;
		public override EnemyQuantity BrutaSpawns => new EnemyQuantity(EnemyType.Roach, 10);
	}
}
