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
