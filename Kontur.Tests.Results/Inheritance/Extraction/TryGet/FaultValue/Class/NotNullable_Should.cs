﻿using System.Collections.Generic;
using NUnit.Framework;

namespace Kontur.Tests.Results.Inheritance.Extraction.TryGet.FaultValue.Class
{
    [TestFixture]
    internal class NotNullable_Should
    {
        private static TestCaseData CreateReturnBooleanCase(StringFaultResult<string> result, bool success)
        {
            return Common.CreateReturnBooleanCase(result, success);
        }

        private static readonly TestCaseData[] ReturnBooleanCases =
        {
            CreateReturnBooleanCase(StringFaultResult.Fail<string>(new("foo")), true),
            CreateReturnBooleanCase(StringFaultResult.Succeed("bar"), false),
        };

        [TestCaseSource(nameof(ReturnBooleanCases))]
        public bool Return_Boolean(StringFaultResult<string> result)
        {
            return result.TryGetFault(out _, out _);
        }

        private static readonly TestCaseData[] GetSuccessCases =
        {
            new(StringFaultResult.Succeed("bar")) { ExpectedResult = "bar" },
        };

        [TestCaseSource(nameof(GetSuccessCases))]
        public string? Extract_Value(StringFaultResult<string> result)
        {
            _ = result.TryGetFault(out _, out var value);

            return value;
        }

        [TestCaseSource(nameof(GetSuccessCases))]
        public string Extract_Value_With_If(StringFaultResult<string> result)
        {
            if (!result.TryGetFault(out _, out var value))
            {
                return value;
            }

            throw new UnreachableException();
        }

        private static IEnumerable<TestCaseData> GetFailureCases()
        {
            StringFault fault = new("foo");
            yield return new(StringFaultResult.Fail<string>(fault)) { ExpectedResult = fault };
        }

        [TestCaseSource(nameof(GetFailureCases))]
        public StringFault? Extract_Fault(StringFaultResult<string> result)
        {
            _ = result.TryGetFault(out var fault, out _);

            return fault;
        }

        [TestCaseSource(nameof(GetFailureCases))]
        public StringFault Extract_Fault_With_If(StringFaultResult<string> result)
        {
            if (result.TryGetFault(out var fault, out _))
            {
                return fault;
            }

            throw new UnreachableException();
        }

        private static TestCaseData CreateAllCase(StringFaultResult<string> result, string expected)
        {
            return new(result) { ExpectedResult = expected };
        }

        private static readonly TestCaseData[] GetAllCases =
        {
            CreateAllCase(StringFaultResult.Fail<string>(new("foo")), "foo"),
            CreateAllCase(StringFaultResult.Succeed("bar"), "bar"),
        };

        [TestCaseSource(nameof(GetAllCases))]
        public string Extract_All_With_If(StringFaultResult<string> result)
        {
            return result.TryGetFault(out var fault, out var value)
                ? fault.ToString()
                : value;
        }
    }
}
