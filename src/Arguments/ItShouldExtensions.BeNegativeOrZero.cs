// Copyright (c) Mahmoud Shaheen, 2021. All rights reserved.
// Licensed under the Apache 2.0 license.
// See the LICENSE.txt file in the project root for full license information.

using System.Runtime.CompilerServices;

namespace X.Arguments;

public static partial class ItShouldExtensions {
    /// <summary>Throws an <see cref="ArgumentOutOfRangeException" /> if <paramref name="argument" /> is positive.</summary>
    /// <param name="_"></param>
    /// <param name="argument">The argument to check.</param>
    /// <param name="message">(Optional) Custom error message.</param>
    /// <param name="paramName">Parameter name (auto generated no need to pass it).</param>
    /// <returns><paramref name="paramName" /> if the argument is negative or zero.</returns>
    /// <exception cref="ArgumentOutOfRangeException">if <paramref name="argument" /> is positive.</exception>
    public static int BeNegativeOrZero(this It _, int argument, string? message = null, [CallerArgumentExpression("argument")] string? paramName = null) {
        return argument <= 0
            ? argument
            : throw new ArgumentOutOfRangeException(message ?? $"The argument {paramName} cannot be positive.", paramName);
    }

    /// <inheritdoc cref="BeNegativeOrZero(It,int,string?,string?)"/>
    public static long BeNegativeOrZero(this It _, long argument, string? message = null, [CallerArgumentExpression("argument")] string? paramName = null) {
        return argument <= 0L
            ? argument
            : throw new ArgumentOutOfRangeException(message ?? $"The argument {paramName} cannot be positive.", paramName);
    }

    /// <inheritdoc cref="BeNegativeOrZero(It,int,string?,string?)"/>
    public static float BeNegativeOrZero(this It _, float argument, string? message = null, [CallerArgumentExpression("argument")] string? paramName = null) {
        return argument <= 0F
            ? argument
            : throw new ArgumentOutOfRangeException(message ?? $"The argument {paramName} cannot be positive.", paramName);
    }

    /// <inheritdoc cref="BeNegativeOrZero(It,int,string?,string?)"/>
    public static double BeNegativeOrZero(this It _, double argument, string? message = null, [CallerArgumentExpression("argument")] string? paramName = null) {
        return argument <= 0D
            ? argument
            : throw new ArgumentOutOfRangeException(message ?? $"The argument {paramName} cannot be positive.", paramName);
    }

    /// <inheritdoc cref="BeNegativeOrZero(It,int,string?,string?)"/>
    public static decimal BeNegativeOrZero(this It _, decimal argument, string? message = null, [CallerArgumentExpression("argument")] string? paramName = null) {
        return argument <= 0M
            ? argument
            : throw new ArgumentOutOfRangeException(message ?? $"The argument {paramName} cannot be positive.", paramName);
    }

    /// <inheritdoc cref="BeNegativeOrZero(It,int,string?,string?)"/>
    public static short BeNegativeOrZero(this It _, short argument, string? message = null, [CallerArgumentExpression("argument")] string? paramName = null) {
        return argument <= 0
            ? argument
            : throw new ArgumentOutOfRangeException(message ?? $"The argument {paramName} cannot be positive.", paramName);
    }

    /// <inheritdoc cref="BeNegativeOrZero(It,int,string?,string?)"/>
    public static TimeSpan BeNegativeOrZero(this It _, TimeSpan argument, string? message = null, [CallerArgumentExpression("argument")] string? paramName = null) {
        return argument <= TimeSpan.Zero
            ? argument
            : throw new ArgumentOutOfRangeException(message ?? $"The argument {paramName} cannot be positive.", paramName);
    }
}
