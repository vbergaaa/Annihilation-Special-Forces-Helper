using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using VEntityFramework.Model;

namespace VBusiness.Gems
{
	public class GemCollection : VGemCollection
	{
		#region Gems

		#region Attack

		public override VGem AttackGem
		{
			get => fAttackGem ?? (fAttackGem = new AttackGem());
			set => fAttackGem = value;
		}
		VGem fAttackGem;

		#endregion

		#region AttackSpeed

		public override VGem AttackSpeedGem
		{
			get => fAttackSpeedGem ?? (fAttackSpeedGem = new AttackSpeedGem());
			set => fAttackSpeedGem = value;
		}
		VGem fAttackSpeedGem;

		#endregion

		#region Health

		public override VGem HealthGem
		{
			get => fHealthGem ?? (fHealthGem = new HealthGem());
			set => fHealthGem = value;
		}
		VGem fHealthGem;

		#endregion

		#region HealthArmor

		public override VGem HealthArmorGem
		{
			get => fHealthArmorGem ?? (fHealthArmorGem = new HealthArmorGem());
			set => fHealthArmorGem = value;
		}
		VGem fHealthArmorGem;

		#endregion

		#region Shields

		public override VGem ShieldGem
		{
			get => fShieldsGem ?? (fShieldsGem = new ShieldsGem());
			set => fShieldsGem = value;
		}
		VGem fShieldsGem;

		#endregion

		#region ShieldsArmor

		public override VGem ShieldArmorGem
		{
			get => fShieldsArmorGem ?? (fShieldsArmorGem = new ShieldsArmorGem());
			set => fShieldsArmorGem = value;
		}
		VGem fShieldsArmorGem;

		#endregion

		#region CriticalChance

		public override VGem CriticalChanceGem
		{
			get => fCriticalChanceGem ?? (fCriticalChanceGem = new CriticalChanceGem());
			set => fCriticalChanceGem = value;
		}
		VGem fCriticalChanceGem;

		#endregion

		#region CriticalDamage

		public override VGem CriticalDamageGem
		{
			get => fCriticalDamageGem ?? (fCriticalDamageGem = new CriticalDamageGem());
			set => fCriticalDamageGem = value;
		}
		VGem fCriticalDamageGem;

		#endregion

		#region DoubleWarp

		public override VGem DoubleWarpGem
		{
			get => fDoubleWarpGem ?? (fDoubleWarpGem = new DoubleWarpGem());
			set => fDoubleWarpGem = value;
		}
		VGem fDoubleWarpGem;

		#endregion

		#endregion

		public override VGem[] Gems
		{
			get
			{
				if (fGems == null)
				{
					fGems = new VGem[] {
						AttackGem,
						AttackSpeedGem,
						ShieldGem,
						ShieldArmorGem,
						HealthGem,
						HealthArmorGem,
						CriticalChanceGem,
						CriticalDamageGem,
						DoubleWarpGem
					};
				}
				return fGems;
			}
		}
		VGem[] fGems;
	}
}
