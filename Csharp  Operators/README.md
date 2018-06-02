# C# Operators
 An `operator` is a symbol that performs `mathematical` or `logical manipulations`. C# support the following :
### Navigate to a topic faster
1. [Assignment operator](#1.assignment-operator)
1. [Arithemetic operator](#2.arithmetic-operators)
1. [Operator precedence](#operator-precedence)
1. [Compound Assignment Operator](#3.compound-assignment-operator)
1. [4. Unary Operators](#4.unary-operators)
1. [Logical operators](#5.logical-operators)

> ## 1.Assignment Operator
The assignment operator `assigns the value on the right side of the variable` to the left side.
e.g
```Csharp
int t=3;
```
> ## 2.Arithmetic Operators
These `Allow you to perform mathematical operations` on numbers.
They include:
<li>Addition +</li>
<li>Subtraction -</li>
<li>Division \</li>
<li>Multiplication *</li>
<li>Modulus %</li>

The division operand divides the first operand by the second. If both operands are integers any remainder is dropped in order to return an integer value.

**Division by Zero is undefined and will crash your program.**

The `modulus operator` is known as the remainder operator because it returns the remainder if an integer division
> ## Operator precedence
Certain operators have a higher precedence than others e.g the multiplication operator has a higher precedence than the addition operator
Consider:

```Csharp
int x=4+3*2;
Console.WriteLine(x);
```
In the above case the `output` is `10` because the progrm evaluates `3*2` **first** and then **adds** the result to `4.`
Parentesis can be used to alter the operator precedene
e.g

```Csharp
int x=(4+3)*2;
```
The second case `outputs` `14` since the `operations in the parenthesis are performed first`.

> ## 3.Compound Assignment Operator
C# also provides `compound assignment operators` that peform an `operation` and an `assignment` in one statement.
e.g.
```Csharp
int x=31;
x+=2;   //equivalent to x=x+2;
x-=2;   //equivalent to x=x-2;
```

> ## 4.Unary Operators
Two common unary operators are used to `increment ++` and `decrement --` a number.
e.g
```Csharp
int x = 3;
int y = x++;
```
The value of `y` now becomes `4.`
The `increament operator` `increases` an integer's value by `one`.
Similartly the decreament operator works in a similar way as the increament operator.
In these unary operators we can have 2 forms namely:
<li>Postfix  x++ </li>
<li>Prefix  ++x </li>

The `prefix increaments` the value `then proceeds with the expression` while the **postfix** evaluates the expression and then performs the `increamentation`.

> ## 5.Logical operators

