using VBusiness.Gems;
using VBusiness.Perks;
using VEntityFramework;
using VEntityFramework.Model;

namespace VBusiness.Loadouts
{
	public class Loadout : VLoadout
	{
		public Loadout()
		{
			Stats = new Stats();
			Perks = new PerkCollection();
			Gems = new GemCollection();
		}

		public override VGemCollection Gems
		{
			get => base.Gems;
			set
			{
				UnHookStatsEvents();
				base.Gems = value;
				HookStatsEvents();
			}
		}

		public override VPerkCollection Perks 
		{ 
			get => base.Perks;
			set
			{
				UnHookStatsEvents();
				base.Perks = value;
				HookStatsEvents();
			}
		}

		void UpdateStats(object sender, StatsEventArgs e)
		{
			e.Modification(Stats);
		}

		public void HookStatsEvents()
		{
			if (Perks != null)
			{
				Perks.PerkLevelChanged += UpdateStats;
			}
			if (Gems != null)
			{
				Gems.GemCollectionLevelUpdated += UpdateStats;
			}
		}

		public void UnHookStatsEvents()
		{
			if (Perks != null)
			{
				Perks.PerkLevelChanged -= UpdateStats;
			}
			if (Gems != null)
			{
				Gems.GemCollectionLevelUpdated -= UpdateStats;
			}
		}

		#region Validation

		public override bool RunPreSaveValidation(out string errorMessage)
		{
			errorMessage = null;

			if (CheckInvalidLoadoutName())
			{
				errorMessage = "Please enter a name for this loadout.";
			}
			else if (CheckInvalidSlotNumber())
			{
				errorMessage = "Please enter a Save slot that is greater than 0.";
			}

			return errorMessage == null ? base.RunPreSaveValidation(out errorMessage) : false;
		}

		bool CheckInvalidSlotNumber()
		{
			return Slot <= 0;
		}

		bool CheckInvalidLoadoutName()
		{
			return Name == "";
		}

		#endregion
	}
}
