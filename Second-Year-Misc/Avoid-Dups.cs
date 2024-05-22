/******************Block Comment***********************
 * Sean Berlin
 * Program 415h (avoiding duplicates) 
Program Description: 
Use a single-subscripted array to solve the following problem. 
Read in 20 numbers, each of which is between 10 and 100, inclusive.
As each number is read, print it only if it is not a duplicate of a number already read.
Provide for the "worst case" in which all 20 numbers are different 
Use the smallest possible array to solve this problem. 
Required Statements: input, output, loop control, decision making, array structure 
Data file: P415h.txt 
12 12 30 12 45 66 78 30 82 19 99 11 11 15 31 18 51 17 12 17 
Sample output: 
The original set of numbers are: 12 12 30 12 45 66 78 30 82 19 99 11 11 15 31 18 51 17 12 17 The different numbers from the set of integers are: 12 30 45 66 78 82 19 99 11 15 31 18 51 17 

 * 
 * *****************************
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Avoid_Dups__Program_415_
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamReader myReader = new StreamReader("Data.txt"); // Collects data from the file
            string lineInFile = myReader.ReadLine(); // Reads the line from the file
            string[] number = lineInFile.Split(','); // Splits the line into numbers

            Console.WriteLine("The original set of numbers are: {0}", string.Join(" ", number));
            Console.WriteLine("The different numbers from the set of integers are:");

            for (int i = 0; i < number.Length; i++)
            {
                bool isDuplicate = false;
                for (int j = 0; j < i; j++)
                {
                    if (number[i] == number[j])
                    {
                        isDuplicate = true;
                        break;
                    }
                }
                if (!isDuplicate)
                {
                    Console.Write(" {0}", number[i]);
                }
            }

            Console.ReadLine();
            myReader.Close();
        }
    }
}
