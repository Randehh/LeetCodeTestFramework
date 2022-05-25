using LeetCodeTests.Framework;

namespace LeetCodeTests.Tests
{

	/// <summary>
	/// Choose what input type and output type in the generics
	/// </summary>
	public class TestTemplate : TestTemplate<TestInput<string>, TestOutput<string>>
	{

		/// <summary>
		/// These are your test cases, with the first parameter in each entry being the input, and the second parameter the expected outcome
		/// </summary>
		public override TestCase<TestInput<string>, TestOutput<string>>[] TestCases => new TestCase<TestInput<string>, TestOutput<string>>[] {
			new TestCase<TestInput<string>, TestOutput<string>>(new TestInput<string>("cbacdcbc"), new TestOutput<string>("acdb")),
		};

		/// <summary>
		/// This is the actual test which runs all the tests in <see cref="TestCases"/> 
		/// </summary>
		public override TestOutput<string> RunTest(TestInput<string> input)
		{
			string inputString = input.Value;

			// Do something

			return new TestOutput<string>(inputString);
		}
	}
}