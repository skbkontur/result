﻿using System.Collections.Generic;
using System.Threading.Tasks;
using Kontur.Results;
using NUnit.Framework;

namespace Kontur.Tests.Results.Conversion.Combinations.Linq.Optional.Optional.Where.Tasks.Select
{
    [TestFixture]
    internal class Task_Should
    {
        private static readonly IEnumerable<TestCaseData> Cases = WhereCaseGenerator.Create(1);

        [TestCaseSource(nameof(Cases))]
        public Task<Optional<int>> OneOptional(Optional<int> optional, IsSuitable isSuitable)
        {
            return
                from value in optional
                where Task.FromResult(isSuitable(value))
                select Task.FromResult(value);
        }

        [TestCaseSource(nameof(Cases))]
        public Task<Optional<int>> TaskOptional(Optional<int> optional, IsSuitable isSuitable)
        {
            return
                from value in Task.FromResult(optional)
                where Task.FromResult(isSuitable(value))
                select Task.FromResult(value);
        }
    }
}
