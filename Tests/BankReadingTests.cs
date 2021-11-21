using NUnit.Framework;
using StarCodeDecryptor;

namespace Tests
{
	class BankReadingTests
	{
		[Test]
		public void TestGettingBankFile()
		{
			var decoder = new ASFBankDecoder(null);
			Assert.That(decoder.RankPoints, Is.InstanceOf(typeof(int)));
			Assert.That(decoder.Gems, Is.InstanceOf(typeof(int)));
			Assert.That(() => decoder.Key, Throws.Nothing);
			Assert.That(() => decoder.GetSoulString(9), Throws.Nothing);
			Assert.That(() => decoder.GetAchievements(), Throws.Nothing);
			Assert.That(() => decoder.AchievementCount, Is.InRange(1, 500));
			Assert.That(() => decoder.SoulCollection, Throws.Nothing);
		}

		[Test]
		public void TestGetString()
		{
			var decoder = new ASFBankDecoder(null);
			var x = decoder.GetValue("745%GD", "CoC", 2);
			Assert.That(x, Is.EqualTo(""));
		}
	}
}
