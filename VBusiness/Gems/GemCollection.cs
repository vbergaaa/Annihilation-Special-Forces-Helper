using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using VEntityFramework.Model;

namespace VBusiness.Gems
{
	public class GemCollection : VGemCollection
	{
		#region Constructor

		public GemCollection(VLoadout loadout) : base(loadout)
		{
		}

		#endregion

		#region Properties

		#region Attack

		public override VGem AttackGem
		{
			get => fAttackGem ?? (fAttackGem = new AttackGem(this));
		}
		VGem fAttackGem;

		#endregion

		#region AttackSpeed

		public override VGem AttackSpeedGem
		{
			get => fAttackSpeedGem ?? (fAttackSpeedGem = new AttackSpeedGem(this));
		}
		VGem fAttackSpeedGem;

		#endregion

		#region Health

		public override VGem HealthGem
		{
			get => fHealthGem ?? (fHealthGem = new HealthGem(this));
		}
		VGem fHealthGem;

		#endregion

		#region HealthArmor

		public override VGem HealthArmorGem
		{
			get => fHealthArmorGem ?? (fHealthArmorGem = new HealthArmorGem(this));
		}
		VGem fHealthArmorGem;

		#endregion

		#region Shields

		public override VGem ShieldsGem
		{
			get => fShieldsGem ?? (fShieldsGem = new ShieldsGem(this));
		}
		VGem fShieldsGem;

		#endregion

		#region ShieldsArmor

		public override VGem ShieldsArmorGem
		{
			get => fShieldsArmorGem ?? (fShieldsArmorGem = new ShieldsArmorGem(this));
		}
		VGem fShieldsArmorGem;

		#endregion

		#region CriticalChance

		public override VGem CritChanceGem
		{
			get => fCriticalChanceGem ?? (fCriticalChanceGem = new CriticalChanceGem(this));
		}
		VGem fCriticalChanceGem;

		#endregion

		#region CriticalDamage

		public override VGem CritDamageGem
		{
			get => fCriticalDamageGem ?? (fCriticalDamageGem = new CriticalDamageGem(this));
		}
		VGem fCriticalDamageGem;

		#endregion

		#region DoubleWarp

		public override VGem DoubleWarpGem
		{
			get => fDoubleWarpGem ?? (fDoubleWarpGem = new DoubleWarpGem(this));
		}
		VGem fDoubleWarpGem;

		#endregion

		#region Gems

		public override VGem[] Gems
		{
			get
			{
				if (fGems == null)
				{
					fGems = new VGem[] {
						AttackGem,
						AttackSpeedGem,
						ShieldsGem,
						ShieldsArmorGem,
						HealthGem,
						HealthArmorGem,
						CritChanceGem,
						CritDamageGem,
						DoubleWarpGem
					};
				}
				return fGems;
			}
		}
		VGem[] fGems;

		#endregion

		#endregion
	}
}
