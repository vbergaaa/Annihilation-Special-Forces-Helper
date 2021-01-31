using System.Collections.Generic;
using System.Linq;
using VEntityFramework.Data;

namespace VEntityFramework.Model
{
	public abstract class VSoulCollection : VBusinessObject
	{
		public VSoulCollection(VProfile profile) : base(profile)
		{
		}

		#region DiscoveredSouls

		[VXML(true)]
		public List<SoulType> DiscoveredSouls => fDiscoveredSouls ??= new List<SoulType>();
		List<SoulType> fDiscoveredSouls;

		#endregion

		#region Booleans

		#region HasBronzeSoul

		public bool HasBronzeSoul
		{
			get => DiscoveredSouls.Any(soul => soul == SoulType.Bronze);
			set
			{
				if (HasBronzeSoul && !value)
				{
					DiscoveredSouls.Remove(SoulType.Bronze);
					HasChanges = true;
				}
				if (!HasBronzeSoul && value)
				{
					DiscoveredSouls.Add(SoulType.Bronze);
					HasChanges = true;
				}
			}
		}

		#endregion

		#region HasMirrorsSoul

		public bool HasMirrorsSoul
		{
			get => DiscoveredSouls.Any(soul => soul == SoulType.Mirrors);
			set
			{
				if (HasMirrorsSoul && !value)
				{
					DiscoveredSouls.Remove(SoulType.Mirrors);
					HasChanges = true;
				}
				if (!HasMirrorsSoul && value)
				{
					DiscoveredSouls.Add(SoulType.Mirrors);
					HasChanges = true;
				}
			}
		}

		#endregion

		#region HasHunterSoul

		public bool HasHunterSoul
		{
			get => DiscoveredSouls.Any(soul => soul == SoulType.Hunter);
			set
			{
				if (HasHunterSoul && !value)
				{
					DiscoveredSouls.Remove(SoulType.Hunter);
					HasChanges = true;
				}
				if (!HasHunterSoul && value)
				{
					DiscoveredSouls.Add(SoulType.Hunter);
					HasChanges = true;
				}
			}
		}

		#endregion

		#region HasSilverSoul

		public bool HasSilverSoul
		{
			get => DiscoveredSouls.Any(soul => soul == SoulType.Silver);
			set
			{
				if (HasSilverSoul && !value)
				{
					DiscoveredSouls.Remove(SoulType.Silver);
					HasChanges = true;
				}
				if (!HasSilverSoul && value)
				{
					DiscoveredSouls.Add(SoulType.Silver);
					HasChanges = true;
				}
			}
		}

		#endregion

		#region HasReflectionSoul

		public bool HasReflectionSoul
		{
			get => DiscoveredSouls.Any(soul => soul == SoulType.Reflection);
			set
			{
				if (HasReflectionSoul && !value)
				{
					DiscoveredSouls.Remove(SoulType.Reflection);
					HasChanges = true;
				}
				if (!HasReflectionSoul && value)
				{
					DiscoveredSouls.Add(SoulType.Reflection);
					HasChanges = true;
				}
			}
		}

		#endregion

		#region HasVeterancySoul

		public bool HasVeterancySoul
		{
			get => DiscoveredSouls.Any(soul => soul == SoulType.Veterancy);
			set
			{
				if (HasVeterancySoul && !value)
				{
					DiscoveredSouls.Remove(SoulType.Veterancy);
					HasChanges = true;
				}
				if (!HasVeterancySoul && value)
				{
					DiscoveredSouls.Add(SoulType.Veterancy);
					HasChanges = true;
				}
			}
		}

		#endregion

		#region HasHungerSoul

		public bool HasHungerSoul
		{
			get => DiscoveredSouls.Any(soul => soul == SoulType.Hunger);
			set
			{
				if (HasHungerSoul && !value)
				{
					DiscoveredSouls.Remove(SoulType.Hunger);
					HasChanges = true;
				}
				if (!HasHungerSoul && value)
				{
					DiscoveredSouls.Add(SoulType.Hunger);
					HasChanges = true;
				}
			}
		}

		#endregion

		#region HasScavengerSoul

		public bool HasScavengerSoul
		{
			get => DiscoveredSouls.Any(soul => soul == SoulType.Scavenger);
			set
			{
				if (HasScavengerSoul && !value)
				{
					DiscoveredSouls.Remove(SoulType.Scavenger);
					HasChanges = true;
				}
				if (!HasScavengerSoul && value)
				{
					DiscoveredSouls.Add(SoulType.Scavenger);
					HasChanges = true;
				}
			}
		}

		#endregion

		#region HasUrusySoul

