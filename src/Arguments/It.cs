// Copyright (c) Mahmoud Shaheen, 2021. All rights reserved.
// Licensed under the Apache 2.0 license.
// See the LICENSE.txt file in the project root for full license information.

namespace X.Arguments;

public sealed class It {
    private It() { }

    public static It Should { get; } = new();
}
