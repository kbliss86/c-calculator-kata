# Calculator Kata

## Overview
This project is a simple calculator developed using Test-Driven Development (TDD) and xUnit for testing. The objective is to create a `Calculate` method that can evaluate simple arithmetic expressions written as strings, such as `"1 + 2"` or just `"44"`. The main focus of this lab is to practice TDD principles.

This exercise is best worked on in pairs using pair programming.

## Build Specifications
Follow these steps in order, and ensure each step is completed before moving to the next one. You do not need to complete all steps, but at least complete through Step 3.

## Steps

### Step 1: Create a Stub Method and a Failing Test
- Set up a public `Calculator` class with a static method named `Calculate`.
- The `Calculate` method should take a single string parameter and return an integer.
- For now, have the method return `0`.
- Write a unit test with the input `"3"` and expected result `3`. The test should fail.

```csharp
public static int Calculate(string expression) { return 0; }
```

- **Commit your code.**

### Step 2: Simple Number Expressions
- Write at least three xUnit test cases for strings with a single number, such as `"3"` or `"-401"`.
- Assume that:
  - There is no whitespace around the number.
  - The number is always an integer.
  - The input is always valid.
- Modify the `Calculate` method to ensure the tests pass.
- **Commit your code.**

### Step 3: Adding Two Numbers
- Write at least two tests for adding numbers, such as `"8 + 751"`.
- Additional assumptions:
  - There is always one space on either side of the operator.
  - The input is always valid.
- Fix the `Calculate` method to pass these tests.
- **Commit your code.**

### Step 4: Other Operators
- Add support for `-`, `*`, and `/`.
- Write at least two test cases for each operator.
- Use integer math for division (e.g. `"5 / 2"` should be `2`).
- Update `Calculate` to pass these tests.
- **Commit your code.**

### Step 5: Three Numbers
- Write tests for expressions involving three numbers and two operators.
- Calculate from left to right, ignoring traditional order of operations.
- **Commit your code.**

### Step 6: Any Amount of Numbers
- Write tests for expressions with any number of numbers and operators.
- Your code should be able to handle expressions of any length.
- **Commit your code.**

### Step 7: Ignore Whitespace
- Remove assumptions about whitespace.
- Handle expressions with spaces, tabs, or no space around numbers and operators.
- **Commit your code.**

## Extended Challenges
- **Invalid Input**: Write tests for invalid input that should throw `ArgumentException`.
- **Order of Operations**: Implement the traditional order of operations (e.g., `*` and `/` before `+` and `-`).
- **Parentheses**: Allow parentheses for refined order of operations.

## Running Tests
All unit tests are written using xUnit. To run the tests, you can use the command line or an IDE like Visual Studio or JetBrains Rider that has xUnit integration.

Ensure that you have committed your code after each change that results in passing tests. This iterative commit approach will help you roll back easily if required.
