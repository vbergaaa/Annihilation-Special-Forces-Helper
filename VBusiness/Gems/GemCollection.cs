﻿using System;
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
			get
			{
				if (fAttackGem == null)
				{
					fAttackGem = new AttackGem(this);
				}
				return fAttackGem;
			}
		}
		VGem fAttackGem;

		#endregion

		#region AttackSpeed

		public override VGem AttackSpeedGem
		{
			get
			{
				if (fAttackSpeedGem == null)
				{
					fAttackSpeedGem = new AttackSpeedGem(this);
				}
				return fAttackSpeedGem;
			}
		}
		VGem fAttackSpeedGem;

		#endregion

		#region Shields

		public override VGem ShieldsGem
		{
			get
			{
				if (fShieldsGem == null)
				{
					fShieldsGem = new ShieldsGem(this);
				}
				return fShieldsGem;
			}
		}
		VGem fShieldsGem;

		#endregion

		#region ShieldsArmor

		public override VGem ShieldsArmorGem
		{
			get
			{
				if (fShieldsArmorGem == null)
				{
					fShieldsArmorGem = new ShieldsArmorGem(this);
				}
				return fShieldsArmorGem;
			}
		}
		VGem fShieldsArmorGem;

		#endregion

		#region Health

		public override VGem HealthGem
		{
			get
			{
				if (fHealthGem == null)
				{
					fHealthGem = new HealthGem(this);
				}
				return fHealthGem;
			}
		}
		VGem fHealthGem;

		#endregion

		#region HealthArmor

		public override VGem HealthArmorGem
		{
			get
			{
				if (fHealthArmorGem == null)
				{
					fHealthArmorGem = new HealthArmorGem(this);
				}
				return fHealthArmorGem;
			}
		}
		VGem fHealthArmorGem;

		#endregion

		#region CritChance

		public override VGem CritChanceGem
		{
			get
			{
				if (fCritChanceGem == null)
				{
					fCritChanceGem = new CriticalChanceGem(this);
				}
				return fCritChanceGem;
			}
		}
		VGem fCritChanceGem;

		#endregion

		#region CritDamage

		public override VGem CritDamageGem
		{
			get
			{
				if (fCritDamageGem == null)
				{
					fCritDamageGem = new CriticalDamageGem(this);
				}
				return fCritDamageGem;
			}
		}
		VGem fCritDamageGem;

		#endregion

		#region DoubleWarp

		public override VGem DoubleWarpGem
		{
			get
			{
				if (fDoubleWarpGem == null)
				{
					fDoubleWarpGem = new DoubleWarpGem(this);
				}
				return fDoubleWarpGem;
			}
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

		#region RemainingGems

		public override int RemainingGems { get => Loadout.Profile.Gems - TotalCost; }

		#endregion

		#endregion
	}
}
