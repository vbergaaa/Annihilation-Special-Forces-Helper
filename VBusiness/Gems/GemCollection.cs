using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using VEntityFramework.Model;

namespace VBusiness.Gems
{
	public class GemCollection : VGemCollection
	{
		public GemCollection()
		{
			LoadGems();
		}

		void LoadGems()
		{
			_ = Gems;
		}

		#region Properties

		#region Attack

		public override VGem AttackGem
		{
			get => fAttackGem ?? (fAttackGem = new AttackGem());
		}
		VGem fAttackGem;

		#endregion

		#region AttackSpeed

		public override VGem AttackSpeedGem
		{
			get => fAttackSpeedGem ?? (fAttackSpeedGem = new AttackSpeedGem());
		}
		VGem fAttackSpeedGem;

		#endregion

		#region Health

		public override VGem HealthGem
		{
			get => fHealthGem ?? (fHealthGem = new HealthGem());
		}
		VGem fHealthGem;

		#endregion

		#region HealthArmor

		public override VGem HealthArmorGem
		{
			get => fHealthArmorGem ?? (fHealthArmorGem = new HealthArmorGem());
		}
		VGem fHealthArmorGem;

		#endregion

		#region Shields

		public override VGem ShieldsGem
		{
			get => fShieldsGem ?? (fShieldsGem = new ShieldsGem());
		}
		VGem fShieldsGem;

		#endregion

		#region ShieldsArmor

		public override VGem ShieldsArmorGem
		{
			get => fShieldsArmorGem ?? (fShieldsArmorGem = new ShieldsArmorGem());
		}
		VGem fShieldsArmorGem;

		#endregion

		#region CriticalChance

		public override VGem CriticalChanceGem
		{
			get => fCriticalChanceGem ?? (fCriticalChanceGem = new CriticalChanceGem());
		}
		VGem fCriticalChanceGem;

		#endregion

		#region CriticalDamage

		public override VGem CriticalDamageGem
		{
			get => fCriticalDamageGem ?? (fCriticalDamageGem = new CriticalDamageGem());
		}
		VGem fCriticalDamageGem;

		#endregion

		#region DoubleWarp

		public override VGem DoubleWarpGem
		{
			get => fDoubleWarpGem ?? (fDoubleWarpGem = new DoubleWarpGem());
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
						CriticalChanceGem,
						CriticalDamageGem,
						DoubleWarpGem
					};

					foreach (var gem in fGems)
					{
						gem.GemLevelChanged += OnGemCollectionLevelUpdated;
					}
				}

				return fGems;
			}
		}
		VGem[] fGems;

		#endregion

		#endregion

	}
}
