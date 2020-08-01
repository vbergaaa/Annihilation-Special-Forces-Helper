using System;
using System.Collections.Generic;
using System.Text;
using VEntityFramework.Model;

namespace VBusiness.Souls
{
	public class TitanSoul : Soul
	{
		public override SoulType Type => SoulType.Titan;

		protected override int MaxAttack => throw new NotImplementedException();

		protected override int MinAttack => throw new NotImplementedException();

		protected override int MaxAttackSpeed => throw new NotImplementedException();

		protected override int MinAttackSpeed => throw new NotImplementedException();

		protected override int MaxCriticalChance => throw new NotImplementedException();

		protected override int MinCriticalChance => throw new NotImplementedException();

		protected override int MaxCriticalDamage => throw new NotImplementedException();

		protected override int MinCriticalDamage => throw new NotImplementedException();

		protected override int MaxVitals => throw new NotImplementedException();

		protected override int MinVitals => throw new NotImplementedException();

		protected override int MaxArmor => throw new NotImplementedException();

		protected override int MinArmor => throw new NotImplementedException();

		protected override int MaxMinerals => throw new NotImplementedException();

		protected override int MinMinerals => throw new NotImplementedException();

		protected override int MaxKills => throw new NotImplementedException();

		protected override int MinKills => throw new NotImplementedException();
	}
}
