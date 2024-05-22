using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Space_Demo
{
    class Planet
    {
        //instance variables
        private string name;
        private double diamter, gravity;
        private bool hasH2O;
        private bool haslife;

        public Planet()
        {
            name = "Earth";
            diamter = 7917.5;
            gravity = 9.8;
            hasH2O = true;
            haslife = true;
        }
        public Planet(string name, double diameter, double gravity, bool hasH20, bool hasLife)
        {
                this.name = name;
                this.diamter = diamter;
                this.gravity = gravity;
                hasH20 = true;
                this.haslife = haslife;
        }
        
        //constructor
        public Planet(string name)
        {
            this.name = name;       
        }
        //getter/setter
        public string Name
        {
            get { return name; }
        }
        public bool hasWater
        {
            get { return hasH2O; }
        }
        public bool HasLife
        {
            get { return haslife; }
            set { haslife = value;}
        }
        public double Gravity
        {
            get { return gravity; }

        }
        public double Diamter
        {
            get { return diamter; }
        }

        //mutator methods
        public void grow()
        {
            diamter += 10;
            gravity += 2; 
        }

        public override string ToString()
        {
            string temp1, temp2;
            if(haslife == true)
            {
                temp1 = "Has Life";
            }
            else
            {
                temp1 = "No Life";
            }
            if (hasH2O == true)
            {
                temp2 = "Has Water";
            }
            else
            {
                temp2 = "No Water";
            }
            return "\n\t\tPlanet Name:" + name +
                "\n\t\tDiamter: \t" + diamter +
                "\n\t\tGravity: \t" + gravity +
                "\n\t\t" + temp1 + " and " + temp2;
        }
    }
}
