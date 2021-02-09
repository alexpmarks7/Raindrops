using NUnit.Framework;

namespace RaindropsTests
{
	public class Tests
	{
		private Raindrops _raindrops;

		[SetUp]
		public void Setup()
		{
			_raindrops = new Raindrops();
		}

		[TestCase(1, "1")]
		[TestCase(0, "PlingPlangPlong")]
		[TestCase(34, "34")]
		[TestCase(3, "Pling")]
		[TestCase(5, "Plang")]
		[TestCase(7, "Plong")]
		[TestCase(15, "PlingPlang")]
		[TestCase(21, "PlingPlong")]
		[TestCase(35, "PlangPlong")]
		[TestCase(105, "PlingPlangPlong")]
		[TestCase(-3, "Pling")]
		public void GivenIGiveAnInteger_AndICheckItsFactors_IGetTheCorrectPlingPlangPlongResponse(int input, string expected)
		{
			Assert.That(_raindrops.PlingPlangPlong(input), Is.EqualTo(expected));
		}
	}
}