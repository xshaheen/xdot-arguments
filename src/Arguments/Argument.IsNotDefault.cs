// Copyright (c) Mahmoud Shaheen, 2021. All rights reserved.
// Licensed under the Apache 2.0 license.
// See the LICENSE.txt file in the project root for full license information.

using System.Runtime.CompilerServices;

namespace X.Arguments;

public static partial class Argument {
    /// <summary>Throws an <see cref="ArgumentException" /> if <paramref name="argument" /> is default(T).</summary>
    /// <param name="argument">The argument to check.</param>
    /// <param name="message">(Optional) Custom error message.</param>
    /// <param name="paramName">Parameter name (auto generated no need to pass it).</param>
    /// <returns><paramref name="argument" /> if the value is not default for that type.</returns>
    /// <exception cref="ArgumentException">if <paramref name="argument" /> is default for that type.</exception>
    public static T IsNotDefault<T>(T argument, string? message = null, [CallerArgumentExpression(nameof(argument))] string? paramName = null) where T : struct {
        if (EqualityComparer<T>.Default.Equals(argument, default)) {
            throw new ArgumentException(message ?? $"{_AssertString(paramName)} cannot be the default value of {typeof(T).Name}.", paramName);
        }

        return argument;
    }

    /// <inheritdoc cref="IsNotDefault{T}(T,string?,string?)"/>
    public static T? IsNotDefault<T>(T? argument, string? message = null, [CallerArgumentExpression(nameof(argument))] string? paramName = null) where T : struct {
        if (argument is null) {
            return argument;
        }

        if (EqualityComparer<T>.Default.Equals(argument.Value, default)) {
            throw new ArgumentException(message ?? $"{_AssertString(paramName)} cannot be the default value of {typeof(T).Name}.", paramName);
        }

        return argument;
    }
}
