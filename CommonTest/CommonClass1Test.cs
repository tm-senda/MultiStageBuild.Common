using NUnit.Framework;

namespace MultiStageBuild.Common
{
	[TestFixture]
	public class CommonClass1Test
	{
		[Test]
		public void TestMethod1()
		{
			var commonClass1 = new CommonClass1();
			Assert.IsTrue(commonClass1.Method1());
		}
	}
}
