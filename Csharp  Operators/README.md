#C# Operators
 An opertaor is a symbol thatperforms mathematical orlogical manipulations. C# support the following :
####1.Arithmetic Operators
These Allow you to perform arithmetic operations on numbers.
They include:
<li>Addition +</li>
<li>Subtraction -</li>
<li>Division \</li>
<li>Multiplication *</li>
<li>Modulus %</li>

The division operand divides the first operand by the second. If both operands are integers any remainder is dropped in order to return an integer value.

Division by Zero is undefined and will crash your program.

The modulus operator is known as the remainder operator because it returns the remainder if an integer division
#####Operator precedence
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
The second case outputs 14 since the operations in the parentesis are performed first.