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
         string xml;

         string[] csvRecipes;
    Ingredients[] ingredients;

        public sequence()
        {
            fibonacis = new[] {0, 1, 1, 2, 3, 5};
              xml = @"
                <ingredients>
                <ingredient name='milk' quantity='200' price='89.0'/>
                <ingredient name='sugar' quantity='1 kg' price='100.0'/>
                <ingredient name='salt' quantity='1 kg' price='50.0'/>
                <ingredient name='Powder' quantity='3 kg' price='150.0'/>
                <ingredient name='milk' quantity='200' price='89.0'/>
                </ingredients>";
             ingredients =new Ingredients[]{
                new Ingredients() {Name = "sugar", Calories = 500},
                new Ingredients() {Name = "Egg", Calories = 100},
                new Ingredients() {Name = "Milk", Calories = 150},
                new Ingredients() {Name = "Flour", Calories = 50},
                new Ingredients() {Name = "Butter", Calories = 200}
            
            };
            csvRecipes=new string[]{"milk","sugar","eggs","flour","Butter","Cheese","oats",};

        
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
           
            XElement xmldata = XElement.Parse(xml);
            var xmlad = xmldata.Descendants("ingredient")
                .First(x => x.Attribute("name").Value == "milk");
            Console.WriteLine(xmlad);
        }

        public void fluetSyntax()
        {
        
            var highCaloriesIngredients =
                ingredients.Where(x => x.Calories >= 150).OrderBy(x => x.Name).Select(x => x.Name);
            Console.WriteLine("here is the list of the high calories with fluent methods");
            foreach (var highCaloriesIngredient in highCaloriesIngredients)
            {
                Console.WriteLine(highCaloriesIngredient);
            }
            Console.WriteLine("Here is the list of the high calories ingredients with Query syntax");

            var highqueryingrdient = from caloriesIngredient in ingredients
                where caloriesIngredient.Calories >= 150
                orderby caloriesIngredient.Name 
                select caloriesIngredient.Name;
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            foreach (var caloriein in highqueryingrdient)
            {
                Console.WriteLine(caloriein);
            }
        }
        public void RangeVariable(){
            //similar to the variable used in a foreach statements
            var highCalorie=from i in ingredients
                            let isDairy=i.Name =="Milk" || i.Name=="Butter"
                            where i.Calories>=150 && isDairy
                            select i.Name;
            foreach (var item in highCalorie)
            {
              System.Console.WriteLine(item);
            }
       
            Console.ForegroundColor=ConsoleColor.DarkMagenta;
            var highCalorie2=from i in ingredients
                             let highCalori=i.Calories>=150
                             where highCalori
                             select i;

            foreach (var item in highCalorie2)
            {
                System.Console.WriteLine(item);
            }

        }
     public void Dairyquery(){
         var dairyquery=from csvRecipe in csvRecipes
                        let ingredients=csvRecipe.Split(',')
                        from ingredient in ingredients
                        let uppercaseIngrident=ingredient.ToUpper()
                        where uppercaseIngrident=="MILK" ||
                            uppercaseIngrident=="Butter"||
                            uppercaseIngrident=="Cheese"
                            select uppercaseIngrident;
        foreach (var item in dairyquery)
        {
            System.Console.WriteLine(item);
        }  
                          
     }
    }
}
