using VBusiness.Rooms;
using VEntityFramework;
using VEntityFramework.Model;

namespace VBusiness
{


	public class BrutaliskOverride : VBrutaliskOverride
	{
		public BrutaliskOverride(VIncomeManager manager) : base(manager)
		{
		}

		public override bool Bruta1
		{
			get => ShouldOverrideBrutalisks ? BrutaOverride1 : ShouldSelectBruta(EnemyType.Bruta1);
			set
			{
				if (ShouldOverrideBrutalisks)
				{
					BrutaOverride1 = value;
				}
			}
		}

		public override bool Bruta2
		{
			get => ShouldOverrideBrutalisks ? BrutaOverride2 : ShouldSelectBruta(EnemyType.Bruta2);
			set
			{
				if (ShouldOverrideBrutalisks)
				{
					BrutaOverride2 = value;
				}
			}
		}

		public override bool Bruta3
		{
			get => ShouldOverrideBrutalisks ? BrutaOverride3 : ShouldSelectBruta(EnemyType.Bruta3);
			set
			{
				if (ShouldOverrideBrutalisks)
				{
					BrutaOverride3 = value;
				}
			}
		}

		public override bool Bruta4
		{
			get => ShouldOverrideBrutalisks ? BrutaOverride4 : ShouldSelectBruta(EnemyType.Bruta4);
			set
			{
				if (ShouldOverrideBrutalisks)
				{
					BrutaOverride4 = value;
				}
			}
		}

		public override bool Bruta5
		{
			get => ShouldOverrideBrutalisks ? BrutaOverride5 : ShouldSelectBruta(EnemyType.Bruta5);
			set
			{
				if (ShouldOverrideBrutalisks)
				{
					BrutaOverride5 = value;
				}
			}
		}

		public override bool Bruta6
		{
			get => ShouldOverrideBrutalisks ? BrutaOverride6 : ShouldSelectBruta(EnemyType.Bruta6);
			set
			{
				if (ShouldOverrideBrutalisks)
				{
					BrutaOverride6 = value;
				}
			}
		}

		bool ShouldSelectBruta(EnemyType type)
		{
			ErrorReporter.ReportDebug("Should only contain Brutas", () => type < EnemyType.Bruta1 && type != EnemyType.None);

			return IncomeManager.Loadout.UnitConfiguration.Difficulty.Difficulty > DifficultyLevel.Brutal
				&& IncomeManager.FarmRoom != RoomNumber.None
				&& Room.New(IncomeManager.Loadout.IncomeManager.FarmRoom).Bruta == type;
		}
	}
}
