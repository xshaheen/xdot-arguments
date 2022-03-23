// Copyright (c) Mahmoud Shaheen, 2021. All rights reserved.
// Licensed under the Apache 2.0 license.
// See the LICENSE.txt file in the project root for full license information.

using System.Runtime.CompilerServices;

namespace X.Arguments;

public static partial class Argument {
    /// <summary>Throws an <see cref="ArgumentOutOfRangeException" /> if <paramref name="argument" /> is non negative.</summary>
    /// <param name="argument">The argument to check.</param>
    /// <param name="message">(Optional) Custom error message.</param>
    /// <param name="paramName">Parameter name (auto generated no need to pass it).</param>
    /// <returns><paramref name="paramName" /> if the argument is negative.</returns>
    /// <exception cref="ArgumentOutOfRangeException">if <paramref name="argument" /> is non negative.</exception>
    public static int IsNegative(int argument, string? message = null, [CallerArgumentExpression("argument")] string? paramName = null) {
        return argument < 0
            ? argument
            : throw new ArgumentOutOfRangeException(message ?? $"The argument {paramName} cannot be non negative.", paramName);
    }

    /// <inheritdoc cref="IsNegative(int,string?,string?)"/>
    public static long IsNegative(long argument, string? message = null, [CallerArgumentExpression("argument")] string? paramName = null) {
        return argument < 0L
            ? argument
            : throw new ArgumentOutOfRangeException(message ?? $"The argument {paramName} cannot be non negative.", paramName);
    }

    /// <inheritdoc cref="IsNegative(int,string?,string?)"/>
    public static float IsNegative(float argument, string? message = null, [CallerArgumentExpression("argument")] string? paramName = null) {
        return argument < 0F
            ? argument
            : throw new ArgumentOutOfRangeException(message ?? $"The argument {paramName} cannot be non negative.", paramName);
    }

    /// <inheritdoc cref="IsNegative(int,string?,string?)"/>
    public static double IsNegative(double argument, string? message = null, [CallerArgumentExpression("argument")] string? paramName = null) {
        return argument < 0D
            ? argument
            : throw new ArgumentOutOfRangeException(message ?? $"The argument {paramName} cannot be non negative.", paramName);
    }

    /// <inheritdoc cref="IsNegative(int,string?,string?)"/>
    public static decimal IsNegative(decimal argument, string? message = null, [CallerArgumentExpression("argument")] string? paramName = null) {
        return argument < 0M
            ? argument
            : throw new ArgumentOutOfRangeException(message ?? $"The argument {paramName} cannot be non negative.", paramName);
    }

    /// <inheritdoc cref="IsNegative(int,string?,string?)"/>
    public static short IsNegative(short argument, string? message = null, [CallerArgumentExpression("argument")] string? paramName = null) {
        return argument < 0
            ? argument
            : throw new ArgumentOutOfRangeException(message ?? $"The argument {paramName} cannot be non negative.", paramName);
    }

    /// <inheritdoc cref="IsNegative(int,string?,string?)"/>
    public static TimeSpan IsNegative(TimeSpan argument, string? message = null, [CallerArgumentExpression("argument")] string? paramName = null) {
        return argument < TimeSpan.Zero
            ? argument
            : throw new ArgumentOutOfRangeException(message ?? $"The argument {paramName} cannot be non negative.", paramName);
    }
}
