// Copyright (c) Mahmoud Shaheen, 2021. All rights reserved.
// Licensed under the Apache 2.0 license.
// See the LICENSE.txt file in the project root for full license information.

using System.Runtime.CompilerServices;

namespace X.Arguments;

public static partial class ItShouldExtensions {
    /// <summary>Throws an <see cref="ArgumentOutOfRangeException" /> if <paramref name="argument" /> is negative.</summary>
    /// <param name="_"></param>
    /// <param name="argument">The argument to check.</param>
    /// <param name="message">(Optional) Custom error message.</param>
    /// <param name="paramName">Parameter name (auto generated no need to pass it).</param>
    /// <returns><paramref name="paramName" /> if the argument is not negative.</returns>
    /// <exception cref="ArgumentOutOfRangeException">if <paramref name="argument" /> is negative.</exception>
    public static int BePositive(this It _, int argument, string? message = null, [CallerArgumentExpression("argument")] string? paramName = null) {
        return argument > 0
            ? argument
            : throw new ArgumentOutOfRangeException(message ?? $"The argument {paramName} cannot be non positive.", paramName);
    }

    /// <inheritdoc cref="BePositive(It,int,string?,string?)"/>
    public static long BePositive(this It _, long argument, string? message = null, [CallerArgumentExpression("argument")] string? paramName = null) {
        return argument > 0L
            ? argument
            : throw new ArgumentOutOfRangeException(message ?? $"The argument {paramName} cannot be non positive.", paramName);
    }

    /// <inheritdoc cref="BePositive(It,int,string?,string?)"/>
    public static float BePositive(this It _, float argument, string? message = null, [CallerArgumentExpression("argument")] string? paramName = null) {
        return argument > 0F
            ? argument
            : throw new ArgumentOutOfRangeException(message ?? $"The argument {paramName} cannot be non positive.", paramName);
    }

    /// <inheritdoc cref="BePositive(It,int,string?,string?)"/>
    public static double BePositive(this It _, double argument, string? message = null, [CallerArgumentExpression("argument")] string? paramName = null) {
        return argument > 0D
            ? argument
            : throw new ArgumentOutOfRangeException(message ?? $"The argument {paramName} cannot be non positive.", paramName);
    }

    /// <inheritdoc cref="BePositive(It,int,string?,string?)"/>
    public static decimal BePositive(this It _, decimal argument, string? message = null, [CallerArgumentExpression("argument")] string? paramName = null) {
        return argument > 0M
            ? argument
            : throw new ArgumentOutOfRangeException(message ?? $"The argument {paramName} cannot be non positive.", paramName);
    }

    /// <inheritdoc cref="BePositive(It,int,string?,string?)"/>
    public static short BePositive(this It _, short argument, string? message = null, [CallerArgumentExpression("argument")] string? paramName = null) {
        return argument > 0
            ? argument
            : throw new ArgumentOutOfRangeException(message ?? $"The argument {paramName} cannot be non positive.", paramName);
    }

    /// <inheritdoc cref="BePositive(It,int,string?,string?)"/>
    public static TimeSpan BePositive(this It _, TimeSpan argument, string? message = null, [CallerArgumentExpression("argument")] string? paramName = null) {
        return argument > TimeSpan.Zero
            ? argument
            : throw new ArgumentOutOfRangeException(message ?? $"The argument {paramName} cannot be non positive.", paramName);
    }
}
