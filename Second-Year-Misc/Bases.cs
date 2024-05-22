/******************Block Comment***********************
 * Sean Berlin
 * Program 440 (around the bases) 
Program Description: Write a program that will print out a table of
numbers 0 to 35 in decimal, hex, octal, and binary notation. 
Statements Required: output, loop control, array 
Sample Output: 
Base: 
10 16 8 2 
0 0 0 00000000 1 1 1 00000001 2 2 2 00000010 3 3 3 00000011 4 4 4 00000100 5 5 5 00000101 6 6 6 00000110 7 7 7 00000111 8 8 10 00001000 9 9 11 00001001 10 a 12 00001010 11 b 13 00001011 12 c 14 00001100 13 d 15 00001101 14 e 16 00001110 15 f 17 00001111 16 10 20 00010000 17 11 21 00010001 
(more output here...) 
28 1c 34 00011100 29 1d 35 00011101 30 1e 36 00011110 31 1f 37 00011111 32 20 40 00100000 33 21 41 00100001 34 22 42 00100010 35 23 43 00100011 

 * 
 * *****************************
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bases__Program_440_
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[36];
            // counter 
            Console.WriteLine("Decimal\t Hexadeciaml\t Octal\t Binary");
            for (int decimalNumber = 0; decimalNumber < numbers.Length; decimalNumber++)
            {
                string deciToHexi = deciToHexiCalc(decimalNumber);
                string deciToOctal = deciToOctalCalc(decimalNumber);
                string deciToBinary = deciToBinaryCalc(decimalNumber);
                Console.WriteLine("{0}\t {1}\t\t {2}\t {3}", decimalNumber, deciToHexi, deciToOctal, deciToBinary);
            }
            Console.ReadLine();
        }
        public static string deciToHexiCalc(int decimalNumber)
        {
            //int num = 0;
            int remainder = 0;
            string hexaDecimal = "";
            string newRemainder = remainder.ToString();//set remainder to to strings
            while (decimalNumber > 0)//mod divide by 16
            {
                remainder = decimalNumber % 16;
                decimalNumber = decimalNumber / 16;
                if (remainder >= 10)
                {
                    if (remainder == 10) //if remiander  equals to 10 then convert remainder to string and set remainder to "a"
                    {
                        newRemainder = "A";
                    }
                    if (remainder == 11)
                    {
                        newRemainder = "B";
                    }
                    if (remainder == 12)
                    {
                        newRemainder = "C";
                    }
                    if (remainder == 13)
                    {
                        newRemainder = "D";
                    }
                    if (remainder == 14)
                    {
                        newRemainder = "E";
                    }
                    if (remainder == 15)
                    {
                        newRemainder = "F";
                    }
                    hexaDecimal = newRemainder + hexaDecimal;
                }
                else
                {
                    hexaDecimal = remainder + hexaDecimal;
                }
            }
            return hexaDecimal;
            //convert int to string
            //want string to display backwards
            //return string
        }
        public static string deciToOctalCalc(int decimalNumber)
        {
            //int num = 0;
            int remainder = 0;
            string octalDecimal = "";
            while (decimalNumber > 0)
            {
                remainder = decimalNumber % 8;
                decimalNumber = decimalNumber / 8;
                octalDecimal = remainder + octalDecimal;
            }
            return octalDecimal;
        }
        public static string deciToBinaryCalc(int decimalNumber)
        {
            //int num = 0;
            int remainder = 0;
            string binaryDecimal = "";
            while (decimalNumber > 0)
            {
                remainder = decimalNumber % 2;
                decimalNumber = decimalNumber / 2;
                binaryDecimal = remainder + binaryDecimal;
            }
            return binaryDecimal;
        }
    }
}



