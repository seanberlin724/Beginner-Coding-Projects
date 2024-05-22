/******************Block Comment***********************
* Sean Berlin
*Write a program that converts a temperature given in Celsius to Fahrenheit.
*  Test the program by performing a compile-time initialization of 90 for the original Fahrenheit value. 
*  Display the original temperature and the formatted converted value. 
*  Go into your source code and change the initialization value. 
*  Rerun the application.
*  T(°C) = (T(°F) - 32) * 5 / 9
* *****************************
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX12_FtoC
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Fahrenheit to Celsius Converter";
            int Fahrenheit = 90;
            int Celsius = (Fahrenheit - 32) * 5 / 9;
            Console.WriteLine("When Fahrenehit equals {0:f2} then Celsius equals {1:f2}",Fahrenheit,Celsius);
            Console.ReadLine();
        }
    }
}