		public bool HasUrusySoul
		{
			get => DiscoveredSouls.Any(soul => soul == SoulType.Urusy);
			set
			{
				if (HasUrusySoul && !value)
				{
					DiscoveredSouls.Remove(SoulType.Urusy);
					HasChanges = true;
				}
				if (!HasUrusySoul && value)
				{
					DiscoveredSouls.Add(SoulType.Urusy);
					HasChanges = true;
				}
			}
		}

		#endregion

		#region HasGreedSoul

		public bool HasGreedSoul
		{
			get => DiscoveredSouls.Any(soul => soul == SoulType.Greed);
			set
			{
				if (HasGreedSoul && !value)
				{
					DiscoveredSouls.Remove(SoulType.Greed);
					HasChanges = true;
				}
				if (!HasGreedSoul && value)
				{
					DiscoveredSouls.Add(SoulType.Greed);
					HasChanges = true;
				}
			}
		}

		#endregion

		#region HasLuckSoul

		public bool HasLuckSoul
		{
			get => DiscoveredSouls.Any(soul => soul == SoulType.Luck);
			set
			{
				if (HasLuckSoul && !value)
				{
					DiscoveredSouls.Remove(SoulType.Luck);
					HasChanges = true;
				}
				if (!HasLuckSoul && value)
				{
					DiscoveredSouls.Add(SoulType.Luck);
					HasChanges = true;
				}
			}
		}

		#endregion

		#region HasSharingSoul

		public bool HasSharingSoul
		{
			get => DiscoveredSouls.Any(soul => soul == SoulType.Sharing);
			set
			{
				if (HasSharingSoul && !value)
				{
					DiscoveredSouls.Remove(SoulType.Sharing);
					HasChanges = true;
				}
				if (!HasSharingSoul && value)
				{
					DiscoveredSouls.Add(SoulType.Sharing);
					HasChanges = true;
				}
			}
		}

		#endregion

		#region HasConvenienceSoul

		public bool HasConvenienceSoul
		{
			get => DiscoveredSouls.Any(soul => soul == SoulType.Convenience);
			set
			{
				if (HasConvenienceSoul && !value)
				{
					DiscoveredSouls.Remove(SoulType.Convenience);
					HasChanges = true;
				}
				if (!HasConvenienceSoul && value)
				{
					DiscoveredSouls.Add(SoulType.Convenience);
					HasChanges = true;
				}
			}
		}

		#endregion

		#region HasPromotionSoul

		public bool HasPromotionSoul
		{
			get => DiscoveredSouls.Any(soul => soul == SoulType.Promotion);
			set
			{
				if (HasPromotionSoul && !value)
				{
					DiscoveredSouls.Remove(SoulType.Promotion);
					HasChanges = true;
				}
				if (!HasPromotionSoul && value)
				{
					DiscoveredSouls.Add(SoulType.Promotion);
					HasChanges = true;
				}
			}
		}

		#endregion

		#region HasStatusSoul

		public bool HasStatusSoul
		{
			get => DiscoveredSouls.Any(soul => soul == SoulType.Status);
			set
			{
				if (HasStatusSoul && !value)
				{
					DiscoveredSouls.Remove(SoulType.Status);
					HasChanges = true;
				}
				if (!HasStatusSoul && value)
				{
					DiscoveredSouls.Add(SoulType.Status);
					HasChanges = true;
				}
			}
		}

		#endregion

		#region HasPredestinationSoul

		public bool HasPredestinationSoul
		{
			get => DiscoveredSouls.Any(soul => soul == SoulType.Predestination);
			set
			{
				if (HasPredestinationSoul && !value)
				{
					DiscoveredSouls.Remove(SoulType.Predestination);
					HasChanges = true;
				}
				if (!HasPredestinationSoul && value)
				{
					DiscoveredSouls.Add(SoulType.Predestination);
					HasChanges = true;
				}
			}
		}

		#endregion

		#region HasRapidMutationSoul

		public bool HasRapidMutationSoul
		{
			get => DiscoveredSouls.Any(soul => soul == SoulType.RapidMutation);
			set
			{
				if (HasRapidMutationSoul && !value)
				{
					DiscoveredSouls.Remove(SoulType.RapidMutation);
					HasChanges = true;
				}
				if (!HasRapidMutationSoul && value)
				{
					DiscoveredSouls.Add(SoulType.RapidMutation);
					HasChanges = true;
				}
			}
		}

		#endregion

		#region HasSalesSoul

		public bool HasSalesSoul
		{
			get => DiscoveredSouls.Any(soul => soul == SoulType.Sales);
			set
			{
				if (HasSalesSoul && !value)
				{
					DiscoveredSouls.Remove(SoulType.Sales);
					HasChanges = true;
				}
				if (!HasSalesSoul && value)
				{
					DiscoveredSouls.Add(SoulType.Sales);
					HasChanges = true;
				}
			}
		}

		#endregion

		#region HasAccelleratedAdvancementSoul

