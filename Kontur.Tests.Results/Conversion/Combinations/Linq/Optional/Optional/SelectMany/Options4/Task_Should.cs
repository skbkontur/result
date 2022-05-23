﻿using System.Collections.Generic;
using System.Threading.Tasks;
using Kontur.Results;
using NUnit.Framework;

namespace Kontur.Tests.Results.Conversion.Combinations.Linq.Optional.Optional.SelectMany.Options4
{
    [TestFixture]
    internal class Task_Should
    {
        private static readonly IEnumerable<TestCaseData> Cases = SelectCasesGenerator.Create(4).ToTestCases();

        [TestCaseSource(nameof(Cases))]
        public Task<Optional<int>> Optional_Optional_Optional_Optional(
            Optional<int> optional1,
            Optional<int> optional2,
            Optional<int> optional3,
            Optional<int> optional4)
        {
            return
                from x in optional1
                from y in optional2
                from z in optional3
                from m in optional4
                select Task.FromResult(x + y + z + m);
        }

        [TestCaseSource(nameof(Cases))]
        public Task<Optional<int>> TaskOptional_Optional_Optional_Optional(
            Optional<int> optional1,
            Optional<int> optional2,
            Optional<int> optional3,
            Optional<int> optional4)
        {
            return
                from x in Task.FromResult(optional1)
                from y in optional2
                from z in optional3
                from m in optional4
                select Task.FromResult(x + y + z + m);
        }

        [TestCaseSource(nameof(Cases))]
        public Task<Optional<int>> Optional_TaskOptional_Optional_Optional(
            Optional<int> optional1,
            Optional<int> optional2,
            Optional<int> optional3,
            Optional<int> optional4)
        {
            return
                from x in optional1
                from y in Task.FromResult(optional2)
                from z in optional3
                from m in optional4
                select Task.FromResult(x + y + z + m);
        }

        [TestCaseSource(nameof(Cases))]
        public Task<Optional<int>> Optional_Optional_TaskOptional_Optional(
            Optional<int> optional1,
            Optional<int> optional2,
            Optional<int> optional3,
            Optional<int> optional4)
        {
            return
                from x in optional1
                from y in optional2
                from z in Task.FromResult(optional3)
                from m in optional4
                select Task.FromResult(x + y + z + m);
        }

        [TestCaseSource(nameof(Cases))]
        public Task<Optional<int>> Optional_Optional_Optional_TaskOptional(
            Optional<int> optional1,
            Optional<int> optional2,
            Optional<int> optional3,
            Optional<int> optional4)
        {
            return
                from x in optional1
                from y in optional2
                from z in optional3
                from m in Task.FromResult(optional4)
                select Task.FromResult(x + y + z + m);
        }

        [TestCaseSource(nameof(Cases))]
        public Task<Optional<int>> TaskOptional_TaskOptional_Optional_Optional(
            Optional<int> optional1,
            Optional<int> optional2,
            Optional<int> optional3,
            Optional<int> optional4)
        {
            return
                from x in Task.FromResult(optional1)
                from y in Task.FromResult(optional2)
                from z in optional3
                from m in optional4
                select Task.FromResult(x + y + z + m);
        }

        [TestCaseSource(nameof(Cases))]
        public Task<Optional<int>> TaskOptional_Optional_TaskOptional_Optional(
            Optional<int> optional1,
            Optional<int> optional2,
            Optional<int> optional3,
            Optional<int> optional4)
        {
            return
                from x in Task.FromResult(optional1)
                from y in optional2
                from z in Task.FromResult(optional3)
                from m in optional4
                select Task.FromResult(x + y + z + m);
        }

        [TestCaseSource(nameof(Cases))]
        public Task<Optional<int>> TaskOptional_Optional_Optional_TaskOptional(
            Optional<int> optional1,
            Optional<int> optional2,
            Optional<int> optional3,
            Optional<int> optional4)
        {
            return
                from x in Task.FromResult(optional1)
                from y in optional2
                from z in optional3
                from m in Task.FromResult(optional4)
                select Task.FromResult(x + y + z + m);
        }

