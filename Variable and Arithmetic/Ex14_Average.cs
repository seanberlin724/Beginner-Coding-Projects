/******************Block Comment***********************
* Sean Berlin 
* Write a program that computes the average of five exam scores.
* Declare and perform a compile-time initialization with the five values.
* The means the values will be assigned when you click the GREEN triangle. 
* Use a constant (const) to define the number of scores(5). 
* Print all scores and the average value formatted with no digits to the right of the decimal. 
* Make sure to use the string fromatting as discussed in class(L2_VariablesAndOperations)
* Rerun with different values to make sure your application finds the average correctly.
* *****************************
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX14_Average
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Average for Five Test Scores";
            string name = "Jeff";
            string markingPeriodPerformance = "good";
            int firstTestScore = 85;
            int secondTestScore = 86;
            int thirdTestScore = 87;
            int fourthTestScore = 88;
            int fifthTestScore = 89;
            float averageOfTestScores= (firstTestScore + secondTestScore + thirdTestScore + fourthTestScore + fifthTestScore) / 5;
            Console.WriteLine("{0:f2} had a {1:f2} marking period. \nThe first test score was {2:f2}%. \nThe second test score was {3:f2}%.\nThe third test score was {4:p2}.\nThe fourth test score was {5:f2}%\nThe fifth test score was {6:f2}%.\nThe marking period avergae is {7:f2}%", name, markingPeriodPerformance, firstTestScore, secondTestScore, thirdTestScore, fourthTestScore, fifthTestScore, averageOfTestScores); 
            Console.ReadLine();
        }
    }
}
