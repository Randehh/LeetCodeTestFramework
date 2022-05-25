using LeetCodeTests.Framework;
using LeetCodeTests.Tests;
using System;
using System.Collections.Generic;

namespace LeetCodeTests {
	class Program {

        //Simply replace this test with you rown test and run it!
        private static ITestTemplateBase m_TestToRun = new TestTemplate();

        private static void Main(string[] args) {
            ITestCase[] testCases = m_TestToRun.TestCases;
            List<int> casesSucceeded = new List<int>();
            List<int> casesFailed = new List<int>();

            for (int i = 0; i < testCases.Length; i++) {
                ITestCase testCase = testCases[i];
                if (!VerifyTestCase(testCase)) {
                    Console.WriteLine($"Skipping test {i}, invalid test case.");
                    continue;
                }

                object result = m_TestToRun.Run(testCase);
                if (Equals(result, testCase.OutputBase.ValueRaw)) {
                    casesSucceeded.Add(i);
                    Console.WriteLine($"Test result {i}: Success.");
                } else {
                    casesFailed.Add(i);
                    Console.WriteLine($"Test result {i}: Failed.");
                }
            }

            Console.WriteLine($"Cases succeeded: {casesSucceeded.Count}, cases failed: {casesFailed.Count}");
        }

        private static bool VerifyTestCase(ITestCase testCase) {
            return m_TestToRun.ExpectedInputType == testCase.InputBase.GetType();
		}
    }
}
