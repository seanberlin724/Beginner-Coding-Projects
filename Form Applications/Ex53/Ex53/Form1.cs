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
 * Sean Berlin                          9-12-18
 * This is a program that shows the basics of
 * the c# program
 * Create a program called EX53 with a form that has 3 comboboxes,
 *  3 labels and a button. Each combobox should represent a choice for a meal.
 *   (Appetizer, Main Course, Dessert). Write code for the button to display 
 * the information selected by the users in the provided labels.
 * 
 * 
 * *****************************/
namespace Ex53
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
            label1.Text = comboBox1.Text;
            label2.Text = comboBox2.Text;
            label3.Text = comboBox3.Text;
        }
    }
}
