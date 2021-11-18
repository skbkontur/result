﻿using Kontur.Results;

namespace Kontur.Tests.Results.Conversion.Combinations.Linq.Result.TValueTValue
{
    internal class FailureVariableFixtureCase : IFixtureCase
    {
        public Result<string, TValue> GetResult<TValue>(TValue value, IConstantProvider<TValue> provider) =>
            Result<string, TValue>.Fail(provider.GetError());
    }
}
