using System;
using static System.Console;

namespace BoxingNullableTYpes
{
    class Program
    {
        static void Main(string[] args)
        {
            bool? b=null;
            //object is null..Boxing did not occurr
            object o=b;
         WriteLine(o);

         //is order to box a nullable type make sure u are using a nullable type which is not null

         bool? isFalse= false;
         int? i=44;
         object bboxed=b; //contains a boxed bool
         object iboxed=i;// contained a boxed int


         ReadKey();
        }
    }
}
