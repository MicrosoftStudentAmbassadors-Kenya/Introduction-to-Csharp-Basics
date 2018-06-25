using System;

namespace AnimalClass {
    class Program {
        static void Main (string[] args) {
            var animal = new Animal ();
            Console.WriteLine ("Please enter the name of animal");
            animal.Name = Console.ReadLine ();

            Console.WriteLine ("Please enter the Age of animal");
            animal.Age = Int32.Parse (Console.ReadLine ());

            Console.WriteLine ("Please enter the sound of animal");
            animal.Sound = Console.ReadLine ();

            Console.WriteLine ("Is the animal wild :: true or false");
            
            animal.IsWild = Convert.ToBoolean (Console.ReadLine ());
          
        


            Console.WriteLine (animal);

            Console.ReadKey ();

        }
    }
    class Animal {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Sound { get; set; }
        public string Gender { get; set; }
        public bool IsWild { get; set; }

        public override string ToString () {

            string animaltype=this.IsWild==true?"domestic":"wild";
            return $"{Name} Age={Age} {Sound} Gender={Gender} {animaltype}={IsWild}";
        }

    }
}