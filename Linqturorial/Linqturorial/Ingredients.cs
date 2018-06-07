using System;
using System.Collections.Generic;
using System.Text;

namespace Linqturorial
{
    public class Ingredients
    {
        public string Name { get; set; }
        public int Calories { get; set; }

       public override string ToString() =>  $"{Name} {Calories}";

    }
    
}
