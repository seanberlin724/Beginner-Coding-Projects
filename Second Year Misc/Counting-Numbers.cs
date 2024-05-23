/******************Block Comment***********************
 * Sean Berlin
 * Program Description: You are to read an external file of random integer values until the end of
 * file is found. As you read the file, you should determine how many numbers are less than the
 * value 500 and how many numbers are greater than or equal to 500.
 * Statements Required: external file input, output, loop control, decision making
 * 
 * Data Location: Program 215a.txt (create this file with the numbers below. You can use notepad)
 * Sample Output:
 * The number of numbers less than 500 is 192
 * The number of numbers greater than or equal to 500 is 208
 * The total number of numbers is 400
 * 
 * DATA:
 * 123,54,67,38,875,43,88,222,35,677,84,10,32,1,500,7,543,678,94,23,754,32,500,654,861,23,56,77,98,95,4
 * 8,78,64,222,467,871,983,816,278,632,754,8,7,234,654,691,455,987,123,1,45,543,67,23,45,6,982,8,95,743
 * ,5,982,4,0,29,584,357,94,385,72,394,570,98,5,3,6,9,5,6,500,3,402,1,809,2,43,587,234,888,356,807,2,3,45,
 * 98,777,458,72,357,823,45,723,911
 * 
 * *****************************
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Counting_Numbers__Program_209A_
{
    class Program
    {
        static void Main(string[] args)
        {
            string fileName = "Data.txt";
            StreamReader myReader = new StreamReader(fileName);

            string lineInFile = myReader.ReadLine(); 
            string[] number = lineInFile.Split(',');

            //converts string array into a int array
            int[] numberAsInt = new int[number.Length];
            int amountOfNumbersLess = 0;
            int amountOfNumbersGreater = 0;
            int totalNumberOfNumbers = 0;
            for (int i = 0; i < numberAsInt.Length; i++)
            {
                numberAsInt[i] = Convert.ToInt32(number[i]);
                if (numberAsInt[i] <500)
                {
                    amountOfNumbersLess++;
                }
                if (numberAsInt[i] >= 500)
                {
                    amountOfNumbersGreater++;
                }
                if (numberAsInt[i] >0)
                {
                    totalNumberOfNumbers++;
                }      
            }
            Console.WriteLine("The number of numbers less than 500 is {0}",amountOfNumbersLess);
            Console.WriteLine("The number of numbers greater than or equal to 500 is {0}",amountOfNumbersGreater);
            Console.WriteLine("The total number of numbers is {0}",totalNumberOfNumbers);
            Console.ReadLine();
            myReader.Close();
        }
    }
}
