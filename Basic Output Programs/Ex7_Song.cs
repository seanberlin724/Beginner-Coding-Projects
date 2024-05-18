/******************Block Comment***********************
* Sean Berlin              Per.9            9-12-18
* This is a program that shows the basics of
* the c# program
* 
*  Produce a listing containing your favorite saying or part of a song. 
*  Double space the output and print the saying one word per line. 
*  You may only use one Console.WriteLine().
* *****************************
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex7_Song
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "U.S.A. Song Saying";
            Console.WindowWidth = 75;
            Console.Write("O'er \n\nthe \n\nland \n\nof \n\nthe \n\nfree \n\nand \n\nthe \n\nhome \n\nof \n\nthe \n\nbrave?");
            Console.ReadLine();
        }
    }
}
