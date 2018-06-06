using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Linq;

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
            var numbergreaterThan2 = fibonacis.Where(x => x > 2);
            fibonacis[0] = 99;
            foreach (var i in numbergreaterThan2)
            {
                //by default 99 is included in the sequence
                //in case you want to do immediate executions one uses Conversion operators

                Console.WriteLine(i);
            }
        }

        public void ImmediateExecutions()
        {
            var numbergreaterthan2 = fibonacis.Where(x => x > 2).ToArray();
            fibonacis[0] = 99;
            Console.WriteLine("The numbers greater than 3 are");
            foreach (var i in numbergreaterthan2)
            {
                Console.WriteLine(i);
                
            }

        }

        public void localQueries()
        {
            var xml = @"
                <ingredients>
                <ingredient name='milk' quantity='200' price='89.0'/>
                <ingredient name='sugar' quantity='200' price='89.0'/>
                <ingredient name='salt' quantity='200' price='89.0'/>
                <ingredient name='Powder' quantity='200' price='89.0'/>
                <ingredient name='milk' quantity='200' price='89.0'/>
                </ingredients>";
            XElement xmldata = XElement.Parse(xml);
            var xmlad = xmldata.Descendants("ingredient")
                .First(x => x.Attribute("name").Value == "milk");
            Console.WriteLine(xmlad);
        }


    }
}
