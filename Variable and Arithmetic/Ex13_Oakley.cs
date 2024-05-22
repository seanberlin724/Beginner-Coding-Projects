 /******************Block Comment***********************
* Sean Berlin
* Write a program that calculates and prints the take-home pay for a commissioned sales employee.
* Perform a compile-time initialization and store the name of Jessica Oakley in the variable called employeeName. 
* Jessica received 7% of her total sales. 
* Her federal tax rate is 18%. She contributes 10% to a retirement program and 6% to Social Security.
*  Her sales this week were $28,000.
* Produce a formatted report showing the amount for each of the computed items. 
* Select appropriate constants. 
* After you finish displaying Jessica Oakley’s data, change the values and rerun the application.
* *****************************
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX13_Oakley
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Take-Home Pay for Comissioned Sales Employee";
            string employeeName= "Jessica Oakley";
            int weeklySales = 50000;
            double recievedFromTotalSales = .07 * weeklySales;
            double federalTaxRate = .18 * recievedFromTotalSales;
            double retirementProgram = .1 * recievedFromTotalSales;
            double socialSecurity = .06 * recievedFromTotalSales;
            double total = recievedFromTotalSales - federalTaxRate - retirementProgram - socialSecurity;
            Console.WriteLine("When the weekly sales of {0:f2} are ${1:f2} the amount recieved from total sales is ${2:f2} \nThe amount taken for  federal taxes is ${3:f0} \nThe amount taken for the retirement plan is ${4:f2} \nThe amount taken for social security is ${5:f2} \nThe take home pay is ${6:f2} ",employeeName,weeklySales,recievedFromTotalSales,federalTaxRate,retirementProgram,socialSecurity,total);
            Console.ReadLine();
        }
    }
}
