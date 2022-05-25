using System;

namespace LeetCodeTests.Framework {

	// So we can cast down without the generic types
	public interface ITestTemplateBase {
		Type ExpectedInputType { get; }
        abstract ITestCase[] TestCases { get; }
        abstract ITestOutput Run(ITestCase testCase);
	}

    public abstract class TestTemplate<TInput, TOutput> : ITestTemplateBase where TInput : ITestInput where TOutput : ITestOutput
	{
        public abstract ITestCase[] TestCases { get; }

        public Type ExpectedInputType => typeof(TInput);

        public ITestOutput Run(ITestCase testCase)
        {
            return RunTest((TInput)testCase.InputBase);
        }

        public abstract TOutput RunTest(TInput input);
    }
}
