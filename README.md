# Simple Calculator - VB.NET

## Description

This project is a simple calculator created using **VB.NET Windows Forms**. It is designed for beginners who are learning how to work with text input, numeric data types, and basic arithmetic operations.

The calculator allows the user to enter two numbers and perform:

* Addition
* Subtraction
* Multiplication
* Division

The main purpose of this project is to learn how to use the **Double** data type and convert text input into numbers using the `Convert.ToDouble()` method.

## What I Learned

Through this project, I learned:

* How to create a simple Windows Forms application.
* How to use `TextBox` controls to receive user input.
* How to use `Button` controls to perform operations.
* How to use the `Double` data type.
* How to convert text into a `Double`.
* How to perform basic arithmetic operations.
* How to display calculation results.

## Why Use Double?

A `TextBox` stores the value entered by the user as **text**. Before performing calculations, the text needs to be converted into a numeric data type.

The `Double` data type is useful because it can store numbers with decimal values.

For example:

```vb
Dim number1 As Double
Dim number2 As Double
```

This allows the calculator to work with values such as:

```text
10
5.5
25.75
100.25
```

## Converting Text to Double

The values entered into the TextBoxes are converted from text to `Double` using:

```vb
Convert.ToDouble()
```

For example:

```vb
Dim number1 As Double = Convert.ToDouble(TextBox1.Text)
Dim number2 As Double = Convert.ToDouble(TextBox2.Text)
```

`TextBox1.Text` and `TextBox2.Text` contain text, while `Convert.ToDouble()` converts those values into numbers that can be used in calculations.

## Example Operations

### Addition

```vb
Dim number1 As Double = Convert.ToDouble(TextBox1.Text)
Dim number2 As Double = Convert.ToDouble(TextBox2.Text)

Dim answer As Double = number1 + number2

MessageBox.Show(answer.ToString())
```

### Subtraction

```vb
Dim answer As Double = number1 - number2
```

### Multiplication

```vb
Dim answer As Double = number1 * number2
```

### Division

```vb
Dim answer As Double = number1 / number2
```

## Example

If the user enters:

```text
Number 1: 10.5
Number 2: 2
```

The division operation produces:

```text
5.25
```

Using `Double` allows the calculator to return decimal results instead of only whole numbers.

## Technologies Used

* VB.NET
* Windows Forms
* Visual Studio

## Project Purpose

This is a beginner-level project created to practice fundamental VB.NET programming concepts, especially **variables, the Double data type, type conversion, TextBoxes, Buttons, and arithmetic operators**.

## Future Improvements

Possible improvements include:

* Adding a Clear button.
* Adding error handling for invalid input.
* Preventing division by zero.
* Adding more mathematical operations.
* Improving the calculator interface.
* Displaying the result directly in a TextBox or Label.
