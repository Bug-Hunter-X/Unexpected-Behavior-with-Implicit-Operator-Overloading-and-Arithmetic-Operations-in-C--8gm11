# Unexpected Behavior with Implicit Operator Overloading and Arithmetic Operations in C#

This repository demonstrates a subtle but potentially problematic issue related to implicit operator overloading in C#. When you overload implicit operators to convert between custom classes and built-in types (like `int`), combining them with arithmetic operations can lead to unexpected compiler errors.

The `bug.cs` file shows an example where implicit conversions work fine for basic assignments but fail when attempting arithmetic operations. The `bugSolution.cs` shows how to address this issue by explicitly defining a suitable operator.