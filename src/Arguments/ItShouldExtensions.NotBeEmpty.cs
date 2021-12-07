// Copyright (c) Mahmoud Shaheen, 2021. All rights reserved.
// Licensed under the Apache 2.0 license.
// See the LICENSE.txt file in the project root for full license information.

using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using NoEnumeration = JetBrains.Annotations.NoEnumerationAttribute;

namespace X.Arguments;

// ReSharper disable PossibleMultipleEnumeration
public static partial class ItShouldExtensions {
    /// <summary>Throws an <see cref="ArgumentException" /> if <paramref name="argument" /> is empty.</summary>
    /// <param name="_"></param>
    /// <param name="argument">The argument to check.</param>
    /// <param name="message">(Optional) Custom error message.</param>
    /// <param name="paramName">Parameter name (auto generated no need to pass it).</param>
    /// <returns><paramref name="paramName" /> if the value is not empty.</returns>
    /// <exception cref="ArgumentException">if <paramref name="argument" /> is empty.</exception>
    [return: NotNullIfNotNull("argument")]
    public static IReadOnlyCollection<T>? NotBeEmpty<T>(this It _, IReadOnlyCollection<T>? argument, string? message = null, [CallerArgumentExpression("argument")] string? paramName = null) {
        return argument is { Count: 0 }
            ? throw new ArgumentException(message ?? "Required argument " + paramName + " was empty.", paramName)
            : argument;
    }

    /// <inheritdoc cref="NotBeEmpty{T}(It,IReadOnlyCollection{T}?,string?,string?)"/>
    [return: NotNullIfNotNull("argument")]
    public static IEnumerable<T>? NotBeEmpty<T>(this It _, [NoEnumeration] IEnumerable<T>? argument, string? message = null, [CallerArgumentExpression("argument")] string? paramName = null) {
        if (argument is null) {
            return argument;
        }

        if (!argument.Any()) {
            throw new ArgumentException(message ?? "Required argument " + paramName + " was empty.", paramName);
        }

        return argument;
    }

    /// <inheritdoc cref="NotBeEmpty{T}(It,IReadOnlyCollection{T}?,string?,string?)"/>
    [return: NotNullIfNotNull("argument")]
    public static string? NotBeEmpty(this It _, string? argument, string? message = null, [CallerArgumentExpression("argument")] string? paramName = null) {
        return argument is { Length: 0 }
            ? throw new ArgumentException(message ?? "Required argument " + paramName + " was empty.", paramName)
            : argument;
    }
}
