using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
/******************Block Comment***********************
 * Sean Berlin              Per.9            5-23-19
 * This is a program that shows the basics of
 * the c# program
 * Create a program called EX59_TheDiner with one form that has appropriate objects
 * (textboxes, labels, buttons, etc...). 
 * Write code that allows an employee to enter an order and display a total including tax(6%).
 *  The more advanced code will include a tip(15%).

Please use ONLY the following menu to make checking each program more consistent.

Main Course Drink	Dessert
Burger ($1.49)	Water ($0.00) Ice Cream ($1.50) 
Hot dog ($.99)	Coke ($1.00)	Cake ($2.10)
Chicken ($1.85)	OJ ($1.55) nothing($0.00)
Soup and Salad ($2.02)	Sprite ($1.00)


Example:	Main Course	Burger $1.49
Drink	Coke	$1.00
Dessert	Cake	$2.10
________________________
Sub Total $4.59
tax	.28

Total $4.87 
tip	$ .73 
Final cost of meal $5.60
 * 
 * 
 * *****************************/
namespace Ex59_TheDiner
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            double total = 0.00;
            double subTotal = 0.00;

            //Main Course
            if (radioButton1.Checked == true)
            {
                subTotal = 1.49;
                label5.Text = "Main Course - Burger ($1.49)";
            }

            if (radioButton2.Checked == true)
            {
                subTotal = 0.99;
                label5.Text = "Main Course - Hot dog ($.99)";
            }

            if (radioButton3.Checked == true)
            {
                subTotal = 1.85;
                label5.Text = "Main Course - Chicken ($1.85)";
            }

            if (radioButton4.Checked == true)
            {
                subTotal = 2.02;
                label5.Text = "Drink-Soup and Salad ($2.02)";
            }
            //Drinks
            if (radioButton5.Checked == true)
            {
                subTotal = subTotal + 0;
                label6.Text = "Drink- Water ($0.00)";
            }

            if (radioButton6.Checked == true)
            {
                subTotal = subTotal + 1;
                label6.Text = "Drink- Coke ($1.00)";
            }

            if (radioButton7.Checked == true)
            {
                subTotal = subTotal + 1.55;
                label6.Text = "Drink- OJ ($1.55)";
            }

            if (radioButton8.Checked == true)
            {
                subTotal = subTotal + 1.00;
                label6.Text = "Drink- Sprite ($1.00)";
            }
            //Desserts
            if (radioButton9.Checked == true)
            {
                subTotal = subTotal + 1.50;
                label7.Text = "Dessert- Ice Cream ($1.50)";
            }

            if (radioButton10.Checked == true)
            {
                subTotal = subTotal + 2.10;
                label7.Text = "Dessert- Cake ($2.10)";
            }

            if (radioButton7.Checked == true)
            {
                subTotal = subTotal + 0.00;
                label7.Text = "Dessert- Nothing ($0.00)";
            }
            //subtotal
            label9.Text = "Subtotal " +subTotal.ToString("C");
            
            //TAX
            double tax = subTotal * .06;
            label10.Text = "Tax" + tax.ToString("C");

            //Tip
            double tip = subTotal * .15;
            label11.Text = "Tip" + tip.ToString("C");

            //Final Cost
            double finalCost = subTotal + tax + tip;
            label12.Text = "Final Cost" + finalCost.ToString("C");
        }
    }
}
