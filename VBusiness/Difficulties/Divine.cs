using System;
using System.Collections.Generic;
using System.Text;
using VEntityFramework.Model;

namespace VBusiness.Difficulties
{
	public class Divine : Difficulty
	{
		public override DifficultyLevel Difficulty => throw new NotImplementedException();

		public override int TormentReduction => 15;
	}
}
