﻿using Kontur.Results;
using NUnit.Framework;

namespace Kontur.Tests.Results.Extraction.TryGet.TValue.ValueFault.Class
{
    [TestFixture]
    internal class NotNullable_Should
    {
        private static TestCaseData CreateReturnBooleanCase(Result<string, string> result, bool success)
        {
            return Common.CreateReturnBooleanCase(result, success);
        }

        private static readonly TestCaseData[] ReturnBooleanCases =
        {
            CreateReturnBooleanCase(Result<string, string>.Fail("foo"), false),
            CreateReturnBooleanCase(Result<string, string>.Succeed("bar"), true),
        };

        [TestCaseSource(nameof(ReturnBooleanCases))]
        public bool Return_Boolean(Result<string, string> result)
        {
            return result.TryGetValue(out _, out _);
        }

        private static readonly TestCaseData[] GetSuccessCases =
        {
            new(Result<string, string>.Succeed("bar")) { ExpectedResult = "bar" },
        };

        [TestCaseSource(nameof(GetSuccessCases))]
        public string? Extract_Value(Result<string, string> result)
        {
            _ = result.TryGetValue(out var value, out _);

            return value;
        }

        [TestCaseSource(nameof(GetSuccessCases))]
        public string Extract_Value_With_If(Result<string, string> result)
        {
            if (result.TryGetValue(out var value, out _))
            {
                return value;
            }

            throw new UnreachableException();
        }

        private static readonly TestCaseData[] GetFailureCases =
        {
            new(Result<string, string>.Fail("foo")) { ExpectedResult = "foo" },
        };

        [TestCaseSource(nameof(GetFailureCases))]
        public string? Extract_Fault(Result<string, string> result)
        {
            _ = result.TryGetValue(out _, out var fault);

            return fault;
        }

        [TestCaseSource(nameof(GetFailureCases))]
        public string Extract_Fault_With_If(Result<string, string> result)
        {
            if (!result.TryGetValue(out _, out var fault))
            {
                return fault;
            }

            throw new UnreachableException();
        }

        private static TestCaseData CreateAllCase(Result<string, string> result, string expected)
        {
            return new(result) { ExpectedResult = expected };
        }

        private static readonly TestCaseData[] GetAllCases =
        {
            CreateAllCase(Result<string, string>.Fail("foo"), "foo"),
            CreateAllCase(Result<string, string>.Succeed("bar"), "bar"),
        };

        [TestCaseSource(nameof(GetAllCases))]
        public string Extract_All_With_If(Result<string, string> result)
        {
            return result.TryGetValue(out var value, out var fault)
                ? value
                : fault;
        }
    }
}
