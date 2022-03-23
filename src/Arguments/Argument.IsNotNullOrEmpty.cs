// Copyright (c) Mahmoud Shaheen, 2021. All rights reserved.
// Licensed under the Apache 2.0 license.
// See the LICENSE.txt file in the project root for full license information.

using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using NoEnumeration = JetBrains.Annotations.NoEnumerationAttribute;

namespace X.Arguments;

public static partial class Argument {
    /// <summary>Throws an <see cref="ArgumentException" /> if <paramref name="argument" /> is null or empty.</summary>
    /// <param name="argument">The argument to check.</param>
    /// <param name="message">(Optional) Custom error message.</param>
    /// <param name="paramName">Parameter name (auto generated no need to pass it).</param>
    /// <returns><paramref name="paramName" /> if the value is not null or empty.</returns>
    /// <exception cref="ArgumentException">if <paramref name="argument" /> is null or empty.</exception>
    public static IReadOnlyCollection<T> IsNotNullOrEmpty<T>([NotNull] IReadOnlyCollection<T>? argument, string? message = null, [CallerArgumentExpression("argument")] string? paramName = null) {
        IsNotNull(argument, message, paramName);
        IsNotEmpty(argument, message, paramName);

        return argument;
    }

    /// <inheritdoc cref="IsNotNullOrEmpty{T}(System.Collections.Generic.IEnumerable{T}?,string?,string?)"/>
    public static IEnumerable<T> IsNotNullOrEmpty<T>([NoEnumeration][NotNull] IEnumerable<T>? argument, string? message = null, [CallerArgumentExpression("argument")] string? paramName = null) {
        IsNotNull(argument, message, paramName);
        IsNotEmpty(argument, message, paramName);

        return argument;
    }

    /// <inheritdoc cref="IsNotNullOrEmpty{T}(System.Collections.Generic.IEnumerable{T}?,string?,string?)"/>
    public static string IsNotNullOrEmpty([NotNull] string? argument, string? message = null, [CallerArgumentExpression("argument")] string? paramName = null) {
        IsNotNull(argument, message, paramName);
        IsNotEmpty(argument, message, paramName);

        return argument;
    }
}
