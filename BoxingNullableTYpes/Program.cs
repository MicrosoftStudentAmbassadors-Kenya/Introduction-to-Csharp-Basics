using System;
using static System.Console;

namespace BoxingNullableTYpes {
    class Program {
        static void Main (string[] args) {
            bool? b = null;
            //object is null..Boxing did not occurr
            object o = b;
            WriteLine (o);

            //is order to box a nullable type make sure u are using a nullable type which is not null

            bool? isFalse = false;
            int? i = 44;
            object bboxed = b; //contains a boxed bool
            object iboxed = i; // contained a boxed int
            bool? b2 = (bool?) bboxed;
            int? i2 = (int?) iboxed;

            //check for null
            bool? bx = null;
            object boxedB = b;

            if (b == null) {
                WriteLine (true);
            }
            if (boxedB == null) {
                WriteLine (true);

            }
            //Boxed nullable fully support the fuctionalityof the undelying type

            double? d = 44.4;
            object iBoxed = d;
            // Access IConvertible interface implemented by double.
            IConvertible ic = (IConvertible) iBoxed;
            int ity = ic.ToInt32 (null);
            string str = ic.ToString ();
            WriteLine (ity+" "+str);

            ReadKey ();
        }
    }
}