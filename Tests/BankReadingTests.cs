using NUnit.Framework;
using StarCodeDecryptor;
using System;
using System.Collections.Generic;
using System.Text;

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
		}
	}
}
