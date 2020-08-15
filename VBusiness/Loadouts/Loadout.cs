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
			Perks = new PerkCollection(this);
			Gems = new GemCollection();
			Souls = new SoulCollection();
			UnitConfiguration = new UnitConfiguration();
		}

		public override VGemCollection Gems
		{
			get => base.Gems;
			set
			{
				UnHookGemStats();
				base.Gems = value;
				HookGemStats();
			}
		}

		public override VPerkCollection Perks
		{
			get => base.Perks;
			set
			{
				UnHookPerkStats();
				base.Perks = value;
				//HookPerkStats();
			}
		}

		public override VSoulCollection Souls
		{
			get => base.Souls;
			set
			{
				UnHookSoulStats();
				base.Souls = value;
				HookSoulStats();
			}
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

		void HookPerkStats()
		{
			if (Perks != null)
			{
				Perks.PerkLevelChanged += UpdateStats;
			}
		}

		void HookGemStats()
		{
			if (Gems != null)
			{
				Gems.GemCollectionLevelUpdated += UpdateStats;
			}
		}

		void UnHookPerkStats()
		{
			if (Perks != null)
			{
				Perks.PerkLevelChanged -= UpdateStats;
			}
		}

		void UnHookGemStats()
		{
			if (Gems != null)
			{
				Gems.GemCollectionLevelUpdated -= UpdateStats;
			}
		}

		void UnHookSoulStats()
		{
			if (Souls != null)
			{
				Souls.SoulActivated -= UpdateStats;
				Souls.SoulDeactivated -= UpdateStats;
			}
		}

		void HookSoulStats()
		{
			if (Souls != null)
			{
				Souls.SoulActivated += UpdateStats;
				Souls.SoulDeactivated += UpdateStats;
			}
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
