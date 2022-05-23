﻿using Kontur.Results;

namespace Kontur.Tests.Results.Conversion.Combinations.Linq.Optional.OptionalOptional
{
    internal class NoneFixtureCase : IFixtureCase
    {
        public Optional<TValue> GetOptional<TValue>(TValue value, TValue constant) => Optional<TValue>.None();
    }
}
