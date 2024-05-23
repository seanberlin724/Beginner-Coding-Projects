using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//mutator (methods) used to change instance variables
//accessor just 'gets' them to use them
namespace The_Employee_Class
{
    
    class Employee
    {
        private string nameOfEmployee;
        private double salesAmountForWeek;
        private double totalSalesCompensation;
        private double federalTaxRateReduction;
        private double retirementContribution;
        private double socialSecurityTaxReduction;
        private double takeHomeValue;
        public Employee() //constructor defaults
        {
            nameOfEmployee = "Sean";
            salesAmountForWeek = 1000.0;
            totalSalesCompensation = 70;
            federalTaxRateReduction = 12.6;
            retirementContribution = 7;
            socialSecurityTaxReduction = 4.2;
            takeHomeValue = 0.0;

            //totalSalesCompensation = 
        }
        public Employee(string nameOfEmployee, double salesAmountForWeek)
        {
            this.nameOfEmployee = nameOfEmployee;
            this.salesAmountForWeek = salesAmountForWeek;
            //this.FederalTaxReduction();
            //RetirementContribution();
            //SocialSecurityTaxReduction();

        }
        public double TotalSalesCompensation
        {
            get { return salesAmountForWeek * 0.07; }
            set { totalSalesCompensation = value; }
        }
        public void totaSalesCompensation()
        {
            this.totalSalesCompensation = salesAmountForWeek * 0.07;
        }
        //public double FederalTaxReduction
        //{
        //    get { return totalSalesCompensation -  (totalSalesCompensation*0.18); }
        //    set { federalTaxRateReduction = value; }
        //}
        //public double RetirementContribution
        //{
        //    get { return totalSalesCompensation - (totalSalesCompensation * 0.10); }
        //    set { retirementContribution = value; }
        //}
        //public double SocialSecurityTaxReduction
        //{
        //    get { return totalSalesCompensation - (totalSalesCompensation * 0.06); }
        //    set { socialSecurityTaxReduction = value; }
        //}
        public void FederalTaxReduction()
        {
            federalTaxRateReduction = totalSalesCompensation * 0.18;
        }
        public void RetirementContribution()
        {
            retirementContribution = totalSalesCompensation * 0.10;
        }
        public void SocialSecurityTaxReduction()
        {
            socialSecurityTaxReduction = totalSalesCompensation * 0.06;
        }
        public void TakeHomeValue()
        {
            takeHomeValue = totalSalesCompensation - (federalTaxRateReduction + retirementContribution + socialSecurityTaxReduction);
        }
        public override string ToString()
        {
            return "First Name: " + nameOfEmployee +
                          "\nSales Amount For week: " + salesAmountForWeek.ToString("C") +
                          "\nMoney recieved from weekly sales:\t" + totalSalesCompensation.ToString("C") +
                          "\nFederal Tax Rate Amount:\t" + federalTaxRateReduction.ToString("C") +
                          "\nRetirement Contribution:\t" + retirementContribution.ToString("C") +
                          "\nSocial Security Tax Reduction:\t" + socialSecurityTaxReduction.ToString("C")+
                            "\nTake Home Value:\t" + takeHomeValue.ToString("C");
        }
    }
}
