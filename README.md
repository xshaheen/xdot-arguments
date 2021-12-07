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
It.Should.BeInEnum();
It.Should.BeNegative();
It.Should.BeNegativeOrZero();
It.Should.BePositive();
It.Should.BePositiveOrZero();
It.Should.BeOneOf();
It.Should.Be();
It.Should.BeLessThan();
It.Should.BeLessThanOrEqualTo();
It.Should.BeGreaterThan();
It.Should.BeGreaterThanOrEqualTo();
It.Should.BeInclusiveBetween();
It.Should.BeExclusiveBetween();
It.Should.BeLeftOpenedBetween();
It.Should.BeRightOpenedBetween();
It.Should.BeHaveItemsInRange();
It.Should.NotBeDefault();
It.Should.NotBeEmpty();
It.Should.NotBeNull();
It.Should.NotBeNullOrDefault();
It.Should.NotBeNullOrEmpty();
It.Should.NotBeNullOrWhiteSpace();
It.Should.HasNoNulls();
It.Should.HasNoNullOrEmptyElements();
It.Should.HasNoNullOrWhiteSpaceElements();
It.Should.Matches();
```

## License

This project is licensed under the Apache 2.0 license.

## Contact

If you have any suggestions, comments or questions, please feel free to contact me on:

Email: mxshaheen@gmail.com

[arguments-in-package]: https://www.nuget.org/packages/Xdot.Arguments/
[dotnet-core-cli-tools]: https://docs.microsoft.com/en-us/dotnet/core/tools/
