/******************Block Comment***********************
 * Sean Berlin
 * Create a dog class where the each dog object has 4 instance variables name, 
 * weight, color and breed. The dog should have methods walk(),eat(),runAway()
 * and geneticModification(). Please add 2 additional methods that change an 
 * instance variable in some way. (Ask if you need suggestions). 
 * When a dog object uses the walk() method it changes the weight appropriately.
 * Same for eat(), it eats and gains a bit of weight. 
 * When the runAway() method is activated the dog object’s name needs to change to its new owners liking.
 * Finally the geneticModification() method changes is breed, color and weight.
 * The dog class should also include a override toString() method that returns a string of the dog’s stats. 
Name:        Spot
Weight:    9.3 kg
Breed:        Dachshund
Color:         Green

In addition to the dog class, create a client program that allows viewing access to
the instance variables and demonstrates what the dog object can do.  
In other words show dog stats, make it eat, show dog stats, make it run,
show dog stats, make it do something, show stats.  
This will provide a clear view of how each method affects the dog object. 

ToString() method:
public override string ToString()
{
  return "Name:\t" + name +
  "\nWeight:\t" + weight.ToString("F1") + " kg"
  "\nBreed:\t" + breed
  “\nColor:\t” + color;
}
 * *****************************
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace The_Dog_Class
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This is your default dog");
            dog defaultDog = new dog("Joe", "Gold", "American Golden Retriever", 15);
            Console.WriteLine(defaultDog);
            Console.WriteLine("-----------------");

            Console.WriteLine("This is your dog after walking it:");
            //dog walkDog = new dog("Joe", "tan", "Golden Retriever", Wal);
            defaultDog.Walk();
            Console.WriteLine(defaultDog);
            Console.WriteLine("-----------------");

            Console.WriteLine("This is your dog after it eating:");
            //dog eatDog = new dog();
            defaultDog.Eat();
            Console.WriteLine(defaultDog);
            Console.WriteLine("-----------------");

            Console.WriteLine("You found a dog that ran away:");
            //string newName = getNewName();
            dog newDog = new dog("No Name", "black", "boxer", 25);
            newDog.RunAway(getNewName());
            Console.WriteLine(newDog);
            Console.WriteLine("-----------------");

            Console.WriteLine("This is your dog if it were genetically modified:");
            //dog geneticDog = new dog();
            defaultDog.GeneticModification();
            Console.WriteLine(defaultDog);
            Console.WriteLine("-----------------");

            Console.WriteLine("This is your default dog if it sheded:");
            //dog shedDog = new dog();
            defaultDog.shed();
            Console.WriteLine(defaultDog);
            Console.WriteLine("-----------------");

            Console.WriteLine("This is your dog if it went to the groomer and got its hair color changed:");
            //dog groomedDog = new dog();
            defaultDog.groomer(getNewColor());
            Console.WriteLine(defaultDog);
            Console.WriteLine("-----------------");

            Console.ReadLine();
        }
        public static string getNewName()
        {
            Console.WriteLine(" Enter what you would like to name it:");
            string name = Convert.ToString(Console.ReadLine());
            return name;
        }

        public static string getNewColor()
        {
            Console.WriteLine("Your dog went to the groomer and got its hair color changed. \tEnter the color you would like it to be:");
            string newColor = Convert.ToString(Console.ReadLine());
            return newColor;
        }
    }
}
