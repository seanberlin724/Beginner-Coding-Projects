/******************Block Comment***********************
 * Sean Berlin
 * Create a Console Application called Ex36_DigitCubeSumRegion.
 *  Modify looping Ex35_DigitCubeSum 
 *  to determine what integers of two, three, or four digits are equal to the sum of the cubes of their digits. 
 *  Hint: Creating a method will make this process much easier. 
 *  Note: Only a few numbers have these conditions. This program requires no input.
 *  When it is executed it should print only show a small list of numbers.
 * *****************************/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex36_DigitCubeSumRegion_Try2
{
    class Program
    {
        static void Main(string[] args)
        {
            for (long num = 10; num < 9999; num++)
            {
                if (num ==sumOfCubesOfDigits(num))
                {
                    Console.WriteLine(num);                  
                }
            }Console.ReadLine();
        }
        public static long sumOfCubesOfDigits(long num)
        {
            long sum = 0;
            long max = 1000000000000000000;
            while (max > num)
            {
                max = max / 10;
            }
            while (max > 0)
            {
                long digitt = num / max;
                //cube = digitt * digitt * digitt;
                sum = sum + (digitt * digitt * digitt);
                num = num % max; //152
                max = max / 10;
            }
            return sum;
        }
    }
}
