/******************Block Comment***********************
 * Sean Berlin
 * Program Description: Use a single-subscripted array to solve the following problem.
 * A car dealer pays its salespeople on a commission basis. The salesperson receives 
 * $200 per week plus 9 percent of their gross sales for that week. For example, a 
 * salesperson who grosses $5000 in sales in a week receives $200 plus 9 percent of 
 * $5000, or a total of $650 (truncate to the nearest dollar). Write a program that 
 * determines how many of the salespeople earned salaries in each of the following ranges:
 * $200-$299
 * $300-$399
 * $400-$499
 * $500-$599
 * $600-$699
 * $700-$799
 * $800-$899
 * $900-$999
 * $1000-$1099
 * 
 * Required Statements: input, output, loop control, decision making, array structure
 * 
 * Data Location: P412a.txt has data with 30 car salesman's sales entries.
 * 5231 6543 8888 1242 8907 4567 9098 2432 7543 7332 6324
 * 1452 8652 9981 7812 3981 324 7651 2987 1888 2234 5111
 * 8765 3322 1235 876 567 910 7651 8111 9321 4654 3333
 * 
 * Sample output:
 * Salary     Frequency
 * $200-$299      5
 * $300-$399      2
 * $400-$499      2
 * $500-$599      1
 * $600-$699      3
 * $700-$799      7
 * $800-$899      2
 * $900-$999      4
 * $1000-$1099    4
 * 
 *****************************************************/


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Car_Salesman
{
    class Program
    {
        static void Main(string[] args)
        {

            StreamReader myReader = new StreamReader("Datas.txt"); //collects data from notepad
            string lineInFile = myReader.ReadLine();
            string[] salaryAsString = new string[32];
            salaryAsString = lineInFile.Split(' ');
            int[] salaryAsInt = new int[32]; //converts element from string array into element in int array
            int twoHundredSalary = 0;
            int threeHundredSalary = 0;
            int fourHundredSalary = 0;
            int fiveHundredSalary = 0;
            int sixHundredSalary = 0;
            int sevenHundredSalary = 0;
            int eightHundredSalary = 0;
            int nineHundredSalary = 0;
            int tenHundredSalary = 0;

            for (int i = 0; i < salaryAsInt.Length; i++) //does caculation with selected element and adds one to a frequency/category
            {

                salaryAsInt[i] = Convert.ToInt32(salaryAsString[i]);
                double calcSalary = (salaryAsInt[i] / 100) * 9 + 200;
                if (calcSalary >= 200 && calcSalary <= 299)
                {
                    twoHundredSalary++;
                }
                if (calcSalary >= 300 && calcSalary <= 399)
                {
                    threeHundredSalary++;
                }
                if (calcSalary >= 400 && calcSalary <= 499)
                {
                    fourHundredSalary++;
                }
                if (calcSalary >= 500 && calcSalary <= 599)
                {
                    fiveHundredSalary++;
                }
                if (calcSalary >= 600 && calcSalary <= 699)
                {
                    sixHundredSalary++;
                }
                if (calcSalary >= 700 && calcSalary <= 799)
                {
                    sevenHundredSalary++;
                }
                if (calcSalary >= 800 && calcSalary <= 899)
                {
                    eightHundredSalary++;
                }
                if (calcSalary >= 900 && calcSalary <= 999)
                {
                    nineHundredSalary++;
                }
                if (calcSalary >= 1000 && calcSalary <= 1099)
                {
                    tenHundredSalary++;
                }
            }

            //output
            Console.WriteLine("Salary \tFrequency");
            Console.WriteLine("$200-$299 \t{0}", twoHundredSalary);
            Console.WriteLine("$300-$399 \t{0}", threeHundredSalary);
            Console.WriteLine("$400-$499 \t{0}", fourHundredSalary);
            Console.WriteLine("$500-$599 \t{0}", fiveHundredSalary);
            Console.WriteLine("$600-$699 \t{0}", sixHundredSalary);
            Console.WriteLine("$700-$799 \t{0}", sevenHundredSalary);
            Console.WriteLine("$800-$899 \t{0}", eightHundredSalary);
            Console.WriteLine("$900-$999 \t{0}", nineHundredSalary);
            Console.WriteLine("$1000-$1099 \t{0}", tenHundredSalary);
            myReader.Close();
            Console.ReadLine();
        }
    }
}


