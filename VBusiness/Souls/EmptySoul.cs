using System;
using System.Collections.Generic;
using System.Text;
using VEntityFramework.Model;

namespace VBusiness.Souls
{
	public sealed class EmptySoul : Soul
	{
		public EmptySoul() : base(null)
		{
		}

		public override SoulType Type => SoulType.None;

		protected sealed override SoulType Rarity => SoulType.None;

		public override int MaxAttack => 0;

		public override int MinAttack => 0;

		public override int MaxAttackSpeed => 0;

		public override int MinAttackSpeed => 0;

		public override int MaxCriticalChance => 0;

		public override int MinCriticalChance => 0;

		public override int MaxCriticalDamage => 0;

		public override int MinCriticalDamage => 0;

		public override int MaxVitals => 0;

		public override int MinVitals => 0;

		public override int MaxArmor => 0;

		public override int MinArmor => 0;

		public override int MaxMinerals => 0;

		public override int MinMinerals => 0;

		public override int MaxKills => 0;

		public override int MinKills => 0;

		protected override void RunPreSaveValidationCore()
		{
			Notifications.AddError("Cannot save an empty soul - Please change the soul type");
			base.RunPreSaveValidationCore();
		}
	}
}
