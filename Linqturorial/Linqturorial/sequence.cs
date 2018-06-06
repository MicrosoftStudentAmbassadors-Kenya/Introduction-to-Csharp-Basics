using System;
using System.Collections.Generic;
using System.Text;

namespace Linqturorial
{
   public class sequence
    {
         int[] fibonacis;

        public sequence()
        {
            fibonacis = new[] {0, 1, 1, 2, 3, 5};
        
        }

        public void startapp()
         {
             var count = fibonacis.Length;
             Console.WriteLine("Elements in the seuence");
             foreach (var num in fibonacis)
             {
                 Console.WriteLine(num);
             }
         }

        public void DefferedExecutions()
        {

        }
    }
}
