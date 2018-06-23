> # String interpolation
To identify a string as an inteporated string we append it with the $ symbol.You can embend any 
valid c# expressions that returns a value in and inteporated string.

Some Example
```Csharp
static void Main(string[] args)
        {
    //some valiable decalations
    double a, b;
    //valiable initialization
    a = 3;
    b = 4;
    //using string interpolation to display are
    WriteLine($"Area of {a} and {b} is {a*b}");
    //assuming a,b are side of a tringle find the hypotenues.
    WriteLine($"the leght of the hypotenues of side {a} and {b}is given by :{Math.Sqrt(Math.Pow(a,2)+Math.Pow(b,2))}");
    WriteLine("Hello World!");
    WriteLine();
    ReadKey();
        }
```
> #how to specify string interpolation in Expressions
```Csharp
static void Main(string[] args)
        {
            ...
            var date =new DateTime(1731,11,25);
            WriteLine($"on {date:yyyy MMMM dd} We started learning c# together");
            ReadKey();
        }
```
> ## How to control the withs alignment of the interpolated fields
Example
```Csharp
ForegroundColor = ConsoleColor.Yellow;
const int NamedAlignments = -9;
const int ValueAlignments = 7;
WriteLine($"three classical pyhtogoream means of {a} and {b}");
WriteLine($"|{"Arithimetic",NamedAlignments}|{0.5 * (a+b),ValueAlignments}");
WriteLine($"|{"Geometric",NamedAlignments}|{Math.Sqrt(a*b),ValueAlignments}");
WriteLine($"|{"Harmonic",NamedAlignments}|{2/(1/a+1/b),ValueAlignments}");
ReadKey();
```
>  ## Use Escape Sequence in an Interpolated string

Interpolated strings supports all the escape sequence that can be used in ordinary string literals.To interpret escape sequence you can use the `verbatism` string literals.A verbatism interpolated string starts with the $ character followed by the @ character.

Example
```Csharp
string username = "Jane";
string stringWithescape ="C:\\Users\\edd\\source\\repos\\Introduction-to-Csharp-Basicd\\Notes\\4--StringIntrpolation.md";
var verbatismInterpolated =@"C:\Users\edd\source\repos\Introduction-to-Csharp-Basicd\Notes\4--StringIntrpolation.md";
WriteLine(stringWithescape);
WriteLine(verbatismInterpolated);
```

>please contribute by adding more relevate notes here and some example too..
>if any problems is encountered. Feel free to ask Edd and Josh to help you out.Thanks 