		public bool HasAccelleratedAdvancementSoul
		{
			get => DiscoveredSouls.Any(soul => soul == SoulType.AccelleratedAdvancement);
			set
			{
				if (HasAccelleratedAdvancementSoul && !value)
				{
					DiscoveredSouls.Remove(SoulType.AccelleratedAdvancement);
					HasChanges = true;
				}
				if (!HasAccelleratedAdvancementSoul && value)
				{
					DiscoveredSouls.Add(SoulType.AccelleratedAdvancement);
					HasChanges = true;
				}
			}
		}

		#endregion

		#region HasGlowingDeterminationSoul

		public bool HasGlowingDeterminationSoul
		{
			get => DiscoveredSouls.Any(soul => soul == SoulType.GlowingDetermination);
			set
			{
				if (HasGlowingDeterminationSoul && !value)
				{
					DiscoveredSouls.Remove(SoulType.GlowingDetermination);
					HasChanges = true;
				}
				if (!HasGlowingDeterminationSoul && value)
				{
					DiscoveredSouls.Add(SoulType.GlowingDetermination);
					HasChanges = true;
				}
			}
		}

		#endregion

		#region HasWellAmplificationSoul

		public bool HasWellAmplificationSoul
		{
			get => DiscoveredSouls.Any(soul => soul == SoulType.WellAmplification);
			set
			{
				if (HasWellAmplificationSoul && !value)
				{
					DiscoveredSouls.Remove(SoulType.WellAmplification);
					HasChanges = true;
				}
				if (!HasWellAmplificationSoul && value)
				{
					DiscoveredSouls.Add(SoulType.WellAmplification);
					HasChanges = true;
				}
			}
		}

		#endregion

		#region HasGhostForceSoul

		public bool HasGhostForceSoul
		{
			get => DiscoveredSouls.Any(soul => soul == SoulType.GhostForce);
			set
			{
				if (HasGhostForceSoul && !value)
				{
					DiscoveredSouls.Remove(SoulType.GhostForce);
					HasChanges = true;
				}
				if (!HasGhostForceSoul && value)
				{
					DiscoveredSouls.Add(SoulType.GhostForce);
					HasChanges = true;
				}
			}
		}

		#endregion

		#region HasPowerWarpingSoul

		public bool HasPowerWarpingSoul
		{
			get => DiscoveredSouls.Any(soul => soul == SoulType.PowerWarping);
			set
			{
				if (HasPowerWarpingSoul && !value)
				{
					DiscoveredSouls.Remove(SoulType.PowerWarping);
					HasChanges = true;
				}
				if (!HasPowerWarpingSoul && value)
				{
					DiscoveredSouls.Add(SoulType.PowerWarping);
					HasChanges = true;
				}
			}
		}

		#endregion

		#region HasTrainingSoul

		public bool HasTrainingSoul
		{
			get => DiscoveredSouls.Any(soul => soul == SoulType.Training);
			set
			{
				if (HasTrainingSoul && !value)
				{
					DiscoveredSouls.Remove(SoulType.Training);
					HasChanges = true;
				}
				if (!HasTrainingSoul && value)
				{
					DiscoveredSouls.Add(SoulType.Training);
					HasChanges = true;
				}
			}
		}

		#endregion

		#region HasTankingSoul

		public bool HasTankingSoul
		{
			get => DiscoveredSouls.Any(soul => soul == SoulType.Tanking);
			set
			{
				if (HasTankingSoul && !value)
				{
					DiscoveredSouls.Remove(SoulType.Tanking);
					HasChanges = true;
				}
				if (!HasTankingSoul && value)
				{
					DiscoveredSouls.Add(SoulType.Tanking);
					HasChanges = true;
				}
			}
		}

		#endregion

		#region HasUnchainedSoul

		public bool HasUnchainedSoul
		{
			get => DiscoveredSouls.Any(soul => soul == SoulType.Unchained);
			set
			{
				if (HasUnchainedSoul && !value)
				{
					DiscoveredSouls.Remove(SoulType.Unchained);
					HasChanges = true;
				}
				if (!HasUnchainedSoul && value)
				{
					DiscoveredSouls.Add(SoulType.Unchained);
					HasChanges = true;
				}
			}
		}

		#endregion

		#region HasDemolitionSoul

		public bool HasDemolitionSoul
		{
			get => DiscoveredSouls.Any(soul => soul == SoulType.Demolition);
			set
			{
				if (HasDemolitionSoul && !value)
				{
					DiscoveredSouls.Remove(SoulType.Demolition);
					HasChanges = true;
				}
				if (!HasDemolitionSoul && value)
				{
					DiscoveredSouls.Add(SoulType.Demolition);
					HasChanges = true;
				}
			}
		}

		#endregion

		#region HasAlacritySoul

