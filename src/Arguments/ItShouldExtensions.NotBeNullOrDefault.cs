// Copyright (c) Mahmoud Shaheen, 2021. All rights reserved.
// Licensed under the Apache 2.0 license.
// See the LICENSE.txt file in the project root for full license information.

using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;

namespace X.Arguments;

public static partial class ItShouldExtensions {
    /// <summary>
    /// Throws an <see cref="ArgumentNullException" /> if <paramref name="argument" /> is null.
    /// Throws an <see cref="ArgumentException" /> if <paramref name="argument" /> is default(T).
    /// </summary>
    /// <param name="_"></param>
    /// <param name="argument">The argument to check.</param>
    /// <param name="message">(Optional) Custom error message.</param>
    /// <param name="paramName">Parameter name (auto generated no need to pass it).</param>
    /// <returns><paramref name="paramName" /> if the value is not null or default(T).</returns>
    /// <exception cref="ArgumentNullException">if <paramref name="argument" /> is null.</exception>
    /// <exception cref="ArgumentException">if <paramref name="argument" /> is default for that type.</exception>
    public static T NotBeNullOrDefault<T>(this It _, [NotNull] T? argument, string? message = null, [CallerArgumentExpression("argument")] string? paramName = null) where T : struct {
        NotBeNull(_, argument, message, paramName);
        NotBeDefault(_, argument.Value, message, paramName);

        return argument.Value;
    }
}
