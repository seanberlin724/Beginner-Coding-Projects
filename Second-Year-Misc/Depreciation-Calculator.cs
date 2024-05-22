/******************Block Comment***********************
 * Sean Berlin
 * Program Description: Various methods of depreciation are used by businesses
 *  for various assets. One such method, Sum of the Years, accelerates depreciation 
 *  through the "life" of an asset. 
 * The sum of the years method for computing the yearly depreciation of an asset 
 * is determined by the following: 
 * The sum of the years of useful life are summed up:. 
 * i.e., 5 years = 1 +2 +3 +4 + 5 = 15 
 * . 
 * The first year, the depreciation is 5/15 of the original bookvalue. The second year,
 * the depreciation is 4/15 of the original bookvalue. 
 * Etc. 
 * Bookvalue = original - total accumulated depreciation. 
 * Write a program to compute the yearly depreciation for an item whose purchase price, 
 * salvage value, and expected years of service are entered by the user. 
 * Statements Required: input, output, and loop control 
 * Sample Output: 
 * Original cost = 1500.00 Scrap value = 200.00 Estimated life = 6 
 * Method SUM OF YEARS 
 * Year Annual Accumulated Depreciation Depreciation 
 * 371.43 371.43 309.52 680.95 247.62 928.57 185:71 1114.29 123.81 1238.10 61,90 1300.00 
 * a u A w Nm 
 * Book Value 1128,57 819.05 571.43 385.71 261.90 200.00 
 * (continued next page) 
 * Sample Output: program 164h (continued) 
 * Original cost = 7555:00 Scrap value = 100.00 Estimated life = 10 
 * : 
 * Method SUM OF YEARS 
 * Year Annual Accumulated 
 * Depreciation Depreciation 1 1355.45 1355.45 2. 1219.91 2575.36 
 * 1084.36 3659.73 948.82 4608.55 813.27 5421.82 677.73 6099.55 542.18 6641.73 
 * 406.64 7048.36 9 271.09 7319.45 10 135.55 7455.00 
 * Book 
 * Value 6199.55 4979.64 3895,27 2946.45 2133.18 1455.45 913.27 506.64 
 * . 
 * .!, 
 * : 
 * : 
 * 3 0, มา 
 * 100.00 
 * . 
 * Original cost = 100.00 Scrap value = 10.00 Estimated life 3 
 * Method 
 * SUM OF YEARS 
 * Year Annual Accumulated Depreciation Depreciation 
 * 45.00 45.00 30.00 . 75.00 15.00 · 90.00 
 * Book Value 55,00 25.00 10.00 
 * WN 
 * 
 * 
 * *****************************
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DepreciationCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Original Cost: ");
            double orignalCost = Convert.ToDouble(Console.ReadLine());

            Console.Write("Scrap Value: ");
            double scrapValue = Convert.ToDouble(Console.ReadLine());
            double newOriginalCost = orignalCost - scrapValue;

            Console.Write("Estimated Life: ");
            double estimatedLife = Convert.ToDouble(Console.ReadLine());
            double magicNumber = estimatedLife + 1;
            double tester = estimatedLife;

            double totalAccumulation = 0;
            double years = 1;
            Console.WriteLine("\nMethod \tSum of Years");

            Console.WriteLine("\nYear \tAnnual \t\tAccumulated \tBook");
            Console.WriteLine("\tDepreciation \tDepreciation \tValue");

            do
            {
                double totalSumOfYears = totalSumOfYearsCalc(estimatedLife);
                tester--;
                do
                {
                    magicNumber--;
                    // double depreciationValue= firstAnnualDepreciationCalc( newOriginalCost, estimatedLife, totalSumOfYears);
                    double newDepreciationValue = annualDepreciationCalc(newOriginalCost, magicNumber, totalSumOfYears);
                    double depreciationValueSave = accumulatedDepreciationSaver(newDepreciationValue); //this is an attempt to add the past depreciation value
                                                                                                       //need to somehow get this value and send it to accumulatedDepreciationCalc

                    double newTotalAccumulatedDepreciation = accumulatedDepreciationCalc(newDepreciationValue, depreciationValueSave);
                    //double totalAccumulation = 0; //problem is cause totalAccumulation gets set to 0 everytime, but i need it to accumulate
                    totalAccumulation = totalAccumulation + depreciationValueSave;

                    double newBookValue = bookValueCalc(orignalCost, totalAccumulation);
                    Console.WriteLine("{0} \t{1:C} \t{2:C} \t{3:C}", years, newDepreciationValue, totalAccumulation, newBookValue); //use total accumulation for secound variable
                    years = years + 1;

                } while (tester != tester);

            } while (tester > 0);
            Console.ReadLine();
        }
        public static double accumulatedDepreciationSaver(double newDepreciationValue)
        {
            return newDepreciationValue;
        }
        public static double firstAnnualDepreciationCalc(double newOriginalCost, double estimatedLife, double totalSumOfYears)
        {
            double depreciationValue = newOriginalCost * (estimatedLife / totalSumOfYears);  //6/21;
            return depreciationValue;
        }
        public static double annualDepreciationCalc(double newOriginalCost, double magicNumber, double totalSumOfYears)
        {
            double newDepreciationValue = newOriginalCost * (magicNumber / totalSumOfYears);  //6/21;
            return newDepreciationValue;
        }
        public static double accumulatedDepreciationCalc(double newDepreciationValue, double depreciationValueSave)
        {
            double totalAccumulatedDepreciation = 0 + depreciationValueSave;
            return totalAccumulatedDepreciation;
        }
        public static double totalSumOfYearsCalc(double estimatedLife)
        {
            double sumOfYearsCounter = 1.0;
            double totalSumOfYears = 0.0;
            while (sumOfYearsCounter <= estimatedLife)
            {
                totalSumOfYears += sumOfYearsCounter;
                ++sumOfYearsCounter;
            }
            return totalSumOfYears;
        }
        public static double bookValueCalc(double originalCost, double totalAcuumulation)
        {
            double bookValue = originalCost - totalAcuumulation;
            return bookValue;
        }
    }
}
