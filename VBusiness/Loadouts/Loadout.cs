using System.Buffers.Text;
using VBusiness.Gems;
using VBusiness.Perks;
using VBusiness.Souls;
using VEntityFramework;
using VEntityFramework.Model;

namespace VBusiness.Loadouts
{
	public class Loadout : VLoadout
	{
		public Loadout()
		{
		}

		protected override void SetDefaultValues()
		{
			Stats = new Stats();
			UnitConfiguration = new UnitConfiguration();
		}

		public override VGemCollection Gems
		{
			get => base.Gems ?? (base.Gems = new GemCollection(this));
			set => base.Gems = value;
		}

		public override VPerkCollection Perks
		{
			get => base.Perks ?? (base.Perks = new PerkCollection(this));
			set => base.Perks = value;
		}

		public override VSoulCollection Souls
		{
			get => base.Souls ?? (base.Souls = new SoulCollection(this));
			set => base.Souls = value;
		}

		public override VUnitConfiguration UnitConfiguration
		{
			get => base.UnitConfiguration;
			set
			{
				UnHookRankStats();
				base.UnitConfiguration = value;
				HookRankStats();
			}
		}

		void UpdateStats(object sender, StatsEventArgs e)
		{
			e.Modification(Stats);
		}

		void UnHookRankStats()
		{
			if (UnitConfiguration != null)
			{
				UnitConfiguration.OnRankChanged -= UpdateStats;
			}
		}

		void HookRankStats()
		{
			if (UnitConfiguration != null)
			{
				UnitConfiguration.OnRankChanged += UpdateStats;
			}
		}

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
	}
}
