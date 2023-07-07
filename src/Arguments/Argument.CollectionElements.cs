// Copyright (c) Mahmoud Shaheen, 2021. All rights reserved.
// Licensed under the Apache 2.0 license.
// See the LICENSE.txt file in the project root for full license information.

using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;

namespace X.Arguments;

public static partial class Argument {
    /// <summary>Throws an <see cref="ArgumentException" /> if <paramref name="argument" /> has any null element.</summary>
    /// <param name="argument">The argument to check.</param>
    /// <param name="message">(Optional) Custom error message.</param>
    /// <param name="paramName">Parameter name (auto generated no need to pass it).</param>
    /// <returns><paramref name="paramName" /> if the argument has not null.</returns>
    /// <exception cref="ArgumentOutOfRangeException">if <paramref name="argument" /> has any null element.</exception>
    public static IReadOnlyCollection<T> HasNoNulls<T>([NotNull] IReadOnlyCollection<T?>? argument, string? message = null, [CallerArgumentExpression(nameof(argument))] string? paramName = null) where T : class {
        IsNotNull(argument, paramName);

        if (argument.Any(e => e is null)) {
            throw new ArgumentException(message ?? $"The argument {_AssertString(paramName)} cannot contains null elements.", paramName);
        }

        return argument!;
    }

    /// <summary>Throws an <see cref="ArgumentException" /> if <paramref name="argument" /> has any null or empty element.</summary>
    /// <param name="argument">The argument to check.</param>
    /// <param name="message">(Optional) Custom error message.</param>
    /// <param name="paramName">Parameter name (auto generated no need to pass it).</param>
    /// <returns><paramref name="paramName" /> if the argument has not null or empty element.</returns>
    /// <exception cref="ArgumentOutOfRangeException">if <paramref name="argument" /> has any null or empty element.</exception>
    public static IReadOnlyCollection<string> HasNoNullOrEmptyElements([NotNull] IReadOnlyCollection<string?>? argument, string? message = null, [CallerArgumentExpression(nameof(argument))] string? paramName = null) {
        IsNotNull(argument, paramName);

        if (argument.Any(string.IsNullOrEmpty)) {
            throw new ArgumentException(message ?? $"The argument {_AssertString(paramName)} cannot contains empty elements.", paramName);
        }

        return argument!;
    }

    /// <summary>Throws an <see cref="ArgumentException" /> if <paramref name="argument" /> has any null or white space element.</summary>
    /// <param name="argument">The argument to check.</param>
    /// <param name="message">(Optional) Custom error message.</param>
    /// <param name="paramName">Parameter name (auto generated no need to pass it).</param>
    /// <returns><paramref name="paramName" /> if the argument has not null or white space element.</returns>
    /// <exception cref="ArgumentOutOfRangeException">if <paramref name="argument" /> has any null or white space element.</exception>
    public static IReadOnlyCollection<string> HasNoNullOrWhiteSpaceElements([NotNull] IReadOnlyCollection<string?>? argument, string? message = null, [CallerArgumentExpression(nameof(argument))] string? paramName = null) {
        IsNotNull(argument, paramName);

        if (argument.Any(string.IsNullOrWhiteSpace)) {
            throw new ArgumentException(message ?? $"The argument {_AssertString(paramName)} cannot contains empty or white space elements.", paramName);
        }

        return argument!;
    }
}
