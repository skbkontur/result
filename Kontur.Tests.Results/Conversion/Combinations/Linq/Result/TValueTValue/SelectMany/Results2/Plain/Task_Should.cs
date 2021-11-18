﻿using System.Collections.Generic;
using System.Threading.Tasks;
using Kontur.Results;
using NUnit.Framework;

namespace Kontur.Tests.Results.Conversion.Combinations.Linq.Result.TValueTValue.SelectMany.Results2.Plain
{
    internal class Task_Should<TFixtureCase> : LinqTestBase<TFixtureCase>
        where TFixtureCase : IFixtureCase, new()
    {
        private static readonly IEnumerable<TestCaseData> Cases = CreateSelectCases(2);

        private static Task<Result<string, int>> SelectResult(int value)
        {
            return Task.FromResult(GetResult(value));
        }

        [TestCaseSource(nameof(Cases))]
        public Task<Result<string, int>> Result_Result(Result<string, int> result1, Result<string, int> result2)
        {
            return
                from x in result1
                from y in result2
                select SelectResult(x + y);
        }

        [TestCaseSource(nameof(Cases))]
        public Task<Result<string, int>> Result_Let_Result(Result<string, int> result1, Result<string, int> result2)
        {
            return
                from xLet in result1
                let x = xLet
                from y in result2
                select SelectResult(x + y);
        }

        [TestCaseSource(nameof(Cases))]
        public Task<Result<string, int>> Result_Result_Let(Result<string, int> result1, Result<string, int> result2)
        {
            return
                from x in result1
                from yLet in result2
                let y = yLet
                select SelectResult(x + y);
        }

        [TestCaseSource(nameof(Cases))]
        public Task<Result<string, int>> Result_Let_Result_Let(Result<string, int> result1, Result<string, int> result2)
        {
            return
                from xLet in result1
                let x = xLet
                from yLet in result2
                let y = yLet
                select SelectResult(x + y);
        }

        [TestCaseSource(nameof(Cases))]
        public Task<Result<string, int>> TaskResult_Result(Result<string, int> result1, Result<string, int> result2)
        {
            return
                from x in Task.FromResult(result1)
                from y in result2
                select SelectResult(x + y);
        }

        [TestCaseSource(nameof(Cases))]
        public Task<Result<string, int>> TaskResult_Let_Result(Result<string, int> result1, Result<string, int> result2)
        {
            return
                from xLet in Task.FromResult(result1)
                let x = xLet
                from y in result2
                select SelectResult(x + y);
        }

        [TestCaseSource(nameof(Cases))]
        public Task<Result<string, int>> TaskResult_Result_Let(Result<string, int> result1, Result<string, int> result2)
        {
            return
                from x in Task.FromResult(result1)
                from yLet in result2
                let y = yLet
                select SelectResult(x + y);
        }

        [TestCaseSource(nameof(Cases))]
        public Task<Result<string, int>> TaskResult_Let_Result_Let(Result<string, int> result1, Result<string, int> result2)
        {
            return
                from xLet in Task.FromResult(result1)
                let x = xLet
                from yLet in result2
                let y = yLet
                select SelectResult(x + y);
        }

        [TestCaseSource(nameof(Cases))]
        public Task<Result<string, int>> Result_TaskResult(Result<string, int> result1, Result<string, int> result2)
        {
            return
                from x in result1
                from y in Task.FromResult(result2)
                select SelectResult(x + y);
        }

        [TestCaseSource(nameof(Cases))]
        public Task<Result<string, int>> Result_Let_TaskResult(Result<string, int> result1, Result<string, int> result2)
        {
            return
                from xLet in result1
                let x = xLet
                from y in Task.FromResult(result2)
                select SelectResult(x + y);
        }

        [TestCaseSource(nameof(Cases))]
        public Task<Result<string, int>> Result_TaskResult_Let(Result<string, int> result1, Result<string, int> result2)
        {
            return
                from x in result1
                from yLet in Task.FromResult(result2)
                let y = yLet
                select SelectResult(x + y);
        }

        [TestCaseSource(nameof(Cases))]
        public Task<Result<string, int>> Result_Let_TaskResult_Let(Result<string, int> result1, Result<string, int> result2)
        {
            return
                from xLet in result1
                let x = xLet
                from yLet in Task.FromResult(result2)
                let y = yLet
                select SelectResult(x + y);
        }

        [TestCaseSource(nameof(Cases))]
        public Task<Result<string, int>> TaskResult_TaskResult(Result<string, int> result1, Result<string, int> result2)
        {
            return
                from x in Task.FromResult(result1)
                from y in Task.FromResult(result2)
                select SelectResult(x + y);
        }

        [TestCaseSource(nameof(Cases))]
        public Task<Result<string, int>> TaskResult_Let_TaskResult(Result<string, int> result1, Result<string, int> result2)
        {
            return
                from xLet in Task.FromResult(result1)
                let x = xLet
                from y in Task.FromResult(result2)
                select SelectResult(x + y);
        }

        [TestCaseSource(nameof(Cases))]
        public Task<Result<string, int>> TaskResult_TaskResult_Let(Result<string, int> result1, Result<string, int> result2)
        {
            return
                from x in Task.FromResult(result1)
                from yLet in Task.FromResult(result2)
                let y = yLet
                select SelectResult(x + y);
        }

        [TestCaseSource(nameof(Cases))]
        public Task<Result<string, int>> TaskResult_Let_TaskResult_Let(Result<string, int> result1, Result<string, int> result2)
        {
            return
                from xLet in Task.FromResult(result1)
                let x = xLet
                from yLet in Task.FromResult(result2)
                let y = yLet
                select SelectResult(x + y);
        }
    }
}
