> # Writing Clean Code
Clean code is code that does not smell..`Why does this mean?`.This writing readable code,simple and yet maitainable by other people.

tools to use
---------------
<li>Resharper<li/>
<li>Visual Studio or rider<li/>


> Example of Smelling code
> # Mysterious Names
Poor naming of the variables. The names hides the meaning of the code.
```csharp
SqlDataReader drl;
int od;
void Button1_click();
class Page1{}
```
The variable should be named in a way it show the intent of the code.Someone else should not spend much of the time somewhere else trying to figure out what a variable means.

How to improve the code above
------------------------------
```csharp
SqlDataReader datareader;
int overdueDays;
void CheckAvailability_click();
class CustomerViewPage{}
```
> # Meaningless Names
```csharp
 void BeginCheckFuctionality_StoreClientSideCheckBoxisArray();
```
What does the above code mean? cant tell.I will have to check at the implementation of the method.Such name happen when we try to do allot of stuff in one method and now it become difficult to name the `intent` of the method.

How to overcome 
----------------
Make sure your methods only do one action.This way its easier to name the method since the intended intent is clear 

> # Names with Encodings
This polluting the naming of variable with datatypes in order to be able to differentiate different datatype of the variables.
```csharp
int intNumber_one;
int iNumber_two;
var m_objCollection=new StringCollection();
```
Int Visual studio,to confirm the datatype of a field just hover your mouse over the variable and you see the datatype of the variables.Just name the variable without type pollution.
```csharp
int numone;
int numtwo;
var country_names=new StringCollection();
```
> # Ambiguous Names
```Csharp
bool MultiSelect() {

}
int? incidentNameId;
```
On the line `int? incidentNameId;` is it supposed to be an incidentname? no `then why does it have the int datatype`.If its an id `should be there be incident names without ids`(it a nullable type)?

> # Noisy Names

```csharp
Customer thecustomer;
List<Customer> listofApprovedCustomers;
```
better implementation
-----------------------
This names are shorter 
```csharp
Customer customer;
List<Customer> approvedCustomers;
```

To change the Poor naming of code variable inside the ide.Use Resharper code Refactor.
           
        1.select the name you want to change         and click f12
        2.Resharper Code Refactor will appear and once you rename the code.It will change all the implementation

> # What is Resharper
Resharper is an extension for Visual studio that is disigned to increase productivity.It is build by inteli j the same company that build Rider ide.

Resharper is build in the rider ide.


> # Next time you are Choosing Identifiers(Names)
make sure you maintain the following
<li>Not too short, not too long<li/>
<li>Meaninful<li/>
<li>Reaveal Intentions<li/>
<li>Chosen from Problem Domain<li/>

The next smelling code is 
> # Inconsistent Naming Conventions
```csharp
Customer GetCustomer(int _id);//uses an undeline
Customer saveCustomet(Customer Customer);
private int CustomerID;//uses the Capitalletter
```
> # .Net Naming Conventions

<li>PascalCase<li/>
<li>camelCase<li/>

```Csharp
public class Customer{
    private int _id;
    public string Name{get;set;}
    public void Charge(int amount){
        var tax=0;
    }
}
```
The `class` ,`public properties` and  `method` names are in `PascalCase`.
The `private property` and `local variables` are  in camelCase. but the private property must be prefixed with and `underscore`.

> # Poor Method Signatures
```Csharp
Orange GetCustomer(int airplane);
void Parse(int command);    //> int Parse(string command)
```
# > Method Signatures
<li>Check the Return type</li>
<li>Check the method name</li>
<li>Check the parameter names<li/>



