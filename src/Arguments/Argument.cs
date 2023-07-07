// Copyright (c) Mahmoud Shaheen, 2021. All rights reserved.
// Licensed under the Apache 2.0 license.
// See the LICENSE.txt file in the project root for full license information.

namespace X.Arguments;

public static partial class Argument {
    private static string _AssertString(object? obj)
    {
        return obj switch
        {
            string => $"\"{obj}\"",
            null => "null",
            _ => $"<{obj}>",
        };
    }
}
