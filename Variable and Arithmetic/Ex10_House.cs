/******************Block Comment***********************
* Sean Berlin
* Design an application that displays the number of square feet in a house. 
* Declare and initialize the length and width of the house to 37 and 22, respectively. 
* use appropriate variable names.
*  Go into your source code and change the initialization values. 
*  Rerun the application and confirm your expected house area. 
* Don't forget to comment your code!!!!
* *****************************
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX10_House
{
    class Program
    {
        static void Main(string[] args)
        { 
            Console.Title = "Length and Width of House";
            Console.SetWindowSize(80, 15);  
            int Length = 50;
            int Width = 25;
            int area = Length * Width;
            Console.WriteLine("When the width is {0:f2} and the length is {1:f2} the area of the house is {2:f2} sq.ft.",Width,Length,area);
            Console.SetCursorPosition(20, 10);
            Console.WriteLine("Hit enter to end");
            Console.ReadLine();
        }
    }
}
