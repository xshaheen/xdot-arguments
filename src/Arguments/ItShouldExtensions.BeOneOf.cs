// Copyright (c) Mahmoud Shaheen, 2021. All rights reserved.
// Licensed under the Apache 2.0 license.
// See the LICENSE.txt file in the project root for full license information.

using System.Runtime.CompilerServices;

namespace X.Arguments;

public static partial class ItShouldExtensions {
    /// <summary>
    /// Throws an <see cref="ArgumentException" /> if <paramref name="argument"/> is not one of the <paramref name="validValues"/>.
    /// </summary>
    /// <param name="_"></param>
    /// <param name="argument">The argument to check.</param>
    /// <param name="validValues">The valid values.</param>
    /// <param name="message">(Optional) Custom error message</param>
    /// <param name="paramName">Parameter name (auto generated no need to pass it).</param>
    /// <returns><paramref name="argument" /> if value is not one of the <paramref name="validValues"/>.</returns>
    /// <exception cref="ArgumentException"></exception>
    public static int BeOneOf(this It _, int argument, IReadOnlyCollection<int> validValues, string? message = null, [CallerArgumentExpression("argument")] string? paramName = null) {
        if (validValues.Contains(argument)) {
            return argument;
        }

        throw new ArgumentException(message ?? $"Expected {paramName} to be one of [{validValues.Aggregate("", (p, c) => p + "," + c.ToString(CultureInfo.InvariantCulture))}], but found {argument.ToString(CultureInfo.InvariantCulture)}.", paramName);
    }

    /// <inheritdoc cref="BeOneOf(It,int,IReadOnlyCollection{int},string?,string?)"/>
    public static long BeOneOf(this It _, long argument, IReadOnlyCollection<long> validValues, string? message = null, [CallerArgumentExpression("argument")] string? paramName = null) {
        if (validValues.Contains(argument)) {
            return argument;
        }

        throw new ArgumentException(message ?? $"Expected {paramName} to be one of [{validValues.Aggregate("", (p, c) => p + "," + c.ToString(CultureInfo.InvariantCulture))}], but found {argument.ToString(CultureInfo.InvariantCulture)}.", paramName);
    }

    /// <inheritdoc cref="BeOneOf(It,int,IReadOnlyCollection{int},string?,string?)"/>
    public static decimal BeOneOf(this It _, decimal argument, IReadOnlyCollection<decimal> validValues, string? message = null, [CallerArgumentExpression("argument")] string? paramName = null) {
        if (validValues.Contains(argument)) {
            return argument;
        }

        throw new ArgumentException(message ?? $"Expected {paramName} to be one of [{validValues.Aggregate("", (p, c) => p + "," + c.ToString(CultureInfo.InvariantCulture))}], but found {argument.ToString(CultureInfo.InvariantCulture)}.", paramName);
    }

    /// <inheritdoc cref="BeOneOf(It,int,IReadOnlyCollection{int},string?,string?)"/>
    public static double BeOneOf(this It _, double argument, IReadOnlyCollection<double> validValues, string? message = null, [CallerArgumentExpression("argument")] string? paramName = null) {
        if (validValues.Contains(argument)) {
            return argument;
        }

        throw new ArgumentException(message ?? $"Expected {paramName} to be one of [{validValues.Aggregate("", (p, c) => p + "," + c.ToString(CultureInfo.InvariantCulture))}], but found {argument.ToString(CultureInfo.InvariantCulture)}.", paramName);
    }

    /// <inheritdoc cref="BeOneOf(It,int,IReadOnlyCollection{int},string?,string?)"/>
    public static float BeOneOf(this It _, float argument, IReadOnlyCollection<float> validValues, string? message = null, [CallerArgumentExpression("argument")] string? paramName = null) {
        if (validValues.Contains(argument)) {
            return argument;
        }

        throw new ArgumentException(message ?? $"Expected {paramName} to be one of [{validValues.Aggregate("", (p, c) => p + "," + c.ToString(CultureInfo.InvariantCulture))}], but found {argument.ToString(CultureInfo.InvariantCulture)}.", paramName);
    }

    /// <inheritdoc cref="BeOneOf(It,int,IReadOnlyCollection{int},string?,string?)"/>
    public static string BeOneOf(this It _, string argument, IReadOnlyList<string> validValues, StringComparer? comparer = null, string? message = null, [CallerArgumentExpression("argument")] string? paramName = null) {
        if (validValues.Contains(argument, comparer ?? StringComparer.Ordinal)) {
            return argument;
        }

        throw new ArgumentException(message ?? $"Expected {paramName} was out of range to be one of [{validValues.Aggregate("", (p, c) => p + "," + c)}], but found {argument}.", paramName);
    }
}
