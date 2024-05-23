using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace The_Dog_Class
{
    class dog
    {
        private string name, color, breed;
        private double weight;
        
        //contructor
        public dog()
        {
            name = "John";
            color = "brown";
            breed = "boxer";
            weight = 15;
        }

        public dog(string name, string color, string breed, int weight)
        {
            this.name = name;
            this.color = color;
            this.breed = breed;
            this.weight = weight;
        }

        public void Walk() //looses weight
        {
            weight -= 2;     
        }

        public void Eat()    //gains weight
        {
            weight += 3;   
        }
        public void RunAway(string name) //changes name to user input
        {
            this.name = name;        
        }
      
        public void GeneticModification() //changes breed, color, weight
        {
            breed = "English Golden Retriever";
            color = "light gold";
            weight = weight * 1.5;
        }

        public void shed() //looses weight
        {
            weight -= .25;
        }

        public void groomer(string color) //changes color
        {
            this.color = color;
        }
 
        public override string ToString()
        {
            return "Name:\t" + name +
            "\nWeight:\t" + weight.ToString("F1") + " kg" +
            "\nBreed:\t" + breed +"\nColor:\t" +color;
        }
    }   
}
