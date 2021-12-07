// Copyright (c) Mahmoud Shaheen, 2021. All rights reserved.
// Licensed under the Apache 2.0 license.
// See the LICENSE.txt file in the project root for full license information.

using System.Runtime.CompilerServices;

namespace X.Arguments;

public static partial class ItShouldExtensions {
    /// <summary>Throws an <see cref="ArgumentException" /> if <paramref name="argument" /> is default(T).</summary>
    /// <param name="_"></param>
    /// <param name="argument">The argument to check.</param>
    /// <param name="message">(Optional) Custom error message.</param>
    /// <param name="paramName">Parameter name (auto generated no need to pass it).</param>
    /// <returns><paramref name="argument" /> if the value is not default for that type.</returns>
    /// <exception cref="ArgumentException">if <paramref name="argument" /> is default for that type.</exception>
    public static T NotBeDefault<T>(this It _, T argument, string? message = null, [CallerArgumentExpression("argument")] string? paramName = null) where T : struct {
        if (EqualityComparer<T>.Default.Equals(argument, default)) {
            throw new ArgumentException(message ?? $"{paramName} cannot be the default value of {typeof(T).Name}.", paramName);
        }

        return argument;
    }

    /// <inheritdoc cref="NotBeDefault{T}(It,T,string?,string?)"/>
    public static T? NotBeDefault<T>(this It _, T? argument, string? message = null, [CallerArgumentExpression("argument")] string? paramName = null) where T : struct {
        if (argument is null) {
            return argument;
        }

        if (EqualityComparer<T>.Default.Equals(argument.Value, default)) {
            throw new ArgumentException(message ?? $"{paramName} cannot be the default value of {typeof(T).Name}.", paramName);
        }

        return argument;
    }
}
