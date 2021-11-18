﻿using System.Collections.Generic;
using System.Threading.Tasks;
using Kontur.Results;
using NUnit.Framework;

namespace Kontur.Tests.Results.Conversion.Combinations.Linq.Optional.Optional.SelectMany.Options2.Plain
{
    [TestFixture]
    internal class Value_Should
    {
        private static readonly IEnumerable<TestCaseData> Cases = SelectCasesGenerator.Create(2).ToTestCases();

        [TestCaseSource(nameof(Cases))]
        public Optional<int> Option_Option(Optional<int> option1, Optional<int> option2)
        {
            return
                from x in option1
                from y in option2
                select x + y;
        }

        [TestCaseSource(nameof(Cases))]
        public Optional<int> Option_Let_Option(Optional<int> option1, Optional<int> option2)
        {
            return
                from xLet in option1
                let x = xLet
                from y in option2
                select x + y;
        }

        [TestCaseSource(nameof(Cases))]
        public Optional<int> Option_Option_Let(Optional<int> option1, Optional<int> option2)
        {
            return
                from x in option1
                from yLet in option2
                let y = yLet
                select x + y;
        }

        [TestCaseSource(nameof(Cases))]
        public Optional<int> Option_Let_Option_Let(Optional<int> option1, Optional<int> option2)
        {
            return
                from xLet in option1
                let x = xLet
                from yLet in option2
                let y = yLet
                select x + y;
        }

        [TestCaseSource(nameof(Cases))]
        public Task<Optional<int>> TaskOption_Option(Optional<int> option1, Optional<int> option2)
        {
            return
                from x in Task.FromResult(option1)
                from y in option2
                select x + y;
        }

        [TestCaseSource(nameof(Cases))]
        public Task<Optional<int>> TaskOption_Let_Option(Optional<int> option1, Optional<int> option2)
        {
            return
                from xLet in Task.FromResult(option1)
                let x = xLet
                from y in option2
                select x + y;
        }

        [TestCaseSource(nameof(Cases))]
        public Task<Optional<int>> TaskOption_Option_Let(Optional<int> option1, Optional<int> option2)
        {
            return
                from x in Task.FromResult(option1)
                from yLet in option2
                let y = yLet
                select x + y;
        }

        [TestCaseSource(nameof(Cases))]
        public Task<Optional<int>> TaskOption_Let_Option_Let(Optional<int> option1, Optional<int> option2)
        {
            return
                from xLet in Task.FromResult(option1)
                let x = xLet
                from yLet in option2
                let y = yLet
                select x + y;
        }

        [TestCaseSource(nameof(Cases))]
        public Task<Optional<int>> Option_TaskOption(Optional<int> option1, Optional<int> option2)
        {
            return
                from x in option1
                from y in Task.FromResult(option2)
                select x + y;
        }

        [TestCaseSource(nameof(Cases))]
        public Task<Optional<int>> Option_Let_TaskOption(Optional<int> option1, Optional<int> option2)
        {
            return
                from xLet in option1
                let x = xLet
                from y in Task.FromResult(option2)
                select x + y;
        }

        [TestCaseSource(nameof(Cases))]
        public Task<Optional<int>> Option_TaskOption_Let(Optional<int> option1, Optional<int> option2)
        {
            return
                from x in option1
                from yLet in Task.FromResult(option2)
                let y = yLet
                select x + y;
        }

        [TestCaseSource(nameof(Cases))]
        public Task<Optional<int>> Option_Let_TaskOption_Let(Optional<int> option1, Optional<int> option2)
        {
            return
                from xLet in option1
                let x = xLet
                from yLet in Task.FromResult(option2)
                let y = yLet
                select x + y;
        }

        [TestCaseSource(nameof(Cases))]
        public Task<Optional<int>> TaskOption_TaskOption(Optional<int> option1, Optional<int> option2)
        {
            return
                from x in Task.FromResult(option1)
                from y in Task.FromResult(option2)
                select x + y;
        }

        [TestCaseSource(nameof(Cases))]
        public Task<Optional<int>> TaskOption_Let_TaskOption(Optional<int> option1, Optional<int> option2)
        {
            return
                from xLet in Task.FromResult(option1)
                let x = xLet
                from y in Task.FromResult(option2)
                select x + y;
        }

        [TestCaseSource(nameof(Cases))]
        public Task<Optional<int>> TaskOption_TaskOption_Let(Optional<int> option1, Optional<int> option2)
        {
            return
                from x in Task.FromResult(option1)
                from yLet in Task.FromResult(option2)
                let y = yLet
                select x + y;
        }

        [TestCaseSource(nameof(Cases))]
        public Task<Optional<int>> TaskOption_Let_TaskOption_Let(Optional<int> option1, Optional<int> option2)
        {
            return
                from xLet in Task.FromResult(option1)
                let x = xLet
                from yLet in Task.FromResult(option2)
                let y = yLet
                select x + y;
        }
    }
}
