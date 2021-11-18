﻿using System.Collections.Generic;
using System.Threading.Tasks;
using Kontur.Results;
using Kontur.Tests.Results.Conversion.Combinations.Linq.Result.SelectCaseGenerators;
using NUnit.Framework;

namespace Kontur.Tests.Results.Conversion.Combinations.Linq.Result.TValue.SelectMany.Results3
{
    [TestFixture]
    internal class Task_Should
    {
        private static readonly IEnumerable<TestCaseData> Cases = SelectCasesGenerator.Create(3).ToTestCases();

        [TestCaseSource(nameof(Cases))]
        public Task<Result<string, int>> Result_Result_Result(
            Result<string, int> result1,
            Result<string, int> result2,
            Result<string, int> result3)
        {
            return
                from x in result1
                from y in result2
                from z in result3
                select Task.FromResult(x + y + z);
        }

        [TestCaseSource(nameof(Cases))]
        public Task<Result<string, int>> TaskResult_Result_Result(
            Result<string, int> result1,
            Result<string, int> result2,
            Result<string, int> result3)
        {
            return
                from x in Task.FromResult(result1)
                from y in result2
                from z in result3
                select Task.FromResult(x + y + z);
        }

        [TestCaseSource(nameof(Cases))]
        public Task<Result<string, int>> Result_TaskResult_Result(
            Result<string, int> result1,
            Result<string, int> result2,
            Result<string, int> result3)
        {
            return
                from x in result1
                from y in Task.FromResult(result2)
                from z in result3
                select Task.FromResult(x + y + z);
        }

        [TestCaseSource(nameof(Cases))]
        public Task<Result<string, int>> Result_Result_TaskResult(
            Result<string, int> result1,
            Result<string, int> result2,
            Result<string, int> result3)
        {
            return
                from x in result1
                from y in result2
                from z in Task.FromResult(result3)
                select Task.FromResult(x + y + z);
        }

        [TestCaseSource(nameof(Cases))]
        public Task<Result<string, int>> TaskResult_TaskResult_Result(
            Result<string, int> result1,
            Result<string, int> result2,
            Result<string, int> result3)
        {
            return
                from x in Task.FromResult(result1)
                from y in Task.FromResult(result2)
                from z in result3
                select Task.FromResult(x + y + z);
        }

        [TestCaseSource(nameof(Cases))]
        public Task<Result<string, int>> TaskResult_Result_TaskResult(
            Result<string, int> result1,
            Result<string, int> result2,
            Result<string, int> result3)
        {
            return
                from x in Task.FromResult(result1)
                from y in result2
                from z in Task.FromResult(result3)
                select Task.FromResult(x + y + z);
        }

        [TestCaseSource(nameof(Cases))]
        public Task<Result<string, int>> Result_TaskResult_TaskResult(
            Result<string, int> result1,
            Result<string, int> result2,
            Result<string, int> result3)
        {
            return
                from x in result1
                from y in Task.FromResult(result2)
                from z in Task.FromResult(result3)
                select Task.FromResult(x + y + z);
        }

        [TestCaseSource(nameof(Cases))]
        public Task<Result<string, int>> TaskResult_TaskResult_TaskResult(
            Result<string, int> result1,
            Result<string, int> result2,
            Result<string, int> result3)
        {
            return
                from x in Task.FromResult(result1)
                from y in Task.FromResult(result2)
                from z in Task.FromResult(result3)
                select Task.FromResult(x + y + z);
        }
    }
}
