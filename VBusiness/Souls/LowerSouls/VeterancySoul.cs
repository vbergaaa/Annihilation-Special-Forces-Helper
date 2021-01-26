﻿using VEntityFramework.Model;

namespace VBusiness.Souls
{
	public sealed class VeterancySoul : LowerSoul
	{
		public VeterancySoul(VLoadoutSouls collection) : base(collection)
		{
		}

		public override VEntityFramework.Model.SoulType Type => VEntityFramework.Model.SoulType.Veterancy;
	}
}
