/******************Block Comment***********************
* Sean Berlin
* Create an application that produces the following output.  It should be displayed on three lines, 
* exactly as it appears here:
Just Play
Have Fun
Enjoy the Game
* You may only use ONE Console.WriteLine() statement.
* *****************************
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex6_Saying
{
    class Program
    {
        static void Main(string[] args)
        {            
            Console.Title = "Sports Saying";
            Console.WriteLine("Just Play \n Have Fun \n Enjoy the Game");
            Console.ReadLine();
        }
    }
}
