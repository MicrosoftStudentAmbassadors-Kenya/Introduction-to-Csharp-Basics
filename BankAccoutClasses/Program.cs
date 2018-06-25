using System;

namespace BankAccoutClasses
{

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Person Victor = new Person();
            Person Joy = new Person();
            Person Eric = new Person();
            Victor.Age = 23;
            Victor.Name = "Victor";
            Joy.Age = 45;

            Joy.Name = "Joy";
            Eric.Age = 45;
            Eric.Name = "Eric";

            var edwin=new Person(){Name="Edwin",Age=24};



            Console.WriteLine(Joy);
            Console.WriteLine(Eric);
            Console.WriteLine(Victor);

            // using string interpolation
            Console.WriteLine($"{Joy} {Eric} {Victor}");
            Console.ReadKey();


        }
    }

    //access modifiers include the following Private, public,Protected
         class Person
        {
            //properties ---a member of the class person
            //age , gender, height,weight ,height
            private int age;

            public int Age
            {
                get { return age; }
                set { age = value; }
            }

            private int weight;

            public int Weight
            {
                get { return weight; }
                set { weight = value; }
            }

            public string Name { get; set; }

            // public override string ToString()
            // {
            //     return base.ToString();
            // }
//access modifier datatype variable_name;

            //methods 
            //c
            public override string ToString()
            {
                return $"{Name}  {Weight}";
            }
        }
    
}