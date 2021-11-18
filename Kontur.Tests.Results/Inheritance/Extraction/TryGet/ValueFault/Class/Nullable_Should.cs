﻿using NUnit.Framework;

namespace Kontur.Tests.Results.Inheritance.Extraction.TryGet.ValueFault.Class
{
    [TestFixture]
    internal class Nullable_Should
    {
        private static TestCaseData CreateReturnBooleanCase(StringFaultResult<string?> result, bool success)
        {
            return Common.CreateReturnBooleanCase(result, success);
        }

        private static readonly TestCaseData[] ReturnBooleanCases =
        {
            CreateReturnBooleanCase(StringFaultResult.Fail<string?>(new("foo")), false),
            CreateReturnBooleanCase(StringFaultResult.Succeed<string?>(null), true),
            CreateReturnBooleanCase(StringFaultResult.Succeed<string?>("bar"), true),
        };

        [TestCaseSource(nameof(ReturnBooleanCases))]
        public bool Return_Boolean(StringFaultResult<string?> result)
        {
            return result.TryGetValue(out _, out _);
        }

        private static TestCaseData CreateSuccessCase(string? expectedValue)
        {
            return new(StringFaultResult.Succeed(expectedValue)) { ExpectedResult = expectedValue };
        }

        private static readonly TestCaseData[] GetSuccessCases =
        {
            CreateSuccessCase(null),
            CreateSuccessCase("bar"),
        };

        [TestCaseSource(nameof(GetSuccessCases))]
        public string? Extract_Value(StringFaultResult<string?> result)
        {
            _ = result.TryGetValue(out var value, out _);

            return value;
        }

        [TestCaseSource(nameof(GetSuccessCases))]
        public string? Extract_Value_With_If(StringFaultResult<string?> result)
        {
            if (result.TryGetValue(out var value, out _))
            {
                return value;
            }

            throw new UnreachableException();
        }

        private static TestCaseData CreateFailureCase(StringFault expectedValue)
        {
            return new(StringFaultResult.Fail<string?>(expectedValue)) { ExpectedResult = expectedValue };
        }

        private static readonly TestCaseData[] GetFailureCases =
        {
            CreateFailureCase(new("foo")),
        };

        [TestCaseSource(nameof(GetFailureCases))]
        public StringFault? Extract_Fault(StringFaultResult<string?> result)
        {
            _ = result.TryGetValue(out _, out var fault);

            return fault;
        }

        [TestCaseSource(nameof(GetFailureCases))]
        public StringFault Extract_Fault_With_If(StringFaultResult<string?> result)
        {
            if (!result.TryGetValue(out _, out var fault))
            {
                return fault;
            }

            throw new UnreachableException();
        }

        private static TestCaseData CreateAllCase(StringFaultResult<string?> result, string? expected)
        {
            return new(result) { ExpectedResult = expected };
        }

        private static readonly TestCaseData[] GetAllCases =
        {
            CreateAllCase(StringFaultResult.Fail<string?>(new("foo")), "foo"),
            CreateAllCase(StringFaultResult.Succeed<string?>(null), null),
            CreateAllCase(StringFaultResult.Succeed<string?>("bar"), "bar"),
        };

        [TestCaseSource(nameof(GetAllCases))]
        public string? Extract_All_With_If(StringFaultResult<string?> result)
        {
            return result.TryGetValue(out var value, out var fault)
                ? value
                : fault.ToString();
        }
    }
}
