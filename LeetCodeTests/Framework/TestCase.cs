namespace LeetCodeTests.Framework {

	public interface ITestCase
	{
		public ITestInput InputBase { get; }
		public ITestOutput OutputBase { get; }
	}

	public class TestCase<TInput, TOutput> : ITestCase where TInput : ITestInput where TOutput : ITestOutput
	{
		public TInput Input { get; }
		public TOutput Output { get; }

		public ITestInput InputBase => Input;
		public ITestOutput OutputBase => Output;

        public TestCase(TInput input, TOutput output) {
			Input = input;
			Output = output;
		}
	}
}
