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

