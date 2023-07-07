// Copyright (c) Mahmoud Shaheen, 2021. All rights reserved.
// Licensed under the Apache 2.0 license.
// See the LICENSE.txt file in the project root for full license information.

using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using NoEnumeration = JetBrains.Annotations.NoEnumerationAttribute;

namespace X.Arguments;

public static partial class Argument {
    /// <summary>Throws an <see cref="ArgumentNullException" /> if <paramref name="argument" /> is null.</summary>
    /// <param name="argument">The argument to check.</param>
    /// <param name="message">(Optional) Custom error message.</param>
    /// <param name="paramName">Parameter name (auto generated no need to pass it).</param>
    /// <returns><paramref name="argument" /> if the argument is not null.</returns>
    /// <exception cref="ArgumentException">if <paramref name="argument" /> is null.</exception>
    [return: NotNull]
    public static T IsNotNull<T>([NoEnumeration][NotNull] T? argument, string? message = null, [CallerArgumentExpression(nameof(argument))] string? paramName = null) {
        if (argument is null) {
            if (message is null) {
                throw new ArgumentNullException(paramName);
            }

            throw new ArgumentNullException(paramName, message);
        }

        return argument;
    }
}
