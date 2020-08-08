using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using VEntityFramework.Data;
using VEntityFramework.Model;

namespace VBusiness.Souls
{
	public class SoulCollection : VSoulCollection
	{
		public override Dictionary<int, string> Souls
		{
			get
			{
				if (fSouls == null)
				{
					var souls = new Dictionary<int, string>();
					foreach (var soulName in Context.GetAllSoulNames())
					{
						souls.Add(int.Parse(soulName.Split('-')[0]), soulName);
					}
					fSouls = souls;
				}
				return fSouls;
			}
		}
		Dictionary<int, string> fSouls;

		public override VSoul Soul1
		{
			get => base.Soul1 ?? (base.Soul1 = new EmptySoul());
			protected set => base.Soul1 = value;
		}

		public override int SoulSlot1
		{
			get => base.SoulSlot1;
			set
			{
				base.SoulSlot1 = value;
				Soul soul;
				if (value == 0)
				{
					soul = new EmptySoul();
				}
				else
				{
					soul = Souls.TryGetValue(value, out var soulName)
						? Context.ReadFromXML<Soul>(soulName)
						: null;
				}
				Soul1 = soul;
			}
		}

		public override VSoul Soul2
		{
			get => base.Soul2 ?? (base.Soul2 = new EmptySoul());
			protected set => base.Soul2 = value;
		}

		public override int SoulSlot2
		{
			get => base.SoulSlot2;
			set
			{
				base.SoulSlot2 = value;
				Soul soul;
				if (value == 0)
				{
					soul = new EmptySoul();
				}
				else
				{
					soul = Souls.TryGetValue(value, out var soulName)
						? Context.ReadFromXML<Soul>(soulName)
						: null;
				}
				Soul2 = soul;
			}
		}

		public override VSoul Soul3
		{
			get => base.Soul3 ?? (base.Soul3 = new EmptySoul());
			protected set => base.Soul3 = value;
		}

		public override int SoulSlot3
		{
			get => base.SoulSlot3;
			set
			{
				base.SoulSlot3 = value;
				Soul soul;
				if (value == 0)
				{
					soul = new EmptySoul();
				}
				else
				{
					soul = Souls.TryGetValue(value, out var soulName)
						? Context.ReadFromXML<Soul>(soulName)
						: null;
				}
				Soul3 = soul;
			}
		}
	}
}
