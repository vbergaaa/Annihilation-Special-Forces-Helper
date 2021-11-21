using System.Linq;
using VEntityFramework.Data;

namespace VEntityFramework.Model
{
	public abstract class VGemCollection : BusinessObject
	{
		#region Constructor

		public VGemCollection(VLoadout loadout) : base(loadout)
		{
			Loadout = loadout;
		}

		#endregion

		#region Properties

		#region Loadout

		[VXML(false)]
		public VLoadout Loadout { get; private set; }

		#endregion

		#region Abstract Properties

		public abstract VGem AttackGem { get; }
		public abstract VGem AttackSpeedGem { get; }
		public abstract VGem HealthGem { get; }
		public abstract VGem HealthArmorGem { get; }
		public abstract VGem ShieldsGem { get; }
		public abstract VGem ShieldsArmorGem { get; }
		public abstract VGem DoubleWarpGem { get; }
		public abstract VGem TripleWarpGem { get; }
		public abstract VGem CritDamageGem { get; }
		public abstract VGem CritChanceGem { get; }

		[VXML(false)]
		public abstract VGem EconomyGem { get; }

		public abstract VGem[] Gems { get; }

		#endregion

		#endregion

		#region Methods

		#region TotalCost

		public int TotalCost { get => Gems.Sum(g => g.GetTotalCost()); }

		#endregion

		#endregion

		#region Implementation

		public override string BizoName => "GemCollection";

		public virtual int RemainingGems { get; }

		#endregion

		#region RefreshMaxValuesForBinding

		public void RefreshMaxLevelBindings()
		{
			foreach (var gem in Gems)
			{
				gem.RefreshPropertyBinding(nameof(gem.MaxValue));
			}
		}

		#endregion
	}
}

