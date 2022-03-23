# Xdot.Arguments

[![GitHub Actions Status](https://github.com/xshaheen/xdot-arguments/actions/workflows/ci.yml/badge.svg?branch=main)](https://github.com/xshaheen/xdot-arguments/actions) [![xdot-arguments NuGet Package Downloads](https://img.shields.io/nuget/dt/Xdot.Arguments)](https://www.nuget.org/packages/Xdot.Arguments)

Argument validation clauses.

**if you like this work, please consider give the project star 🌟**

## Installation

Using the [.NET CLI tools][dotnet-core-cli-tools]:

```sh
dotnet add package Xdot.Arguments
```

## Usage

```c#
Argument.IsInEnum();
Argument.IsNegative();
Argument.IsNegativeOrZero();
Argument.IsPositive();
Argument.IsPositiveOrZero();
Argument.IsOneOf();
Argument.IsEqualTo();
Argument.IsLessThan();
Argument.IsLessThanOrEqualTo();
Argument.IsGreaterThan();
Argument.IsGreaterThanOrEqualTo();
Argument.IsInclusiveBetween();
Argument.IsExclusiveBetween();
Argument.IsLeftOpenedBetween();
Argument.IsRightOpenedBetween();
Argument.HaveItemsInRange();
Argument.IsNotDefault();
Argument.IsNotEmpty();
Argument.IsNotNull();
Argument.IsNotNullOrDefault();
Argument.IsNotNullOrEmpty();
Argument.IsNotNullOrWhiteSpace();
Argument.HasNoNulls();
Argument.HasNoNullOrEmptyElements();
Argument.HasNoNullOrWhiteSpaceElements();
Argument.Matches();
```

## License

This project is licensed under the Apache 2.0 license.

## Contact

If you have any suggestions, comments or questions, please feel free to contact me on:

Email: mxshaheen@gmail.com

[arguments-in-package]: https://www.nuget.org/packages/Xdot.Arguments/
[dotnet-core-cli-tools]: https://docs.microsoft.com/en-us/dotnet/core/tools/
