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
 * Sean Berlin         Per.9                 6-5-19
 * This is a program that shows the basics of
 * the c# program
 *  Create a program to figure change. The program will accept the amount the 
omer owes. The second value will be the amount of money offered in payment. 
The program will calculate the amount of change required and tell the cashier exactly how to return the change.
The program will report the number of bills and coins that are required. 
The program will not suggest giving zero of any coin or bill.
 * 
 * 
 * *****************************/
namespace Ex61_ChangeMaking
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

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {

            double amountDue = Convert.ToDouble(this.textBox1.Text);   //2.50
            double amountOffered = Convert.ToDouble(this.textBox2.Text);  //3.00
            int difference = (int) ((amountOffered - amountDue) * 100);   //.50  -->  50.0  --> 50

            int NumberOf50s = difference / 5000;
            int NumberOf20s = difference % 5000 / 2000;
            int Numberof10s = difference % 5000 % 2000 / 1000;
            int Numberof5s = difference % 5000 % 2000 % 1000 / 500;
            int Numberof1s = difference % 5000 % 2000 % 1000 % 500 / 100;
            int NumberofQuarters = difference % 5000 % 2000 % 500 % 100 / 25;
            int NumberofDimes = difference % 5000 % 2000 % 500 % 100 % 25 / 10;
            int NumberofNickels = difference % 5000 % 2000 % 500 % 100 % 25 % 10 / 5;
            int NumberofPennies = difference % 5000 % 2000 % 500 % 100 % 25 % 10 % 5 /1;

            

            listBox1.Items.Clear();
            if (NumberOf50s>0)
            {
                listBox1.Items.Add(NumberOf50s+ " Fifty(s)");
            }

            if (NumberOf20s > 0)
            {
                listBox1.Items.Add(NumberOf20s + " Twenty(s)");
            }

            if (Numberof10s > 0)
            {
                listBox1.Items.Add(Numberof10s + " Ten(s)");
            }

            if (Numberof5s > 0)
            {
                listBox1.Items.Add(Numberof5s + " Five(s)");
            }
           

            if (Numberof1s > 0)
            {
                listBox1.Items.Add(Numberof1s + " One(s)");
            }

            if (NumberofQuarters > 0)
            {
                listBox1.Items.Add(NumberofQuarters + " Quarter(s)");
            }

            if (NumberofDimes > 0)
            {
                listBox1.Items.Add(NumberofDimes + " Dime(s)");
            }

            if (NumberofNickels > 0)
            {
                listBox1.Items.Add(NumberofNickels + " Nickel(s)");
            }

            if (NumberofPennies > 0)
            {
                listBox1.Items.Add(NumberofPennies + " Pennie(s)");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
