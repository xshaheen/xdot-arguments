// Copyright (c) Mahmoud Shaheen, 2021. All rights reserved.
// Licensed under the Apache 2.0 license.
// See the LICENSE.txt file in the project root for full license information.

using System.Runtime.CompilerServices;
using System.Text.RegularExpressions;

namespace X.Arguments;

public static partial class Argument {
    /// <summary>
    /// Throws an <see cref="ArgumentException" /> if  <paramref name="argument"/> doesn't match the <paramref name="pattern"/>.
    /// </summary>
    /// <param name="argument">The argument to check.</param>
    /// <param name="pattern"></param>
    /// <param name="message">(Optional) Custom error message</param>
    /// <param name="paramName">Parameter name (auto generated no need to pass it).</param>
    /// <returns><paramref name="argument" /> if the value matches <paramref name="pattern"/>.</returns>
    /// <exception cref="ArgumentException">if <paramref name="argument" /> is not match <paramref name="pattern"/>.</exception>
    // ReSharper disable once ParameterOnlyUsedForPreconditionCheck.Global
    public static string Matches(string argument, Regex pattern, string? message = null, [CallerArgumentExpression("argument")] string? paramName = null) {
        if (!pattern.IsMatch(argument)) {
            throw new ArgumentException(message ?? $"Argument {paramName} was not in required format.", paramName);
        }

        return argument;
    }
}
