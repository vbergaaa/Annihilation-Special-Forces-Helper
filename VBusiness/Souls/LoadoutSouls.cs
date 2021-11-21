using EnumsNET;
using System.Collections.Generic;
using VEntityFramework.Model;

namespace VBusiness.Souls
{
	public class LoadoutSouls : VLoadoutSouls
	{
		#region Constructor

		public LoadoutSouls(VLoadout loadout) : base(loadout)
		{
		}

		#endregion

		#region Properties

		#region SoulCosts

		public override int SoulCosts
		{
			get
			{
				var soul1Cost = Soul1?.Cost ?? 0;
				var soul2Cost = Soul2?.Cost ?? 0;
				var soul3Cost = Soul3?.Cost ?? 0;
				return soul1Cost + soul2Cost + soul3Cost;
			}
		}

		#endregion

		#region Soul1

		public override VSoul Soul1
		{
			get => base.Soul1 ??= new EmptySoul();
			protected set => base.Soul1 = value;
		}

		public override int SoulSlot1
		{
			get => base.SoulSlot1;
			set
			{
				base.SoulSlot1 = value;
				VSoul soul = null;
				if (value == 0)
				{
					soul = new EmptySoul();
				}
				else
				{
					if (SavedSouls.TryGetValue(value, out var soulName))
					{
						soul = Context.ReadFromXMLWithCache<Soul>(soulName);
						soul.Parent = this;
					}
				}
				Soul1 = soul;
			}
		}

		#endregion

		#region Soul2

		public override VSoul Soul2
		{
			get => base.Soul2 ??= new EmptySoul();
			protected set => base.Soul2 = value;
		}

		public override int SoulSlot2
		{
			get => base.SoulSlot2;
			set
			{
				base.SoulSlot2 = value;
				VSoul soul = null;
				if (value == 0)
				{
					soul = new EmptySoul();
				}
				else
				{
					if (SavedSouls.TryGetValue(value, out var soulName))
					{
						soul = Context.ReadFromXMLWithCache<Soul>(soulName);
						soul.Parent = this;
					}
				}
				Soul2 = soul;
			}
		}

		#endregion

		#region Soul3

		public override VSoul Soul3
		{
			get => base.Soul3 ??= new EmptySoul();
			protected set => base.Soul3 = value;
		}

		public override int SoulSlot3
		{
			get => base.SoulSlot3;
			set
			{
				base.SoulSlot3 = value;
				VSoul soul = null;
				if (value == 0)
				{
					soul = new EmptySoul();
				}
				else
				{
					if (SavedSouls.TryGetValue(value, out var soulName))
					{
						soul = Context.ReadFromXMLWithCache<Soul>(soulName);
						soul.Parent = this;
					}
				}
				Soul3 = soul;
			}
		}

		#endregion

		#region SoulPowers

		public override VSoulPowers SoulPowers => fSoulPowers ??= new SoulPowers(this);
		VSoulPowers fSoulPowers;

		public override string SoulPower1 => SoulPowers.ActiveSouls.Count > 0 ? SoulPowers.ActiveSouls[0].AsString(EnumFormat.Description, EnumFormat.Name) : "Unselected";
		public override string SoulPower2 => SoulPowers.ActiveSouls.Count > 1 ? SoulPowers.ActiveSouls[1].AsString(EnumFormat.Description, EnumFormat.Name) : "Unselected";

		#endregion

		#endregion

		#region Lookups

		public override Dictionary<int, string> SavedSouls
		{
			get
			{
				if (fSouls == null)
				{
					var souls = new Dictionary<int, string>();
					foreach (var soulName in Context.GetAllFileNames<Soul>())
					{
						souls.Add(int.Parse(soulName.Split('-')[0]), soulName);
					}
					fSouls = souls;
				}
				return fSouls;
			}
		}
		Dictionary<int, string> fSouls;

		#endregion
	}
}
