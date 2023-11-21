using LINQTest_October;

namespace LINQTests
{
	public class Tests
	{
		List<int> list;

		[SetUp]
		public void Setup()
		{
			list = new List<int> { 1, 3, -5, 4, 2, 5, 8, -3, 20, 2, 9, 10, 11, 12 };
		}

		[Test]
		public void Test()
		{
			// Init

			// Action
			var result = list._SkipWhile(x => x > 0).ToList();

			// Assert
			int resultCount = result.Count;
			Assert.That(11 == resultCount, () => $"result count {resultCount}");

			for (int i = 0; i < result.Count(); i++)
			{
				Assert.That(list[i + 3] == result[i]);
			}
		}
	}
}