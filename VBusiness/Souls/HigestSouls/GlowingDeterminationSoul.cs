﻿using VEntityFramework.Model;

namespace VBusiness.Souls
{
	public sealed class GlowingDeterminationSoul : HighestSoul
	{
		public GlowingDeterminationSoul(VSoulCollection collection) : base(collection)
		{
		}

		public override VEntityFramework.Model.SoulType Type => VEntityFramework.Model.SoulType.GlowingDetermination;
	}
}
