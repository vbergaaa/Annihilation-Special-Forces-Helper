using System;
using System.Collections.Generic;
using System.Text;
using VEntityFramework.Model;

namespace VBusiness.Souls
{
	public sealed class EmptySoul : Soul
	{
		public override SoulType Type => SoulType.None;

		protected sealed override SoulType Rarity => SoulType.None;

		protected override int MaxAttack => 0;

		protected override int MinAttack => 0;

		protected override int MaxAttackSpeed => 0;

		protected override int MinAttackSpeed => 0;

		protected override int MaxCriticalChance => 0;

		protected override int MinCriticalChance => 0;

		protected override int MaxCriticalDamage => 0;

		protected override int MinCriticalDamage => 0;

		protected override int MaxVitals => 0;

		protected override int MinVitals => 0;

		protected override int MaxArmor => 0;

		protected override int MinArmor => 0;

		protected override int MaxMinerals => 0;

		protected override int MinMinerals => 0;

		protected override int MaxKills => 0;

		protected override int MinKills => 0;

		public override void RunPreSaveValidation()
		{
			Notifications.AddError("Cannot save an empty soul - Please change the soul type");
			base.RunPreSaveValidation();
		}
	}
}
