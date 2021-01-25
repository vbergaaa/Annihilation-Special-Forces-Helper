using NUnit.Framework;
using VEntityFramework;
using VEntityFramework.Model;

namespace Tests
{
	class EnumHelperTests
	{
		[TestCase("The Striding Titan", SoulType.StridingTitan)]
		[TestCase("StridingTitan", SoulType.StridingTitan)]
		[TestCase("High", SoulType.High)]
		public void TestEnumHelper(string description, SoulType expected)
		{
			Assert.That(EnumHelper.GetEnumFromDescription<SoulType>(description), Is.EqualTo(expected));
		}
	}
}
