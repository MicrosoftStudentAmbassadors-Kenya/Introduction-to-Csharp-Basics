># The anatomy of a Simple C# Program

A `console application` starts from the `Main method`.The main method is the `entry point of a console`
application. C# is a case sensitive therefore the keyword Main, `(M)` is always `capitalized.`

># Rules of C#

<li>C# is case sensitive </li>
<li>All the statements must end with a semicolon</li>
<li>Every bracket must be closed</li>


># The Main Method 

Every `executable files`
`written in c#` must contain a `Main method` that is used to signify the `entry point` of the application.The main method has 
`static keyword`.In addition to the static method ,this Main() Method has a `single parameters`, which happens to be an `array of string()`.
Beign array means that the Method can contain a number `incoming command-line arguments` of strings.

finally , this Main method has been set up using the `void keyword`,meaning you do not explicity define the `return value` using the return 
value before exiting the program.The logic of the application is within the `main method`.Here we Make use of the `console` class which is defined 
within the `System namespace`.

># The output Method
Among its memeber is the static `WriteLine()` which take in string and the sends it to the output stream.

># Variation of the Main Method
By default visual studio/rider will generate a  `Main()` method that has a `void return` valur and an array of string
type as the single input parameter.The main method can have many singnatures

```Csharp
// int return type, array of strings as the parameter.
static int Main(string[] args)
{
// Must return a value before exiting!
return 0;
}
// No return type, no parameters.
static void Main()
{
}
// int return type, no parameters.
static int Main()
{
// Must return a value before exiting!
return 0;
}
```

The main method may also be defined as public as opposed to private,if do not supply a 
specific access modifier.Vs automatically defines a progrm's main as private.

**we will cover the access later**

># New features 
With the `realease of c# 7.1 the Main()` methods can be `asychronous` 
```Csharp
static Task Main()
static Task<int> Main()
static Task Main(string[])
static Task<int> Main(string[])
```

># return Value 
By convection `returning` a zero `(0)` indicates that the program `terminate succefully`, while other `value (such as 1)` representes 
an `error conditon(if do not specify the return value the value zero is returned by default.`)

### Explanation of a Basic C#  Console Application
```Csharp
using System;
class Greetings
{
static void Main()
{
Console.WriteLine("Greetings!");
}
}
```

The `void keyword` is't a type; it indicate that a method `does not return a value`.For Main, you can replace
void with `int`, meaning that the program has a return type.This number can be used by the `command-line shell tools` to 
evalute the conditions under which the program ended.It is unique to each program and specific by you.

`The static modifier indicate` that there is only ever `one instance` of a `Greeting class` that has the Main method
it is the `static instance` members. This means that you can have many copies of a class or instance with their own method.

Since a program only need  a `single Main method`, `static makes sense`.A program that manages customer  might need a customer class
and you would need `multiple insances` to represent each customer.

Inside the `Main method` is a statement that prints words to the `command line`. The words enclosed in `double
quotes`, are string .The string is passed to the Writeline method which write that belongs to a class  named console is a.
The `class Console` class belong to the Systen namespace which why we are using the namespace using clause appears at the top of the file.
 
 
> # Namespace and Code Organisation 
 There are various ways to organise code and the choice should be based on the stardard of your team and the  nature of the project you'r building.One of the common way to organise code is with `C# namespace feature`.
 
 > # The System.Console class
 
 The console class encapsulate inputs,outputs and error stream manipulation for console
 based application.The ability to change the background and foreground colors and issue beep 
 noises(in variety of frequency.
 
 |`Member`/ `methods`         |       `Meaning` what it does        |
 |----------------|-------------------------------|
 |Beep()          |           This method forces the console to emit a beep of specified frequecy
 |BackgroundColor |           These properties set the background color fot the current output
 |ForegroundColor |          They may be assigned any memeber of the console enumeration
 |BufferHeight/BufferWidth |  controls the height/width of the console buffer area
 |Title                    |   Sets the title of the current console
 |WindowHeight             |  these controls the dimension of the console in relation to the established buffer
 |Clear()                  |  This methos clears the established buffer and the console display area.
 
 > # Basic Input and Ouput with the Console
 
 The `console class` defines a `set of method` to `capture the input` and the `output` of the console app all of which are `static` and therefore called by prefixing the name of the `class (console)` to the method name.