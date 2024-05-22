/******************Block Comment***********************
 * Sean Berlin
 * Program Description: This program demonstrates the usage of StreamWriter and arrays in C#.
 * It generates a file named "Monkey.txt" with random sets of three numbers separated by commas.
 * Then, it reads the file using StreamReader to display the content on the console.
 * Additionally, it illustrates the basics of working with arrays, including array declaration,
 * initialization, and accessing elements.
 * 
 * Required statements: input, output, loop control, array structure, StreamWriter, StreamReader
 * 
 * Sample Output: 
 * Your file Monkey.txt was created.
 * The sum is : 15
 * 
 * *****************************
 */


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace StreanReaderWriterNotes
{
    class Program
    {
        static void Main(string[] args)
        {
            //lets make some random numbers...
            Random randy = new Random();
            //first we need to create a StreamWriter object
            string fileName = "Monkey.txt"; 
            StreamWriter myWriter = new StreamWriter(fileName);
            // note the error that you get if you dont have System.io
            //this allows me to open a s"stream" to a given file
            //Note: when you open a stream you MUST CLOSE it
            //when you are finished using it


            //making a file with random sets of 3#s
            //      with numberOfRows 25
            int numberOfRows = 25;
            int a, b, c;
            //make a loop to add numberOfRows to a file

            for (int i = 0; i < numberOfRows; i++)
            {
                a = randy.Next(1,101); //random # from 1 to 100
                b = randy.Next(1, 101);
                c = randy.Next(1, 101);
                myWriter.WriteLine(a + "," + b +","+c); //23,87,3
            }
            myWriter.Close(); //closing it

            Console.WriteLine("Your file "+ fileName + " was created.");
            Console.ReadLine();

            //////////////////////////////////////////////
            // when using data it is important that you know
            //  know the file setup...
            // int,int,int
            // ...and so on till the end of the file

            // Now we can open a StreamReader to the file

            //StreamReader myReader = new StreamReader(fileName); // opens direct link to myFile and puts cursor to top left
            //for (int i = 0; i < numberOfRows; i++)
            //{
            //    string tempRow = myReader.ReadLine();
            //    Console.WriteLine(tempRow);
            //}
            //myReader.Close();
            //Console.ReadLine();

            //////////////////////////
            //          Arrays 101'
            //  An array is a collection of the same type of data
            // for example int[] holds just ints
            //                 Buttons[] holds buttons
            //          when we declare an array most of the time
            //          we need to define its size!!!

            //int[,] points = new int[5, 7]; this is a 2 dimensional array
            int[] xValues = new int[5] {1,2,3,4,5}; // int array of 5 elements first position is zero last position will always be one less than the length

                                        //                          // [23,43,66,77,78]
                                        //the last spot will always be one less than the length
                                        //xValues[0] = 23; //store 23 in first sport or spot zero
                                        //xValues[1] = 43;
                                        //xValues[4] = 78;
                                        // collection of same type of data

            int sum = 0;
            for (int i = 0; i < xValues.Length; i++)
            {
                sum = xValues[i];
            }
            Console.WriteLine("The sum is : " + sum);
            Console.ReadLine();
        }
    }
}
