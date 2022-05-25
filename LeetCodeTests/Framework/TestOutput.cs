using System;

namespace LeetCodeTests.Framework
{
    public interface ITestOutput {
        Type ValueType { get; }
        object ValueRaw { get; }
    }
    public class TestOutput<T> : ITestOutput
    {
        public TestOutput(T value) { Value = value; }
        public virtual T Value { get; set; }
        public Type ValueType => typeof(T);
        public object ValueRaw => Value;
    }
}
