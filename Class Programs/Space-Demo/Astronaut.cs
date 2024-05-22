using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Space_Demo
{
    class Astronaut
    {
        //instance vars         attributes
        private string firstName, lastName;     //sooject can decide whether to give info out
        private double weight, fitness;
        private Planet currentPlanet;
        private bool helmet;
      
        //constructor //makes varaibles have values when program starts//defaults
        public Astronaut()
        {
            firstName = "John";
            lastName = "Doe";
            weight = 100.01;
            fitness = 8.33; //real fit
            helmet = true;
            currentPlanet = new Planet("Earth");
        }
        public Astronaut(string firstName, string lastName, double weight, double fitLevel)
        {
            this.firstName = firstName; //this refers to this first name of this object
            this.lastName = lastName;
            this.weight = weight;
            this.fitness = fitLevel;
            helmet = true;
            currentPlanet = new Planet("Earth");
        }

        //getters and setters
        public string FirstName
        {
            get{ return firstName; }
            //ask for first name and it will return first name

        }
        public string LastName
        {
            get { return lastName; }
            set { lastName = value; }
        }
        public double Weight //not spelled exactly same on purpose. Sometime _Weight
        {
            get { return weight; }
        }
        public double Fitness //not spelled exactly same on purpose. Sometime _Weight
        {
            get { return fitness; }
        }
        public Planet CurrentPlanet //not spelled exactly same on purpose. Sometime _Weight
        {
            get { return currentPlanet; }
        }

        //Mutator and Accessor Methods
        public void eat(double amtFood)
        {
            weight += amtFood;
            fitness -= .1 * amtFood;
        }
        public void exercise(int hrs)
        {
            weight -= hrs;
            fitness++;
        }
        public void poop()
        {
            weight -= 3.5;
        }
        public void sleep(int amt)
        {
            fitness+= amt;
        }
        public void spaceTravel(Planet destinationPlanet)
        {
            currentPlanet = destinationPlanet;
        }
        public void getCurrentPlanetName()
        {
            return currentPlanet.Name;
        }
        //make a jump method
        //return double for the height of the jump
        public double jump()
        {
            double height =  (8 * currentPlanet.Gravity * fitness) / weight;
            return height;
        }
        public override string ToString()
        {
            return "First Name:  " + firstName +
                         "\nLast Name:  " + lastName +
                          "\nFitness:  " + fitness +
                            "\nWeight:  " + weight +
                            "\nHas Helmet:  " + helmet +
                            "\nCurrent Planet: " + currentPlanet;  
        }
    }
}
