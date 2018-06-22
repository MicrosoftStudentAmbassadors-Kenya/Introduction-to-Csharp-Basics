using System;

namespace NullableTypes
{
    class Program
    {
        static void Main(string[] args)
        {
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
    }
}
