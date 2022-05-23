﻿using Kontur.Results;

namespace Kontur.Tests.Results
{
    internal class UpcastTValueExample<TFault, TValue, TResult>
    {
        internal UpcastTValueExample(Result<TFault, TValue> source, TResult result)
        {
            this.Source = source;
            this.Result = result;
        }

        internal Result<TFault, TValue> Source { get; }

        internal TResult Result { get; }
    }
}
