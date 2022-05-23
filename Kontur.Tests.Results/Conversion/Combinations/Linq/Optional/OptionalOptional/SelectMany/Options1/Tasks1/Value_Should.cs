﻿using System.Collections.Generic;
using System.Threading.Tasks;
using Kontur.Results;
using NUnit.Framework;

namespace Kontur.Tests.Results.Conversion.Combinations.Linq.Optional.OptionalOptional.SelectMany.Options1.Tasks1
{
    internal class Value_Should<TFixtureCase> : LinqTestBase<TFixtureCase>
        where TFixtureCase : IFixtureCase, new()
    {
        private const int TaskTerm = 1000;
        private static readonly Task<int> Task1000 = Task.FromResult(TaskTerm);

        private static readonly IEnumerable<TestCaseData> Cases = CreateSelectCases(1, sum => sum + TaskTerm);

        [TestCaseSource(nameof(Cases))]
        public Task<Optional<int>> Optional_Task(Optional<int> optional)
        {
            return
                from x in optional
                from y in Task1000
                select GetOptional(x + y);
        }

        [TestCaseSource(nameof(Cases))]
        public Task<Optional<int>> TaskOptional_Task(Optional<int> optional)
        {
            return
                from x in Task.FromResult(optional)
                from y in Task1000
                select GetOptional(x + y);
        }
    }
}