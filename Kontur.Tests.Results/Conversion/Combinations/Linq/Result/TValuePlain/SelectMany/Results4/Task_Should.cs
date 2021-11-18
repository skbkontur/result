﻿using System.Collections.Generic;
using System.Threading.Tasks;
using Kontur.Results;
using NUnit.Framework;

namespace Kontur.Tests.Results.Conversion.Combinations.Linq.Result.TValuePlain.SelectMany.Results4
{
    internal class Task_Should<TFixtureCase> : LinqTestBase<TFixtureCase>
        where TFixtureCase : IFixtureCase, new()
    {
        private static readonly IEnumerable<TestCaseData> Cases = FixtureCase.GenerateCases(4);

        private static Task<Result<string>> SelectResult(int value)
        {
            return Task.FromResult(GetResult(value));
        }

        [TestCaseSource(nameof(Cases))]
        public Task<Result<string>> Result_Result_Result_Result(
            Result<string, int> result1,
            Result<string, int> result2,
            Result<string, int> result3,
            Result<string, int> result4)
        {
            return
                from x in result1
                from y in result2
                from z in result3
                from m in result4
                select SelectResult(x + y + z + m);
        }

        [TestCaseSource(nameof(Cases))]
        public Task<Result<string>> TaskResult_Result_Result_Result(
            Result<string, int> result1,
            Result<string, int> result2,
            Result<string, int> result3,
            Result<string, int> result4)
        {
            return
                from x in Task.FromResult(result1)
                from y in result2
                from z in result3
                from m in result4
                select SelectResult(x + y + z + m);
        }

        [TestCaseSource(nameof(Cases))]
        public Task<Result<string>> Result_TaskResult_Result_Result(
            Result<string, int> result1,
            Result<string, int> result2,
            Result<string, int> result3,
            Result<string, int> result4)
        {
            return
                from x in result1
                from y in Task.FromResult(result2)
                from z in result3
                from m in result4
                select SelectResult(x + y + z + m);
        }

        [TestCaseSource(nameof(Cases))]
        public Task<Result<string>> Result_Result_TaskResult_Result(
            Result<string, int> result1,
            Result<string, int> result2,
            Result<string, int> result3,
            Result<string, int> result4)
        {
            return
                from x in result1
                from y in result2
                from z in Task.FromResult(result3)
                from m in result4
                select SelectResult(x + y + z + m);
        }

        [TestCaseSource(nameof(Cases))]
        public Task<Result<string>> Result_Result_Result_TaskResult(
            Result<string, int> result1,
            Result<string, int> result2,
            Result<string, int> result3,
            Result<string, int> result4)
        {
            return
                from x in result1
                from y in result2
                from z in result3
                from m in Task.FromResult(result4)
                select SelectResult(x + y + z + m);
        }

        [TestCaseSource(nameof(Cases))]
        public Task<Result<string>> TaskResult_TaskResult_Result_Result(
            Result<string, int> result1,
            Result<string, int> result2,
            Result<string, int> result3,
            Result<string, int> result4)
        {
            return
                from x in Task.FromResult(result1)
                from y in Task.FromResult(result2)
                from z in result3
                from m in result4
                select SelectResult(x + y + z + m);
        }

        [TestCaseSource(nameof(Cases))]
        public Task<Result<string>> TaskResult_Result_TaskResult_Result(
            Result<string, int> result1,
            Result<string, int> result2,
            Result<string, int> result3,
            Result<string, int> result4)
        {
            return
                from x in Task.FromResult(result1)
                from y in result2
                from z in Task.FromResult(result3)
                from m in result4
                select SelectResult(x + y + z + m);
        }

        [TestCaseSource(nameof(Cases))]
        public Task<Result<string>> TaskResult_Result_Result_TaskResult(
            Result<string, int> result1,
            Result<string, int> result2,
            Result<string, int> result3,
            Result<string, int> result4)
        {
            return
                from x in Task.FromResult(result1)
                from y in result2
                from z in result3
                from m in Task.FromResult(result4)
                select SelectResult(x + y + z + m);
        }

        [TestCaseSource(nameof(Cases))]
        public Task<Result<string>> Result_TaskResult_TaskResult_Result(
            Result<string, int> result1,
            Result<string, int> result2,
            Result<string, int> result3,
            Result<string, int> result4)
        {
            return
                from x in result1
                from y in Task.FromResult(result2)
                from z in Task.FromResult(result3)
                from m in result4
                select SelectResult(x + y + z + m);
        }

        [TestCaseSource(nameof(Cases))]
        public Task<Result<string>> Result_TaskResult_Result_TaskResult(
            Result<string, int> result1,
            Result<string, int> result2,
            Result<string, int> result3,
            Result<string, int> result4)
        {
            return
                from x in result1
                from y in Task.FromResult(result2)
                from z in result3
                from m in Task.FromResult(result4)
                select SelectResult(x + y + z + m);
        }

        [TestCaseSource(nameof(Cases))]
        public Task<Result<string>> Result_Result_TaskResult_TaskResult(
            Result<string, int> result1,
            Result<string, int> result2,
            Result<string, int> result3,
            Result<string, int> result4)
        {
            return
                from x in result1
                from y in result2
                from z in Task.FromResult(result3)
                from m in Task.FromResult(result4)
                select SelectResult(x + y + z + m);
        }

        [TestCaseSource(nameof(Cases))]
        public Task<Result<string>> TaskResult_TaskResult_TaskResult_Result(
            Result<string, int> result1,
            Result<string, int> result2,
            Result<string, int> result3,
            Result<string, int> result4)
        {
            return
                from x in Task.FromResult(result1)
                from y in Task.FromResult(result2)
                from z in Task.FromResult(result3)
                from m in result4
                select SelectResult(x + y + z + m);
        }

        [TestCaseSource(nameof(Cases))]
        public Task<Result<string>> TaskResult_TaskResult_Result_TaskResult(
            Result<string, int> result1,
            Result<string, int> result2,
            Result<string, int> result3,
            Result<string, int> result4)
        {
            return
                from x in Task.FromResult(result1)
                from y in Task.FromResult(result2)
                from z in result3
                from m in Task.FromResult(result4)
                select SelectResult(x + y + z + m);
        }

        [TestCaseSource(nameof(Cases))]
        public Task<Result<string>> TaskResult_Result_TaskResult_TaskResult(
            Result<string, int> result1,
            Result<string, int> result2,
            Result<string, int> result3,
            Result<string, int> result4)
        {
            return
                from x in Task.FromResult(result1)
                from y in result2
                from z in Task.FromResult(result3)
                from m in Task.FromResult(result4)
                select SelectResult(x + y + z + m);
        }

        [TestCaseSource(nameof(Cases))]
        public Task<Result<string>> Result_TaskResult_TaskResult_TaskResult(
            Result<string, int> result1,
            Result<string, int> result2,
            Result<string, int> result3,
            Result<string, int> result4)
        {
            return
                from x in result1
                from y in Task.FromResult(result2)
                from z in Task.FromResult(result3)
                from m in Task.FromResult(result4)
                select SelectResult(x + y + z + m);
        }

        [TestCaseSource(nameof(Cases))]
        public Task<Result<string>> TaskResult_TaskResult_TaskResult_TaskResult(
            Result<string, int> result1,
            Result<string, int> result2,
            Result<string, int> result3,
            Result<string, int> result4)
        {
            return
                from x in Task.FromResult(result1)
                from y in Task.FromResult(result2)
                from z in Task.FromResult(result3)
                from m in Task.FromResult(result4)
                select SelectResult(x + y + z + m);
        }
    }
}
