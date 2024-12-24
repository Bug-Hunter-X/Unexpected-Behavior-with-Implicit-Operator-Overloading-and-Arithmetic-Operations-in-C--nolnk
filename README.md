# Unexpected Behavior with Implicit Operator Overloading and Arithmetic Operations in C#

This repository demonstrates a potential issue with implicit operator overloading in C# when combined with arithmetic operations.  Implicit conversions can lead to unexpected behavior if not carefully considered.

The `bug.cs` file contains code exhibiting this issue. The `bugSolution.cs` file shows a corrected approach.

## Issue Description

Implicit operator overloading allows seamless conversion between custom classes and built-in types. However, combining this with standard arithmetic operations can result in unexpected outcomes if the operators aren't implemented correctly within the custom class. 

The issue lies in how the addition operation (`+`) is implicitly handled when applied to an instance of the custom class (`MyClass`) and an integer.

## Solution

The solution involves explicitly defining the addition operator overload within the custom class (`MyClass`). This ensures the addition operation is performed correctly when an integer is added to an instance of the class.  This explicit definition provides the necessary control over how the arithmetic operation interacts with the implicit conversion.