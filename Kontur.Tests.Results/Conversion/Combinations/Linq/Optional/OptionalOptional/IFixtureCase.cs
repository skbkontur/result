﻿using Kontur.Results;

namespace Kontur.Tests.Results.Conversion.Combinations.Linq.Optional.OptionalOptional
{
    internal interface IFixtureCase
    {
        public Optional<TValue> GetOptional<TValue>(TValue value, TValue constant);
    }
}
