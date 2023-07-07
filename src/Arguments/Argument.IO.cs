// Copyright (c) Mahmoud Shaheen, 2021. All rights reserved.
// Licensed under the Apache 2.0 license.
// See the LICENSE.txt file in the project root for full license information.

using System.Runtime.CompilerServices;
using System.Text.RegularExpressions;

namespace X.Arguments;

public static partial class Argument {
    /// <summary>Throws an <see cref="ArgumentOutOfRangeException" /> if <paramref name="stream" /> is not support reading.</summary>
    /// <param name="stream">The argument <see cref="Stream"/> instance to check.</param>
    /// <param name="paramName">Parameter name (auto generated no need to pass it).</param>
    /// <exception cref="ArgumentException">Thrown if <paramref name="stream"/> doesn't support reading.</exception>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static void CanRead(Stream stream, [CallerArgumentExpression(nameof(stream))] string? paramName = null)
    {
        if (stream.CanRead)
        {
            return;
        }

        throw new ArgumentException($"Stream {_AssertString(paramName)} ({stream.GetType().Name}) doesn't support reading.", paramName);
    }


    /// <summary>Throws an <see cref="ArgumentOutOfRangeException" /> if <paramref name="stream" /> is not support writing.</summary>
    /// <param name="stream">The argument <see cref="Stream"/> instance to check.</param>
    /// <param name="paramName">Parameter name (auto generated no need to pass it).</param>
    /// <exception cref="ArgumentException">Thrown if <paramref name="stream"/> doesn't support writing.</exception>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static void CanWrite(Stream stream, [CallerArgumentExpression(nameof(stream))] string? paramName = null)
    {
        if (stream.CanWrite)
        {
            return;
        }

        throw new ArgumentException($"Stream {_AssertString(paramName)} ({stream.GetType().Name}) doesn't support writing.", paramName);
    }

    /// <summary>Throws an <see cref="ArgumentOutOfRangeException" /> if <paramref name="stream" /> is not support seeking.</summary>
    /// <param name="stream">The argument <see cref="Stream"/> instance to check.</param>
    /// <param name="paramName">Parameter name (auto generated no need to pass it).</param>
    /// <exception cref="ArgumentException">Thrown if <paramref name="stream"/> doesn't support seeking.</exception>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static void CanSeek(Stream stream, [CallerArgumentExpression(nameof(stream))] string? paramName = null)
    {
        if (stream.CanSeek)
        {
            return;
        }

        throw new ArgumentException($"Stream {_AssertString(paramName)} ({stream.GetType().Name}) doesn't support reading.", paramName);
    }

    /// <summary>Throws an <see cref="ArgumentOutOfRangeException" /> if <paramref name="stream" /> is not at the starting position.</summary>
    /// <param name="stream">The argument <see cref="Stream"/> instance to check.</param>
    /// <param name="paramName">Parameter name (auto generated no need to pass it).</param>
    /// <exception cref="ArgumentException">Thrown if <paramref name="stream"/> is not at the starting position.</exception>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static void IsAtStartPosition(Stream stream, [CallerArgumentExpression(nameof(stream))] string? paramName = null)
    {
        if (stream.Position == 0)
        {
            return;
        }

        throw new ArgumentException($"Stream {_AssertString(paramName)} ({stream.GetType().Name}) is not at the starting position.", paramName);
    }
}