        [TestCaseSource(nameof(Cases))]
        public Task<Optional<int>> Optional_TaskOptional_TaskOptional_Optional(
            Optional<int> optional1,
            Optional<int> optional2,
            Optional<int> optional3,
            Optional<int> optional4)
        {
            return
                from x in optional1
                from y in Task.FromResult(optional2)
                from z in Task.FromResult(optional3)
                from m in optional4
                select Task.FromResult(x + y + z + m);
        }

        [TestCaseSource(nameof(Cases))]
        public Task<Optional<int>> Optional_TaskOptional_Optional_TaskOptional(
            Optional<int> optional1,
            Optional<int> optional2,
            Optional<int> optional3,
            Optional<int> optional4)
        {
            return
                from x in optional1
                from y in Task.FromResult(optional2)
                from z in optional3
                from m in Task.FromResult(optional4)
                select Task.FromResult(x + y + z + m);
        }

        [TestCaseSource(nameof(Cases))]
        public Task<Optional<int>> Optional_Optional_TaskOptional_TaskOptional(
            Optional<int> optional1,
            Optional<int> optional2,
            Optional<int> optional3,
            Optional<int> optional4)
        {
            return
                from x in optional1
                from y in optional2
                from z in Task.FromResult(optional3)
                from m in Task.FromResult(optional4)
                select Task.FromResult(x + y + z + m);
        }

        [TestCaseSource(nameof(Cases))]
        public Task<Optional<int>> TaskOptional_TaskOptional_TaskOptional_Optional(
            Optional<int> optional1,
            Optional<int> optional2,
            Optional<int> optional3,
            Optional<int> optional4)
        {
            return
                from x in Task.FromResult(optional1)
                from y in Task.FromResult(optional2)
                from z in Task.FromResult(optional3)
                from m in optional4
                select Task.FromResult(x + y + z + m);
        }

        [TestCaseSource(nameof(Cases))]
        public Task<Optional<int>> TaskOptional_TaskOptional_Optional_TaskOptional(
            Optional<int> optional1,
            Optional<int> optional2,
            Optional<int> optional3,
            Optional<int> optional4)
        {
            return
                from x in Task.FromResult(optional1)
                from y in Task.FromResult(optional2)
                from z in optional3
                from m in Task.FromResult(optional4)
                select Task.FromResult(x + y + z + m);
        }

        [TestCaseSource(nameof(Cases))]
        public Task<Optional<int>> TaskOptional_Optional_TaskOptional_TaskOptional(
            Optional<int> optional1,
            Optional<int> optional2,
            Optional<int> optional3,
            Optional<int> optional4)
        {
            return
                from x in Task.FromResult(optional1)
                from y in optional2
                from z in Task.FromResult(optional3)
                from m in Task.FromResult(optional4)
                select Task.FromResult(x + y + z + m);
        }

        [TestCaseSource(nameof(Cases))]
        public Task<Optional<int>> Optional_TaskOptional_TaskOptional_TaskOptional(
            Optional<int> optional1,
            Optional<int> optional2,
            Optional<int> optional3,
            Optional<int> optional4)
        {
            return
                from x in optional1
                from y in Task.FromResult(optional2)
                from z in Task.FromResult(optional3)
                from m in Task.FromResult(optional4)
                select Task.FromResult(x + y + z + m);
        }

        [TestCaseSource(nameof(Cases))]
        public Task<Optional<int>> TaskOptional_TaskOptional_TaskOptional_TaskOptional(
            Optional<int> optional1,
            Optional<int> optional2,
            Optional<int> optional3,
            Optional<int> optional4)
        {
            return
                from x in Task.FromResult(optional1)
                from y in Task.FromResult(optional2)
                from z in Task.FromResult(optional3)
                from m in Task.FromResult(optional4)
                select Task.FromResult(x + y + z + m);
        }
    }
}
