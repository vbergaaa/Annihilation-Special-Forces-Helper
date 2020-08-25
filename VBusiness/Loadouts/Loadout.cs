﻿using System.Buffers.Text;
using VBusiness.Gems;
using VBusiness.Perks;
using VBusiness.Souls;
using VEntityFramework;
using VEntityFramework.Model;

namespace VBusiness.Loadouts
{
	public class Loadout : VLoadout
	{
		#region Constructor

		public Loadout()
		{
		}

		#endregion

		#region Properties

		#region Gems

		public override VGemCollection Gems
		{
			get => base.Gems ?? (base.Gems = new GemCollection(this));
			set => base.Gems = value;
		}

		#endregion

		#region Perks

		public override VPerkCollection Perks
		{
			get => base.Perks ?? (base.Perks = new PerkCollection(this));
			set => base.Perks = value;
		}

		#endregion

		#region Souls

		public override VSoulCollection Souls
		{
			get => base.Souls ?? (base.Souls = new SoulCollection(this));
			set => base.Souls = value;
		}

		#endregion

		#region UnitConfiguration

		public override VUnitConfiguration UnitConfiguration
		{
			get => base.UnitConfiguration ?? (base.UnitConfiguration = new UnitConfiguration(this));
			set => base.UnitConfiguration = value;
		}

		#endregion

		#endregion

		#region Validation

		protected override void RunPreSaveValidationCore()
		{
			base.RunPreSaveValidationCore();

			CheckLoadoutName();
			CheckSlotNumber();
		}

		void CheckSlotNumber()
		{
			if (Slot <= 0)
			{
				Notifications.AddError("Please enter a Save slot that is greater than 0.");
			}
		}

		void CheckLoadoutName()
		{
			if (Name == "")
			{
				Notifications.AddError("Please enter a name for this loadout.");
			}
		}

		#endregion

		#region Implementation

		protected override void SetDefaultValuesCore()
		{
			Stats = new Stats();
		}

		#endregion
	}
}
