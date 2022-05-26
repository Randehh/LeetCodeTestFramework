using LeetCodeTests.Framework;
using System;

namespace LeetCodeTests.Tests
{

	/// <summary>
	/// Choose what input type and output type in the generics
	/// </summary>
	public class NumberOfOneBits : TestTemplate<TestInput<uint>, TestOutput<int>>
	{

		/// <summary>
		/// These are your test cases, with the first parameter in each entry being the input, and the second parameter the expected outcome
		/// </summary>
		public override TestCase<TestInput<uint>, TestOutput<int>>[] TestCases => new TestCase<TestInput<uint>, TestOutput<int>>[] {
			new TestCase<TestInput<uint>, TestOutput<int>>(new TestInput<uint>(Convert.ToUInt32("00000000000000000000000000001011", 2)), new TestOutput<int>(3)),
			new TestCase<TestInput<uint>, TestOutput<int>>(new TestInput<uint>(Convert.ToUInt32("00000000000000000000000010000000", 2)), new TestOutput<int>(1)),
			new TestCase<TestInput<uint>, TestOutput<int>>(new TestInput<uint>(Convert.ToUInt32("11111111111111111111111111111101", 2)), new TestOutput<int>(31)),
		};

		/// <summary>
		/// This is the actual test which runs all the tests in <see cref="TestCases"/> 
		/// </summary>
		public override TestOutput<int> RunTest(TestInput<uint> input)
		{
			uint inputString = input.Value;

			// Do something

			return new TestOutput<int>(1);
		}
	}
}