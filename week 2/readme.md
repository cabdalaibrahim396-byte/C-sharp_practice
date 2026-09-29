```markdown
# Chapter 02: Processing Data

A **TextBox** is a Windows Forms control that allows users to enter data using the keyboard. It can be used to collect names, numbers, addresses, student information, and other input. The data entered by the user is stored in the TextBox's `Text` property.

A **variable** is a storage location in computer memory used to hold data while a program is running. Every variable has a name, a data type, and a value. A variable must be declared before it can be used.

A **data type** specifies the kind of data a variable can store. Common C# data types include:

- `string` – stores text and characters.
- `int` – stores whole numbers.
- `double` – stores numbers that can contain decimal values.
- `decimal` – stores precise decimal numbers, commonly used for financial values.

Variable names should be meaningful and easy to understand. The first character must be a letter or underscore. Spaces are not allowed, and keywords or reserved words cannot be used as variable names.

A **string** is a sequence of characters. It can contain letters, numbers, symbols, and spaces. Strings are commonly used for names, descriptions, phone numbers, and other text.

**String concatenation** means joining one string to another. In C#, the `+` operator can be used to combine strings with other strings or data types.

```csharp
string firstName = "Ali";
string lastName = "Ahmed";

string fullName = firstName + " " + lastName;
```

**Variable scope** refers to the part of a program where a variable can be accessed. A local variable belongs to the method where it is declared and can only be accessed inside that method.

The **lifetime** of a variable is the period during which it exists in memory. A local variable is created when its method starts and destroyed when the method ends.

Two variables cannot have the same name within the same scope. However, variables with the same name can exist in different methods because each method has its own scope.

A value assigned to a variable must be compatible with its data type. For example, a `string` variable should receive text, while an `int` variable should receive a whole number.

**Variable initialization** means giving a variable its first value. A local variable must be initialized before it is used. Using an uninitialized local variable causes a compiler error.

Numeric data types are used to store numbers and perform mathematical operations. The commonly used numeric types are `int`, `double`, and `decimal`.

A **numeric literal** is a number written directly in a program. Whole numbers are treated as integers, while numbers containing a decimal point are treated as `double` values. A decimal value uses the `M` or `m` suffix.

```csharp
int age = 20;
double temperature = 25.5;
decimal price = 99.99m;
```

**Type casting** means explicitly converting a value from one compatible data type to another.

```csharp
double number = 10.5;
int wholeNumber = (int)number;
```

The **`var` keyword** allows the compiler to determine the data type automatically from the assigned value. A variable declared with `var` must be initialized when it is declared.

```csharp
var name = "Ahmed";
var age = 21;
```

C# provides arithmetic operators for calculations:

- `+` Addition
- `-` Subtraction
- `*` Multiplication
- `/` Division
- `%` Modulus

The modulus operator `%` gives the remainder of a division.

Mathematical expressions follow the rules of operation precedence. Parentheses can be used to control the order of calculations.

```csharp
int result = (5 + 3) * 2;
```

When two integer values are divided, the result is an integer, so the fractional part is removed. To obtain a decimal result, the calculation should use a type such as `double`.

```csharp
int result = 5 / 2;          // Result: 2
double answer = 5.0 / 2.0;   // Result: 2.5
```

Data entered through a TextBox is always treated as a `string`, even when the user enters a number. Therefore, the input must be converted before performing numeric calculations.

C# provides `Parse` methods for converting strings into numeric values:

- `int.Parse()` – converts a string to an integer.
- `double.Parse()` – converts a string to a double.
- `decimal.Parse()` – converts a string to a decimal.

```csharp
int age = int.Parse(txtAge.Text);
double number = double.Parse(txtNumber.Text);
decimal price = decimal.Parse(txtPrice.Text);
```

The `Text` property of Labels and TextBoxes accepts string values. Therefore, numeric values may need to be converted into strings before they are displayed. The `ToString()` method is used for this purpose.

```csharp
int total = 100;
lblResult.Text = total.ToString();
```

## Chapter Summary

Chapter 02 explains how C# programs:

1. Receive data.
2. Store data in variables.
3. Convert data into the correct type.
4. Process or calculate data.
5. Display the result.

The chapter covers TextBox input, variables, data types, strings, string concatenation, numeric values, variable scope, variable lifetime, initialization, type casting, the `var` keyword, arithmetic operators, order of operations, integer division, `Parse` methods, and the `ToString()` method.

## Basic Process

```text
Input → Store in Variables → Convert Data → Process or Calculate → Display Output
```
```