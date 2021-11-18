﻿using System;
using System.Collections.Generic;
using System.Linq;
using Kontur.Results;
using NUnit.Framework;

namespace Kontur.Tests.Results.Extraction.Actions.OnFailure.TValue.Upcast
{
    [TestFixture]
    internal class Fault_Should
    {
        private static readonly Func<Result<Child, string>, Result<Base, string>>[] UpcastMethods =
        {
            result => result.OnFailure<Base, string>(_ => { }),
            result => result.OnFailure<Base, string>(() => { }),
        };

        private static readonly IEnumerable<TestCaseData> UpcastCases =
            from testCase in UpcastTValueExamples.GetFaults()
            from method in UpcastMethods
            select new TestCaseData(testCase.Source, method).Returns(testCase.Result);

        [TestCaseSource(nameof(UpcastCases))]
        public Result<Base, string> Return_Self_On_Upcast(
            Result<Child, string> source,
            Func<Result<Child, string>, Result<Base, string>> callOnFailure)
        {
            return callOnFailure(source);
        }
    }
}
