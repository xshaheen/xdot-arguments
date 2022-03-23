// Copyright (c) Mahmoud Shaheen, 2021. All rights reserved.
// Licensed under the Apache 2.0 license.
// See the LICENSE.txt file in the project root for full license information.

using System.Runtime.CompilerServices;

namespace X.Arguments;

public static partial class Argument {
    /// <summary>
    /// Throws an <see cref="ArgumentException" /> if <paramref name="argument"/> is not one of the <paramref name="validValues"/>.
    /// </summary>
    /// <param name="argument">The argument to check.</param>
    /// <param name="validValues">The valid values.</param>
    /// <param name="message">(Optional) Custom error message</param>
    /// <param name="paramName">Parameter name (auto generated no need to pass it).</param>
    /// <returns><paramref name="argument" /> if value is not one of the <paramref name="validValues"/>.</returns>
    /// <exception cref="ArgumentException"></exception>
    public static int IsOneOf(int argument, IReadOnlyCollection<int> validValues, string? message = null, [CallerArgumentExpression("argument")] string? paramName = null) {
        if (validValues.Contains(argument)) {
            return argument;
        }

        throw new ArgumentException(message ?? $"Expected {paramName} to be one of [{validValues.Aggregate("", (p, c) => p + "," + c.ToString(CultureInfo.InvariantCulture))}], but found {argument.ToString(CultureInfo.InvariantCulture)}.", paramName);
    }

    /// <inheritdoc cref="IsOneOf(int,IReadOnlyCollection{int},string?,string?)"/>
    public static long IsOneOf(long argument, IReadOnlyCollection<long> validValues, string? message = null, [CallerArgumentExpression("argument")] string? paramName = null) {
        if (validValues.Contains(argument)) {
            return argument;
        }

        throw new ArgumentException(message ?? $"Expected {paramName} to be one of [{validValues.Aggregate("", (p, c) => p + "," + c.ToString(CultureInfo.InvariantCulture))}], but found {argument.ToString(CultureInfo.InvariantCulture)}.", paramName);
    }

    /// <inheritdoc cref="IsOneOf(int,IReadOnlyCollection{int},string?,string?)"/>
    public static decimal IsOneOf(decimal argument, IReadOnlyCollection<decimal> validValues, string? message = null, [CallerArgumentExpression("argument")] string? paramName = null) {
        if (validValues.Contains(argument)) {
            return argument;
        }

        throw new ArgumentException(message ?? $"Expected {paramName} to be one of [{validValues.Aggregate("", (p, c) => p + "," + c.ToString(CultureInfo.InvariantCulture))}], but found {argument.ToString(CultureInfo.InvariantCulture)}.", paramName);
    }

    /// <inheritdoc cref="IsOneOf(int,IReadOnlyCollection{int},string?,string?)"/>
    public static double IsOneOf(double argument, IReadOnlyCollection<double> validValues, string? message = null, [CallerArgumentExpression("argument")] string? paramName = null) {
        if (validValues.Contains(argument)) {
            return argument;
        }

        throw new ArgumentException(message ?? $"Expected {paramName} to be one of [{validValues.Aggregate("", (p, c) => p + "," + c.ToString(CultureInfo.InvariantCulture))}], but found {argument.ToString(CultureInfo.InvariantCulture)}.", paramName);
    }

    /// <inheritdoc cref="IsOneOf(int,IReadOnlyCollection{int},string?,string?)"/>
    public static float IsOneOf(float argument, IReadOnlyCollection<float> validValues, string? message = null, [CallerArgumentExpression("argument")] string? paramName = null) {
        if (validValues.Contains(argument)) {
            return argument;
        }

        throw new ArgumentException(message ?? $"Expected {paramName} to be one of [{validValues.Aggregate("", (p, c) => p + "," + c.ToString(CultureInfo.InvariantCulture))}], but found {argument.ToString(CultureInfo.InvariantCulture)}.", paramName);
    }

    /// <inheritdoc cref="IsOneOf(int,IReadOnlyCollection{int},string?,string?)"/>
    public static string IsOneOf(string argument, IReadOnlyList<string> validValues, StringComparer? comparer = null, string? message = null, [CallerArgumentExpression("argument")] string? paramName = null) {
        if (validValues.Contains(argument, comparer ?? StringComparer.Ordinal)) {
            return argument;
        }

        throw new ArgumentException(message ?? $"Expected {paramName} was out of range to be one of [{validValues.Aggregate("", (p, c) => p + "," + c)}], but found {argument}.", paramName);
    }
}
