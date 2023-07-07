// Copyright (c) Mahmoud Shaheen, 2021. All rights reserved.
// Licensed under the Apache 2.0 license.
// See the LICENSE.txt file in the project root for full license information.

using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;

namespace X.Arguments;

public static partial class Argument {
    /// <summary>
    /// Throws an <see cref="ArgumentNullException" /> if <paramref name="argument" /> is null.
    /// Throws an <see cref="ArgumentException" /> if <paramref name="argument" /> is an empty or white space string.
    /// </summary>
    /// <param name="argument">The argument to check.</param>
    /// <param name="message">(Optional) Custom error message.</param>
    /// <param name="paramName">Parameter name (auto generated no need to pass it).</param>
    /// <returns><paramref name="paramName" /> if the value is not null, or an empty or white space string.</returns>
    /// <exception cref="ArgumentNullException">if <paramref name="argument" /> is null.</exception>
    /// <exception cref="ArgumentException">if <paramref name="argument" /> is an empty or white space string.</exception>
    public static string IsNotNullOrWhiteSpace([NotNull] string? argument, string? message = null, [CallerArgumentExpression(nameof(argument))] string? paramName = null) {
        IsNotNull(argument, message, paramName);
        IsNotEmpty(argument, message, paramName);

        if (_IsWhiteSpace(argument)) {
            throw new ArgumentException(message ?? $"Required argument {_AssertString(paramName)} was empty.", paramName);
        }

        return argument;
    }

    private static bool _IsWhiteSpace(string value) {
        for (var i = 0; i < value.Length; i++) {
            if (!char.IsWhiteSpace(value[i])) {
                return false;
            }
        }

        return true;
    }
}
