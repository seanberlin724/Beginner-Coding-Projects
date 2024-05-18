/******************Block Comment***********************
 * Sean Berlin              Prd.1            9-12-18
 *
 * Make a well designed picture of a house.  
 * Your house could include but is not limited to windows, a door, a roof. 
 *  Your house should have a minimum of three colors. 
 * (Think sidewalk, garage, car, clouds, be creative)
 * *****************************
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex5_House
{
    class Program
    {
        static void Main(string[] args)
        {   
            Console.Title = "Big House";   
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("    \\|/"  );
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("             ================= ");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("    -o-");
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("            )V V V V V V V V V( ");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("    /|\\ ");
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("          )V V V V V V V V V V( ");
            Console.WriteLine("                  )V V V V V /^\\ V V V V V( ");
            Console.WriteLine("                 )V V V V  /  _   \\ V V V V( ");
            Console.WriteLine("                )V V V V V|  |#|  |V V V V V( ");
            Console.WriteLine("               )V V V V V |       | V V V V V(");
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("               ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~ ");
            Console.BackgroundColor = ConsoleColor.Gray;
            Console.WriteLine("               :::::####:::#####:::####:::##::");
            Console.WriteLine("               :::::####:::#####:::####:::##::");
            Console.WriteLine("               :::::####:::#####:::####:::##::");
            Console.WriteLine("               :::::::::::::::::::::::::::::::");
            Console.WriteLine("               :::::####:::I~~~~I:::####:::##:");
            Console.WriteLine("               :::::####:::I    I:::####:::##:");
            Console.WriteLine("               :::::####:::I,   I:::####:::##:");
            Console.WriteLine("               :::::####:::I____I:::####:::##:");
            Console.WriteLine("_______________________________________________");
            Console.BackgroundColor = ConsoleColor.Green;
            Console.WriteLine("_______________________________________________");
            Console.ReadLine();
        }
    }
}
