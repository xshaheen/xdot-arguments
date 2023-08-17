// Copyright (c) Mahmoud Shaheen, 2021. All rights reserved.
// Licensed under the Apache 2.0 license.
// See the LICENSE.txt file in the project root for full license information.

#if NET7_0_OR_GREATER
using System.Numerics;
#endif
using System.Runtime.CompilerServices;

namespace X.Arguments;

public static partial class Argument {
#if NET7_0_OR_GREATER
    /// <summary>Throws an <see cref="ArgumentException" /> if <paramref name="argument"/> is NaN.</summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="argument">The argument to check.</param>
    /// <param name="message">(Optional) Custom error message</param>
    /// <param name="paramName">Parameter name (auto generated no need to pass it).</param>
    /// <returns><paramref name="argument" /> if the value is not a NaN.</returns>
    /// <exception cref="ArgumentException"><paramref name="argument" /> if the value is NaN.</exception>
    public static T IsNotNaN<T>(T argument, string? message = null, [CallerArgumentExpression(nameof(argument))] string? paramName = null) where T : IFloatingPointIeee754<T> {
        return T.IsNaN(argument)
            ? throw new ArgumentException(message ?? $"The argument {_AssertString(paramName)} cannot be NaN.", paramName)
            : argument;
    }

    /// <summary>Throws an <see cref="ArgumentException" /> if <paramref name="argument"/> is not a NaN.</summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="argument">The argument to check.</param>
    /// <param name="message">(Optional) Custom error message</param>
    /// <param name="paramName">Parameter name (auto generated no need to pass it).</param>
    /// <returns><paramref name="argument" /> if the value is NaN.</returns>
    /// <exception cref="ArgumentException"><paramref name="argument" /> if the value is NaN.</exception>
    public static T IsNaN<T>(T argument, string? message = null, [CallerArgumentExpression(nameof(argument))] string? paramName = null) where T : IFloatingPointIeee754<T> {
        return T.IsNaN(argument)
            ? argument
            : throw new ArgumentException(message ?? $"The argument {_AssertString(paramName)} must be a NaN.", paramName);
    }
#endif
}
