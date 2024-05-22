/******************Block Comment***********************
* Sean Berlin
* Write a program that converts a temperature given in Celsius to Fahrenheit.
*  Test the program by performing a compile-time initialization of 37 for the original Celsius value. 
*  Display the original temperature and the formatted converted value. 
*  Go into your source code and change the initialization value. 
*  Rerun the application.
*
*  T(°F) = T(°C) × 9/5 + 32
* *****************************
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX11_Ctof
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Celsius to Fahrenheit Converter";
            int celsisus = 37;
            double fahrenheit = celsisus*9.0/5+32;
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("When celsius equals {0:f2} then fahrenheit equals {1:f2}", celsisus, fahrenheit);
            Console.ReadLine();
        }
    }
}
