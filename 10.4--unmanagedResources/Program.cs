using System;
using System.IO;
using System.Collections.Generic;

namespace _10._4__unmanagedResources
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            //Automatic memory Managements
            
            /*
            .net uses a garbage collection (gc) to provide automatic memory management for programs.The
            GC operateds on a lazy approach to memory management,prerferrind apps throughout 
            to immediate collection of memory.The following two lines both allocate memory

             */
             var title=".Net Primer";
             var list=new List<string>();

             /*theres no analogous keyword to de-allocate memory ad deallowcation of memory happes 
             automatically when the gargage collector reclaims the memery
             thro it schedule time..
             The gargaged collector is one of he services thata helps ensure memory safety.A program is memory 
             safe if is acces onloy allocated memory For instance the runtime ensures that an app doesn't acees unallocated memory beyond bonds of the array.
             
             In the following example , the runtime throws and InvalidIndexException  to enforce memory safly */

             int[] numbers=new int[42];
             int number=numbers[42];
             System.Console.WriteLine(number);

             //Working with unmaged resources
             /*
             Unmanaged resource are resource that arent automatically maintaned by the .Net runtime 
             ie a file handle is an unmangaed resource.A fileStream object is a mangaged object , but it references a file handle which is unmaged
             when you're dome using the FileStream you need to release the file handle */
            /*
            In .net object that reference unmanaged resourced implements the IDisposable interface. 
            when u're done using the object you call the object as the shown below*/

            using(FileStream stream=GetFileStream(context)){

            }
         

        }
        public FileStream GetFileStream(string context){
        return new FileStream(null,null);
        }
    }
}
