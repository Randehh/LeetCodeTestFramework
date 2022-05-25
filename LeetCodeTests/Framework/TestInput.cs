using System;

namespace LeetCodeTests.Framework
{
    public interface ITestInput
    {
        Type ValueType { get; }
    }

    public class TestInput<T> : ITestInput
    {
        public TestInput(T value) { Value = value; }
        public virtual T Value { get; set; }
        public Type ValueType => typeof(T);
    }
}