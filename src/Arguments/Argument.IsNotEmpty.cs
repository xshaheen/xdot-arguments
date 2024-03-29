// Copyright (c) Mahmoud Shaheen, 2021. All rights reserved.
// Licensed under the Apache 2.0 license.
// See the LICENSE.txt file in the project root for full license information.

using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using NoEnumeration = JetBrains.Annotations.NoEnumerationAttribute;

namespace X.Arguments;

// ReSharper disable PossibleMultipleEnumeration
public static partial class Argument {
    /// <summary>Throws an <see cref="ArgumentException" /> if <paramref name="argument" /> is empty.</summary>
    /// <param name="argument">The argument to check.</param>
    /// <param name="message">(Optional) Custom error message.</param>
    /// <param name="paramName">Parameter name (auto generated no need to pass it).</param>
    /// <returns><paramref name="paramName" /> if the value is not empty.</returns>
    /// <exception cref="ArgumentException">if <paramref name="argument" /> is empty.</exception>
    [return: NotNullIfNotNull(nameof(argument))]
    public static IReadOnlyCollection<T>? IsNotEmpty<T>(IReadOnlyCollection<T>? argument, string? message = null, [CallerArgumentExpression(nameof(argument))] string? paramName = null) {
        return argument is { Count: 0 }
            ? throw new ArgumentException(message ?? "Required argument " + paramName + " was empty.", paramName)
            : argument;
    }

    /// <inheritdoc cref="IsNotEmpty{T}(IReadOnlyCollection{T}?,string?,string?)"/>
    [return: NotNullIfNotNull(nameof(argument))]
    public static IEnumerable<T>? IsNotEmpty<T>([NoEnumeration] IEnumerable<T>? argument, string? message = null, [CallerArgumentExpression(nameof(argument))] string? paramName = null) {
        if (argument is null) {
            return argument;
        }

        if (!argument.Any()) {
            throw new ArgumentException(message ?? "Required argument " + paramName + " was empty.", paramName);
        }

        return argument;
    }

    /// <inheritdoc cref="IsNotEmpty{T}(IReadOnlyCollection{T}?,string?,string?)"/>
    [return: NotNullIfNotNull(nameof(argument))]
    public static string? IsNotEmpty(string? argument, string? message = null, [CallerArgumentExpression(nameof(argument))] string? paramName = null) {
        return argument is { Length: 0 }
            ? throw new ArgumentException(message ?? "Required argument " + paramName + " was empty.", paramName)
            : argument;
    }
}
