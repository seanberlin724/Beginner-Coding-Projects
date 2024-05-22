/******************Block Comment***********************
 * Sean Berlin
 * three number sort

Program Description: Create an external file that contains several sets of 
three digit numbers (three per line).  Read in 3 numbers at a time. 
Write a method(s) that will print out the largest one first, the middle one second 
and the smallest last. Continue reading these triplets until the end of file is reached. 

Hint: create a method that will compare two numbers and put them in the correct order. 
To switch the order a Swap(ref int x, ref int y) method will help.
Note the keyword ref to pass a reference to the method. 
This Swap function will become useful in later projects that require repeated swaps
to sort an array of data.  

Please understand that you need to swap the spots in the array not just print the numbers in order.  Please see me or ask questions if you do not understand the difference.

Statements Required: input, output, loop control, decision making, method

Make a file called threeNumberSortData.txt with the following numbers. Note there are NO spaces before and after each line and only 1 space in between each number.

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

Now lets try it with String!!!
In addition to sorting a file of numbers Im attaching a file that has 3 words per line.
Write code that will sort each line in alphabetic order.  
You will need to make additional methods that will help sort a set of three words. 
The idea is very similar to sorting numbers. 
Note that the words will be sorted based off their 
ASCII decimal values so you will need to use the CompareTo() method instead of == in your if statements.
Example: 
	string x = “apple”;
	string y = “banana”;
	string z = “apple”;
	x.CompareTo(z)  will be 0  //same word than 0
	x.CompareTo(y) will be 1        // x is before y than 
	y.CompareTo(x) will be -1

	if(x.CompareTo(z)<0){
		Swap(ref x, ref z);
}

threeWordSortData.txt

 * 
 * *****************************
 */


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Three_Number_Sort
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamReader myReader = new StreamReader("threeNumberSortData.txt");
            string lineInFile; //"12,12,3,5"
            for (int i = 0; i <= 19; i++)
            {
                while ((lineInFile = myReader.ReadLine()) != null)
                {
                    string[] numberStrs = lineInFile.Split(' '); //takes in first line of data
                    int[] numberInt = new int[3];
                    numberInt[0] = Convert.ToInt32(numberStrs[0]);  //converts string array into int array
                    numberInt[1] = Convert.ToInt32(numberStrs[1]);
                    numberInt[2] = Convert.ToInt32(numberStrs[2]);

                    //Array.ConvertAll(numberStrs.Split(' '), int.Parse);
                    if (numberInt[0] < numberInt[1]) //will swap first and second if first is greater than second
                    {
                        swap(ref numberInt[0], ref numberInt[1]);
                    }
                    for (int z = 0; z <= 19; z++)
                    {
                        if (numberInt[1] < numberInt[2]) //will swap second and third if second is greater than third
                        {
                            swap(ref numberInt[1], ref numberInt[2]);
                            if (numberInt[0] < numberInt[1])
                            {
                                swap(ref numberInt[0], ref numberInt[1]);
                            }
                        }
                    }
                    Console.WriteLine("{0}, {1}, {2}", numberInt[0], numberInt[1], numberInt[2]);
                }
            }
            StreamReader myWordReader = new StreamReader("threeWordSortData.txt");
            string wordsInFile;
            for (int w = 0; w <= 20; w++)
            {
                while ((wordsInFile = myWordReader.ReadLine()) != null)
                {
                    string [] wordStrs = wordsInFile.Split(' '); //takes in first line of data and splits each word by a space
                    if (wordStrs[0].CompareTo(wordStrs[1])> 0) //should be adam apple application
                    {
                        swapWords(ref wordStrs[0], ref wordStrs[1]);
                    }
                    for (int y = 0; y <= 20; y++)
                    {
                        if (wordStrs[1].CompareTo(wordStrs[2]) > 0) //will swap second and third if second is greater than third
                        { 
                            swapWords(ref wordStrs[1], ref wordStrs[2]);
                            if (wordStrs[0].CompareTo(wordStrs[1]) > 0)
                            {
                                swapWords(ref wordStrs[0], ref wordStrs[1]);
                            }
                        }
                    }
                    Console.WriteLine("{0}, {1}, {2}", wordStrs[0], wordStrs[1], wordStrs[2]);
                }
            }
            Console.ReadLine();
        }
        public static void swap(ref int x1, ref int x2) //will swap two numbers
        {
            int temp = x1;  //temp = 102
            x1 = x2;    //x1 = 89
            x2 = temp;
        }
        public static void swapWords (ref string x1, ref string x2) //will swap two words
        {
            string temp = x1;
            x1 = x2;    
            x2 = temp;
        }
    }
}



