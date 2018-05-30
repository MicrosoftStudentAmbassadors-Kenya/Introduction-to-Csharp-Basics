# C# Operators

 An opertaor is a symbol thatperforms mathematical orlogical manipulations. C# support the following :

## 1.Assignment Operator

The assignment operator assigns the value on the right side of the variable to the left side.
e.g

```Csharp
int t=3;
```

## 2.Arithmetic Operators

These Allow you to perform arithmetic operations on numbers.
They include:

* Addition +

* Subtraction -

* Division \

* Multiplication *

* Modulus %

The division operand divides the first operand by the second. If both operands are integers any remainder is dropped in order to return an integer value.

Division by Zero is undefined and will crash your program.

The modulus operator is known as the remainder operator because it returns the remainder if an integer division

### Operator precedence

Certain opertors ahave a higher recedence than others e.g the multiplication operator has ahigher precedence than the addition operator
Consider:

```Csharp
int x=4+3*2;
Console.WriteLine(x);
```

In the above case the output is 10 because the progrm evaluates 3*2 first and then adds the result to 4.
Parentesis can be used to alter the operator precedene
e.g

```Csharp
int x=(4+3)*2;
```

The second case outputs 14 since the operations in the parenthesis are performed first.

## 3. Compound Assignment Operator

C# also provides compound assignment operators thatpeform an operation and an assignment in one statement.
e.g.

```Csharp
int x=31;
x+=2;   //equivalent to x=x+2;
x-=2;   //equivalent to x=x-2;
```

## 4. Unary Operators

Two common unary operators are used to increment ++ and decrement -- a number.
e.g

```Csharp
int x = 3;
int y = x++;
```

The value of y now becomes 4.
The increament operator increases an integer's value by one.
Similartly the decreament operator works in a similar way as the increament operator.
In these unary operators we can have 2 forms namely:

* Postfix  x++

* Prefix  ++x

The prefix increaments the value then proceeds with the expression while the postfix evaluates the expression and then performs the increamentation.

## 5. Logical operators

They ae used to join multiple expressions and return true or false.
E.g.

| Operator      | Name
| ------------- |:----
| &&            | And
|              | OR
| !             | NOT

For the && operator both operands must be true  for the entire expression to be true.
The && can join muliple statements.
The logical NOT (!) operator works with just as ingle operand,reversing its logical state.

