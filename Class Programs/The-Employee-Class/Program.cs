/******************Block Comment***********************
 * Sean Berlin             Per.2             3-3-20
 * Level 3:  This level will require a self designed class.  The prompt will list all of the classes needs.  
 * You design and implement the parts.  (Employee, Student) 
 * The Employee Class
 * Write a program with an Employee() class that calculates and prints the take-home pay for a commissioned sales employee.
 * Allow the user to enter values for the name of the employee and the sales amount for the week.
 * Employees receive 7% of the total sales. Federal tax rate is 18%. Retirement contribution is 10%. Social Security tax rate is 6%.
 * Use appropriate constants, design an object-oriented solution, and write constructors.
 * Include at least one mutator and one accessor method.
 * Provide properties for the other instance variables.
 * Use the main program/client to enter all your data.
 * *****************************
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace The_Employee_Class
{
    class Program
    {
        static void Main(string[] args)
        {
            string nameOfEmployee = getName();
            double salesAmountForWeek = salesGetter();
            Employee myEmployee = new Employee(nameOfEmployee, salesAmountForWeek);
            // Console.WriteLine(myEmployee.TotalSalesCompensation);
            myEmployee.TotalSalesCompensation = salesAmountForWeek * 0.07;
           // myEmployee.totaSalesCompensation();
            myEmployee.FederalTaxReduction();
            myEmployee.RetirementContribution();
            myEmployee.SocialSecurityTaxReduction();
            myEmployee.TakeHomeValue();
            Console.WriteLine(myEmployee);
            Console.ReadLine();
        }
        public static string getName()
        {
            Console.Write("Name:");
            string name = Convert.ToString(Console.ReadLine());
            return name;
        }
        public static double salesGetter()
        {
            Console.Write("Sales Amount of the Week:");
            double salesAmount = Convert.ToDouble(Console.ReadLine());
            return salesAmount;
        }
    }
}
