using EnumsNET;
using NUnit.Framework;
using VBusiness.Souls;
using VEntityFramework.Model;

namespace Tests
{
	public class SoulTests
	{

		[Test]
		public void TestNew()
		{
			var allSouls = Enums.GetValues<SoulType>();
			foreach (var soul in allSouls)
			{
				var generatedSoul = Soul.New(soul, null);
				var soulName = generatedSoul.GetType().Name;

				if (soul == SoulType.None)
				{
					Assert.That(soulName, Is.EqualTo("EmptySoul"));
				}
				else
				{
					Assert.That(soulName, Contains.Substring(soul.ToString()));
				}
			}
		}
	}
}