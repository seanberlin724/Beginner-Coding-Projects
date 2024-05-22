/******************Block Comment***********************
 * Sean Berlin
 * Create a console application that will collect 10 names
 * in an array(call it Name[]) and 10 test scores(call it TestScore[]).
 * After the names and scores are entered have the results be displayed 
 * one at a time with a final average of the test scores.
 * You should have a method that displays the arrays.
Enter name 1: Joe
Enter score 1: 86
Enter name 2: Tom
Enter score 2: 93
and so on...

Results:
1. Joe 86
2. Tom 93
and so on…

Average score for the class is 85.4%.
 * 
 * 
 * *****************************
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays2
{
    class Program
    {
        static void Main(string[] args)
        {
            double avgTestScore = 0;
            string[] Name = new string[10];
            int[] TestScore = new int[10];
            for (int i = 0; i < Name.Length; i++)
            {
                Console.WriteLine("Enter name {0}: ", i+1);
                Name [i] = Convert.ToString(Console.ReadLine());
                Console.WriteLine("Enter score {0}: ", i+1);
                TestScore[i] = Convert.ToInt32(Console.ReadLine());
                avgTestScore += TestScore[i] ;
            }
            //gets average //divides by 1000 cause percent will multiply by 100
            double finalAvg = avgTestScore / 1000.0;  
          
            //printArrays
            printArrays( Name, TestScore);

            Console.WriteLine("{0:P}", finalAvg);
            Console.ReadKey();
        }
        public static void printArrays (string [] Name, int [] TestScore)
        {
            for (int i = 0; i < Name.Length; i++)
            {
                Console.WriteLine("{0}: {1}",Name[i],TestScore[i]);
            }
        }
    }
}
