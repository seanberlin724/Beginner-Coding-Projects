/******************Block Comment***********************
 * Sean Berlin             Per.2             9-9-19
 *three number sort
Program Description: Create an external file that contains several sets of three digit numbers 
(three per line). Read in 3 numbers at a time. Write a method(s) that will print out the largest 
one first, the middle one second, and the smallest last. Continue reading these triplets until the
end of file is reached.
 * 
 * Hint: create a method that will compare two numbers and put them in the correct order. 
 * To switch the order a Swap(ref int x, ref int y) method will help. Note the keyword ref 
 * to pass a reference to the method. This Swap function will become useful in later projects 
 * that require repeated swaps to sort an array of data.
 * 
 * Statements Required: input, output, loop control, decision making, method
 * 
 * Make a file called data.txt with the following numbers.

89 56 102
103 57 90
91 104 58
59 92 105
107 20 50
60 108 10
2 77 34
87 76 54
78 56 34
67 43 56
88 55 88
12 32 21
66 23 54
56 21 99
123 654 333
23 222 1
98 23 77
123 66 22
12 5 87


Sample output:
102 89 56
103 90 57
104 91 58
105 92 59
107 50 20
108 60 10
and so on...

 * 
 * *****************************
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace The_ref_Keyword_is_C
{
    class Program
    {
        static void Main(string[] args)
        {
            // Read from the file
            StreamReader myReader = new StreamReader("data.txt");
            string lineInFile;

            // Process each line of the file
            for (int i = 0; i <= 19; i++)
            {
                while ((lineInFile = myReader.ReadLine()) != null)
                {
                    string[] numberStrs = lineInFile.Split(' '); 
                    int[] numberInt = new int[3];
                    numberInt[0] = Convert.ToInt32(numberStrs[0]);  
                    numberInt[1] = Convert.ToInt32(numberStrs[1]);
                    numberInt[2] = Convert.ToInt32(numberStrs[2]);

                    // Sort the numbers in descending order
                    if (numberInt[0] > numberInt[1])
                    {
                        swap(ref numberInt[0], ref numberInt[1]);
                    }
                    for (int z = 0; z <= 19; z++)
                    {
                        if (numberInt[1] > numberInt[2])
                        {
                            swap(ref numberInt[1], ref numberInt[2]);
                            if (numberInt[0] > numberInt[1])
                            {
                                swap(ref numberInt[0], ref numberInt[1]);
                            }
                        }
                    }
                    // Print the sorted numbers
                    Console.WriteLine("{0} {1} {2}", numberInt[0], numberInt[1], numberInt[2]);
                }

            }

            Console.ReadLine();
        }

        // Method to swap two numbers
        public static void swap(ref int x1, ref int x2)
        {
            int temp = x1;  
            x1 = x2;    
            x2 = temp;
        }
    }
}
