> # Methods






> # Exceptions
Execptions are just a response to an Execeptional circumtances.Exeptions have some method meaning we dont have to rely on the execption thrown by the code by default. We can actually create our own exceptions

```csharp
bool isconvertedSuccessfully=int.TryParse(input,out convertedNumber);
if(!isconvertedSuccessfully){
    throw new Exeception("Conversions was not successfull");
}

```