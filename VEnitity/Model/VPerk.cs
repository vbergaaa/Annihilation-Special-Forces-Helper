using VEntityFramework.Attributes;
using VEntityFramework.Data;

namespace VEntityFramework.Model
{
	[VXMLParent("PeckCollection")]
	public abstract class VPerk : BusinessObject
	{
		#region Constructor

		public VPerk(VPerkCollection collection) : base(collection)
		{
			PerkCollection = collection;
		}

		internal VPerk() : base()
		{
		}

		#endregion

		#region Properties

		public string Name => PerkName;

		[VXML(true)]
		public string Code => $"{Page}_{Position}";

		[VXML(true)]
		public virtual short DesiredLevel
		{
			get => fDesiredLevel;
			set {
				if (value != fDesiredLevel)
				{
					var oldValue = fDesiredLevel;
					fDesiredLevel = value;
					HasChanges = true;

					using (PerkCollection.Loadout.Stats.SuspendRefreshingStatBindings())
					{
						OnLevelChanged(fDesiredLevel - oldValue);
					}
					PerkCollection?.Loadout?.RefreshPropertyBinding(nameof(PerkCollection.Loadout.RemainingPerkPoints));
					PerkCollection?.RefreshPropertyBinding(nameof(PerkCollection.RemainingCost));
					PerkCollection?.RefreshPropertyBinding(nameof(PerkCollection.TotalCost));
					PerkCollection?.RefreshPropertyBinding(nameof(PerkCollection.PageCost));
				}

				PerkCollection.RefreshMaxLevelBindings();
			}
		}
		short fDesiredLevel;

		[VXML(include:false)]
		public virtual VPerkCollection PerkCollection { get; internal set; }

		protected abstract string PerkName { get; }

		public abstract string Description { get; }

		public abstract byte Page { get; }

		public abstract byte Position { get; }

		public abstract int StartingCost { get; }

		public abstract int IncrementCost { get; }

		protected abstract short MaxLevelCore { get; }

		public virtual short MaxLevel { get; }

		public abstract int RemainingCost { get; }

		public abstract int TotalCost { get; }

		public abstract int CurrentCost { get; }

		#endregion

		protected virtual void OnLevelChanged(int difference)
		{
		}

		public virtual string GetIncrementHint(int amount)
		{
			return string.Empty;
		}

		public virtual string GetDecrementHint(int amount)
		{
			return string.Empty;
		}

		public virtual double GetProposedDamageIncrease(int amount)
		{
			return 0;
		}

		public virtual double GetProposedToughnessIncrease(int amount)
		{
			return 0;
		}

		public virtual double GetProposedDamageDecrease(int amount)
		{
			return 0;
		}

		public virtual double GetProposedToughnessDecrease(int amount)
		{
			return 0;
		}

		#region Overrides

		public override string ToString()
		{
			return $"{Code}, {Name} Perk";
		}

		public override string BizoName => "Perk";

		#endregion
	}
}