		public bool HasAlacritySoul
		{
			get => DiscoveredSouls.Any(soul => soul == SoulType.Alacrity);
			set
			{
				if (HasAlacritySoul && !value)
				{
					DiscoveredSouls.Remove(SoulType.Alacrity);
					HasChanges = true;
				}
				if (!HasAlacritySoul && value)
				{
					DiscoveredSouls.Add(SoulType.Alacrity);
					HasChanges = true;
				}
			}
		}

		#endregion

		#region HasDrainingSoul

		public bool HasDrainingSoul
		{
			get => DiscoveredSouls.Any(soul => soul == SoulType.Draining);
			set
			{
				if (HasDrainingSoul && !value)
				{
					DiscoveredSouls.Remove(SoulType.Draining);
					HasChanges = true;
				}
				if (!HasDrainingSoul && value)
				{
					DiscoveredSouls.Add(SoulType.Draining);
					HasChanges = true;
				}
			}
		}

		#endregion

		#region HasStatsSoul

		public bool HasStatsSoul
		{
			get => DiscoveredSouls.Any(soul => soul == SoulType.Stats);
			set
			{
				if (HasStatsSoul && !value)
				{
					DiscoveredSouls.Remove(SoulType.Stats);
					HasChanges = true;
				}
				if (!HasStatsSoul && value)
				{
					DiscoveredSouls.Add(SoulType.Stats);
					HasChanges = true;
				}
			}
		}

		#endregion

		#region HasAccelerationSoul

		public bool HasAccelerationSoul
		{
			get => DiscoveredSouls.Any(soul => soul == SoulType.Acceleration);
			set
			{
				if (HasAccelerationSoul && !value)
				{
					DiscoveredSouls.Remove(SoulType.Acceleration);
					HasChanges = true;
				}
				if (!HasAccelerationSoul && value)
				{
					DiscoveredSouls.Add(SoulType.Acceleration);
					HasChanges = true;
				}
			}
		}

		#endregion

		#region HasStridingTitanSoul

		public bool HasStridingTitanSoul
		{
			get => DiscoveredSouls.Any(soul => soul == SoulType.StridingTitan);
			set
			{
				if (HasStridingTitanSoul && !value)
				{
					DiscoveredSouls.Remove(SoulType.StridingTitan);
					HasChanges = true;
				}
				if (!HasStridingTitanSoul && value)
				{
					DiscoveredSouls.Add(SoulType.StridingTitan);
					HasChanges = true;
				}
			}
		}

		#endregion

		#region HasUnboundReflectionSoul

		public bool HasUnboundReflectionSoul
		{
			get => DiscoveredSouls.Any(soul => soul == SoulType.UnboundReflection);
			set
			{
				if (HasUnboundReflectionSoul && !value)
				{
					DiscoveredSouls.Remove(SoulType.UnboundReflection);
					HasChanges = true;
				}
				if (!HasUnboundReflectionSoul && value)
				{
					DiscoveredSouls.Add(SoulType.UnboundReflection);
					HasChanges = true;
				}
			}
		}

		#endregion

		#region HasDivineSpeedSoul

		public bool HasDivineSpeedSoul
		{
			get => DiscoveredSouls.Any(soul => soul == SoulType.DivineSpeed);
			set
			{
				if (HasDivineSpeedSoul && !value)
				{
					DiscoveredSouls.Remove(SoulType.DivineSpeed);
					HasChanges = true;
				}
				if (!HasDivineSpeedSoul && value)
				{
					DiscoveredSouls.Add(SoulType.DivineSpeed);
					HasChanges = true;
				}
			}
		}

		#endregion

		#region HasLuckyStatusSoul

		public bool HasLuckyStatusSoul
		{
			get => DiscoveredSouls.Any(soul => soul == SoulType.LuckyStatus);
			set
			{
				if (HasLuckyStatusSoul && !value)
				{
					DiscoveredSouls.Remove(SoulType.LuckyStatus);
					HasChanges = true;
				}
				if (!HasLuckyStatusSoul && value)
				{
					DiscoveredSouls.Add(SoulType.LuckyStatus);
					HasChanges = true;
				}
			}
		}

		#endregion

		#region HasSupportingSoul

		public bool HasSupportingSoul
		{
			get => DiscoveredSouls.Any(soul => soul == SoulType.Supporting);
			set
			{
				if (HasSupportingSoul && !value)
				{
					DiscoveredSouls.Remove(SoulType.Supporting);
					HasChanges = true;
				}
				if (!HasSupportingSoul && value)
				{
					DiscoveredSouls.Add(SoulType.Supporting);
					HasChanges = true;
				}
			}
		}

		#endregion

		#endregion

		#region TotalUniques

		public int TotalUniques => DiscoveredSouls.Count();

		#endregion

		#region PowerSouls

		public int PowerSouls => TotalUniques / 24;

		#endregion

		public override string BizoName => "SoulCollection";
	}
}
