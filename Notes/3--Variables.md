 ># Variables and DataTypes in C#

Variables are conserned with the `storage of data`.You can think of varibles in computer memory as `boxes` sitting on a shelf.You can `put` things in boxes and `take them out` again or you can just look inside a box to see if anything is there. The same goes for variable; you `place data in them and can take it out or look at it, as required`.

Although all data in a computer is effectively the same thing (`a series of 0s and 1s`),
variables come in different flavors, known as types. Using the box analogy again,
boxes come in different shapes and sizes, so some items fit only in certain boxes.
The reasoning behind this type system is that different types of data may require
different methods of manipulation, and by restricting variables to individual types
you can avoid mixing them up. For example, it wouldn't make much sense to treat
the series of 0s and 1s that make up a digital picture as an audio file.To `use variables`, you have to `declare` them. This means that you have to assign them a name and a type.


C# syntax to declare a variable goes like 
     <type> <name>;

> What is the type above?
Simple types include type such as number and Boolean(true or false)
examples of the interger types

|Type                |Allowed Values |
|--------------------|---------------|
|sbyte               |Intergers between -128 and 127|
|byte                |Intergers between 0 and 255   |
|short               |Intergers betwen -32768 and 32767|
|ushort              |interges btwn 0 and 65535        |
|int                 |intergers between -2147483648 and 2147483648|
|Long                |intergers btwn −9223372036854775808 and
9223372036854775807|
|Ulong               |interges btwn 0 and 18446744073709551615

The `u` character before some variables names are `shorthand` for unsigned , meaning that you can't store negative numbers in variable fo those type.

Your will also need to store floating-ponts values those that aren't whole numbers.Your can use floating point variables 
       <li>float<li>
       <li>double<li>
       <li>decimal<li>
more type examples 
  
|type                   |min value   | max value   |
|-----------------------|------------|-------------|
|float                  |0           |22 power 4   |
|double                 |0           |25 power 5   |
|decimal                |0           |29 power 6   |

Types conserning the character and strings.
|type                   |Allowed values             |
|-----------------------|---------------------------|
|char                   |single unicode character, stored as intergers between 0 and 65535|
|bool                   |Boolean Values, true or false|
|string                 |A sequence of Character      |

There is no upperlimit on the amount of character making up a string because it cann use varying amounts of memory.

Look at the code below.

```Csharp
static void Main(string[] args)
{
int myInteger;
string myString;
myInteger = 17;
myString = "\"myInteger\" is";
Console.WriteLine($"{myString} {myInteger}");
Console.ReadKey();
}
```
> How does the code works?
The code perfoms three tasks:
<li>It declare two variables</li>
<li>It assigns values to those two variables</li>
<li>It outputs the values of the two variable to the console </li>

Variable declarations occurs in the following codes.
 ```Csharp
int myInterger;
string myString;
 ```
 The first line declares a variables of type int with a name of `myInterger`, and the second line declares a variable of type `string` called `myString`.

 The next two lines of code assign values:
```Csharp
myInteger = 17;
myString = "\"myInteger\" is";
```
Here you assign fixed values (known as `literals` values in code) to your variable using the =``assignement operator`.You assign the interger value 17 to myInterger and you assigned the following strings (including quates) to myString .

When you assign string literal values in this way, `double quotation` marks are
required to `enclose the string`.

double quotation
characters, and you must escape some characters by substituting a sequence
of other characters (an `escape sequence`) that represents the character(`s`) you
want to use. In this example, you use the sequence` \"` to `escape a double quotation mark`:
```Csharp
myString = "\"myInteger\" is";
```
If you didn't use these `escape sequences` and tried coding this as follows, you would get a `compiler error`:
```Charp
//produces a compiler error since the escape sequence 
//not used in the code
myString = ""myInteger" is";
```
The line `Console.WriteLine($"{myString} {myInteger}");`
This a C# 6 feature called `String Interpolation` .The method introduce a space to the code you are printing out and prints the line in one line.

lastly, The line `Console.ReadLine();` Waits for a key press before terminating the console program.

># Variable Naming
The basic variable naming rules are as follows:
<li>The first character of a variable name must be either be a letter, an underscore character(_) or the @ symbol</li>
<li>Character may be letter, underscore characters or numbers</li>

>String Literals
There are some escape sequence that can be used togeter with string literals.
