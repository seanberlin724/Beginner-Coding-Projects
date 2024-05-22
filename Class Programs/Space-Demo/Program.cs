/******************Block Comment***********************
 * Sean Berlin
 * This program demonstrates a simulation of an astronaut's activities in space.
 * 
 * Program Description:
 * The program simulates an astronaut's activities in space. It creates instances of the `Astronaut` and `Planet` classes
 * to represent an astronaut and a planet, respectively. The astronaut can perform actions such as exercising, eating,
 * jumping, and traveling between planets. Each action affects the astronaut's physical condition and location.
 * 
 * Classes Used:
 * - `Astronaut`: Represents an astronaut with properties such as first name, last name, weight, and fitness level.
 * - `Planet`: Represents a planet with properties such as name, distance from Earth, size, and presence of water and oxygen.
 * 
 * Sample Output:
 * The program demonstrates various activities of the astronaut, including jumping on a planet, exercising, eating, and
 * space traveling. Each action is accompanied by output displaying the current state of the astronaut and the planet.
 * 
 * Methods and Functionalities:
 * - `jump()`: Calculates and returns the height of the astronaut's jump on the current planet.
 * - `exercise(int hours)`: Simulates the astronaut exercising for a specified number of hours, improving fitness level.
 * - `eat(int calories)`: Simulates the astronaut consuming food, affecting weight and fitness level.
 * - `spaceTravel(Planet destination)`: Simulates the astronaut traveling to a different planet, updating the current planet.
 * 
 * Classes Used: `Astronaut`, `Planet`
 * *****************************
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Space_Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            Astronaut myAstro = new Astronaut("Mike", "Smith", 240, 3.5);
            //myAstro.LastName = "tom";
            Planet myEarth = new Planet("Mela", 100000.03, 2, false, false);

            Planet thePlanet = new Space_Demo.Planet("Sean", 1234, 25, true, true);
            Planet Joe = new Planet("Joe",12345,5.03,true,true);
            thePlanet.HasLife = false;
            Console.WriteLine(myAstro);
            Console.WriteLine("Jump on" +myAstro.CurrentPlanet.Name+ "at a height of" +myAstro.jump());
            myAstro.exercise(24);
            Console.WriteLine("Jump on" + myAstro.CurrentPlanet.Name + "at a height of" + myAstro.jump());
            myAstro.eat(10);
            Console.WriteLine("Jump on" + myAstro.CurrentPlanet.Name + "at a height of" + myAstro.jump());
            myAstro.exercise(100);
            Console.WriteLine("Jump on" + myAstro.CurrentPlanet.Name + "at a height of" + myAstro.jump());
            Console.WriteLine();
            myAstro.spaceTravel(myEarth);
            Console.WriteLine("Jump on" + myAstro.CurrentPlanet.Name + "at a height of" + myAstro.jump());
            //Console.WriteLine(myAstro);
            //Console.WriteLine();
            //myAstro.spaceTravel(thePlanet);

            //Console.WriteLine(myAstro.LastName); 
            //Console.WriteLine(myAstro);
            Console.ReadLine();
        }
    }
}
