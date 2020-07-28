namespace VBusiness.Gems
{
	class AttackGem : Gem
	{
		public override string Name => "Attack";

		public override int[] Costs => fCosts ?? (fCosts = GetCosts());
		int[] fCosts;

		private int[] GetCosts()
		{
			var costs = new int[100];

			for (var i = 0; i < 100; i++)
			{
				costs[i] = (i + 7) / 5;
			}

			return costs;
		}
	}
}
