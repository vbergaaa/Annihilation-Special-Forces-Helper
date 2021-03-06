﻿using VEntityFramework.Model;

namespace VBusiness.Souls
{
	public sealed class TrainingSoul : NightSoul
	{
		public TrainingSoul(VLoadoutSouls collection) : base(collection)
		{
		}

		public override VEntityFramework.Model.SoulType Type => VEntityFramework.Model.SoulType.Training;
	}
}
