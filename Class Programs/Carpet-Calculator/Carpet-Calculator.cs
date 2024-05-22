/******************Block Comment***********************
 * Sean Berlin
 *Step by step walkthrough for creating a Carpet class: 
First -  Make a console application called CarpetCalculator -
this is the class that we will use to enter our data as well as create a
Carpet object with our Carpet class

Creating a Carpet class:
this class should have the properties\data field pricePerSqYard(price per square yard)
and noOfSquareYards(no of square yards) 
Create a Mutator(setter) and Accessor(getter) for the Price
Create a default constructor for Carpet
Create several more constructors for Carpet at least these
Carpet(double amountNeeded, double price)
Carpet(double price)
Methods that will be used
we will need to determine the total cost
we will need to set the number of square yards given the L and W(Mutator method)
we will need to get the number of square yards (Accessor method)
Interesting overload method for the ToString() method:
public override string ToString()
{
return "Price Per Square Yard: " + pricePerSqYard.ToString("C") + 
"\nTotal Square Yards: " + noOfSquareYards.ToString("F1") + 
"\nTotal Price: " + DetermineTotalCost().ToString("C");
}    
Next...  time to make the Client:
 Create an Carpet object
 Create variables for roomLength and roomWidth;
 Create a method that provides an introduction and instructions
 Create a method to get the Get the Dimensions (make one that can be used for both L&W)
 use the dimensions to set the square yards of the Carpet object
 finally call the override method and display your information
 like this Console.Write(putthenameoftheobjecthere);
It should display something like this:
Price Per Square Yard:  $12.25
Total Square Yards:  123.4 
Total Price:   $1,511.65
 * *****************************
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarpetCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            string response;
            do
            {
                string typeOfCarpet = typeOfCarpetGetter();
                //getUserInformation();
                double pricePerSqYard = getPricePerSqYard();
                double length = getLength();
                double width = getWidth();
                Carpet userCreatedCarpet = new Carpet(pricePerSqYard, length, width);
                Console.WriteLine("Reciept:\nType of Carpet:" + typeOfCarpet);
                Console.WriteLine(userCreatedCarpet);
                Console.WriteLine("Would you like to buy another type of carpet?");
                response = Convert.ToString(Console.ReadLine());
            } while (response.ToLower() == "yes");
            Console.WriteLine("Thank you for using Carpet Calculator");
            Console.ReadLine();
        }
        public static string typeOfCarpetGetter()
        {
            Console.WriteLine("What type of carpet would you like to buy? (Ex: nylon, polyester, wool)");
            string typeOfCarpet = Convert.ToString(Console.ReadLine());
            return typeOfCarpet;
        }
        public static double getPricePerSqYard()
        {
            Console.WriteLine("Enter the Price per square yard: ");
            double pricePerSqYard = Convert.ToDouble(Console.ReadLine());
            return pricePerSqYard;
        }
        public static double getLength()
        {
            Console.WriteLine("Enter the legnth of carpet you want: ");
            double length = Convert.ToDouble(Console.ReadLine());
            return length;
        }
        public static double getWidth()
        {
            Console.WriteLine("Enter the width of carpet you want: ");
            double width = Convert.ToDouble(Console.ReadLine());
            return width;
        }
    }
}



