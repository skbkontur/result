﻿using Kontur.Results;
using NUnit.Framework;

namespace Kontur.Tests.Results.Extraction.TryGet.TValue.ValueFault.Struct
{
    [TestFixture]
    internal class NotNullable_Should
    {
        private static TestCaseData CreateReturnBooleanCase(Result<int, int> result, bool success)
        {
            return Common.CreateReturnBooleanCase(result, success);
        }

        private static readonly TestCaseData[] ReturnBooleanCases =
        {
            CreateReturnBooleanCase(Result<int, int>.Fail(33), false),
            CreateReturnBooleanCase(Result<int, int>.Succeed(1), true),
        };

        [TestCaseSource(nameof(ReturnBooleanCases))]
        public bool Return_Boolean(Result<int, int> result)
        {
            return result.TryGetValue(out _, out _);
        }

        private static readonly TestCaseData[] GetSuccessCases =
        {
            new(Result<int, int>.Succeed(10)) { ExpectedResult = 10 },
        };

        [TestCaseSource(nameof(GetSuccessCases))]
        public int Extract_Value(Result<int, int> result)
        {
            _ = result.TryGetValue(out var value, out _);

            return value;
        }

        [TestCaseSource(nameof(GetSuccessCases))]
        public int Extract_Value_With_If(Result<int, int> result)
        {
            if (result.TryGetValue(out var value, out _))
            {
                return value;
            }

            throw new UnreachableException();
        }

        private static readonly TestCaseData[] GetFailureCases =
        {
            new(Result<int, int>.Fail(10)) { ExpectedResult = 10 },
        };

        [TestCaseSource(nameof(GetFailureCases))]
        public int Extract_Fault(Result<int, int> result)
        {
            _ = result.TryGetValue(out _, out var fault);

            return fault;
        }

        [TestCaseSource(nameof(GetFailureCases))]
        public int Extract_Fault_With_If(Result<int, int> result)
        {
            if (!result.TryGetValue(out _, out var fault))
            {
                return fault;
            }

            throw new UnreachableException();
        }

        private static TestCaseData CreateAllCase(Result<int, int> result, int expected)
        {
            return new(result) { ExpectedResult = expected };
        }

        private static readonly TestCaseData[] GetAllCases =
        {
            CreateAllCase(Result<int, int>.Fail(10), 10),
            CreateAllCase(Result<int, int>.Succeed(33), 33),
        };

        [TestCaseSource(nameof(GetAllCases))]
        public int Extract_All_With_If(Result<int, int> result)
        {
            return result.TryGetValue(out var value, out var fault)
                ? value
                : fault;
        }
    }
}
