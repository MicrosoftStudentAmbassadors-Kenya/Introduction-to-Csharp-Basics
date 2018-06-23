> # Nullable Type (C# programming)
Nullable types are instances of the `System.Nullable<T>` struct.A nullable type can represent the correct range of values for its underlying value type plus additional `null`.for Example a `Nullable<int32>` is called the `Nullable of Int32` can be assigned any value.
A  `Nullable of bool ` can be assigned the following values.
<li>true</li>
<li>false</li>
<li>null</li>

> # What is the Importance of Nullable
The ability to assign `null` to numeric and boolean types is especiallly usefull when dealing with databases and other types that contains elements that may nor be assigned a value.For Example a boolean field in a database can either be the values `true`,`false` and `null`(undefined).

```Csharp
static void Main(string[] args){
    int? num=null;
    //is the HasValue Property true
    if(num.HasValue)
        Console.WriteLine($"num = "+ num.HasValue);
    else
        Console.WriteLine("num = null");
    
    //y is set to Zero
    int y=num.GetValueOrDefault();
    try{
        y=num.Value;
    }catch(InvalidOperationException e){
        
        Console.WriteLine(e.Message);

    }
    Console.WriteLine("Hello World!");

    Console.ReadKey();
}
```
> # Nullable Types Overview
Nullable types have the following characteristics.
<li>NUllalable types represent value types variables that can be assigned the value of null value</li>
<li>The syntax T? is shorthand for Nullable<T> , where T is a value type.The two forms are interchangeble</li>
<li>Assign a value to a nullable type just as you would for an ordinary value type,for Example int? x=10 or double? d=4.100. A nullable type can also be assigned the value null: int? x = null</li>
<li>Use the Nullable<T>GetValueOrDefault method to return either the assigned value or the default value for the underlying type if the value is null for example int j=x.GetValueOrDefault():</li>
<li>Use the HasValue and Value readonly properties to test for null and retrieve the value as shown int the following </li>
 
The `HasValue` and `Value` readonly properties return true if the variable contains a value,of `false` if it is `null`.

The `value` property returns `true` if the variable contains a value or `false` it its null.

The value property returns a value if one is assigned.Otherwise a System.InvalidOperationExeption is thrown.

The `default` value for `HasValue` is `false`.the `Value` property has no default value.

Use the `??` operator to assign a default value that will be applied when a nullable type whose current value is null is assigned to a non-nullable type,for example `int? x=null ; int y=x??-1`;

`Nested` nullable types are not allowed .The following line will not compile `Nullable<Nullable<int>> n`

> # Using Nullable Types
Nullable types can be represent all the value of an underlying type and an addition null value.Nullable types are declared in two ways
```csharp
System.Nullable<T> variable

      or 
T? variable
```
T is the underlying type of the nullable type T can be any value including `struct` but is cannot be a reffence type.For example of when you might use a nullable type consider how an ordinary Boolean variable can have two values;`true of false` .There is no value that signifies  `Undefined` .In many orogramming application most notable database interactions ,variables can occur in an undefined state.For exampe, a field in a database may contain the value true or false but it may also contain no value at all.Similary,referenc types can be set to null to idicate that they are not initialised.

This disparity can create extra proramming work with additional variables used to store information,the use of special values and so on.The nullable types modifiers enables c# to create value-type can be set to indicate and udefined value.

> # Example of Nullablel Types
Any value type may be the basic for Nullable.For example
```Csharp
int? i=10;
double? di=3.14;
bool? flag=null;
char? letter='a';
int?[] arr=new int?[10];
```
> # The Members of Nullable Types
Each instance of nullable type has two public read-only propertis
<li>HasValue is of type bool.It is set to true when the variable contains a non-null value</li>
<li>Value</li>
`Value` is of the same type as the undelying type .if HasValue is `true` Value contains a meannigful value.If `HasValue` is false,accesing Value will throw a `InvalidOperationException`

In this example, the `HasValue` member is used to test whether the variable contains a value before it tries to displat it.



    

